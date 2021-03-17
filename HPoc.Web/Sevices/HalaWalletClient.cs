using HPoc.Web.Requests;
using HPoc.Web.Results;
using HPoc.Web.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HPoc.Web.Sevices
{
    public class HalalWalletClient : IHalalWalletClient
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options = new() { PropertyNameCaseInsensitive = true };
        private readonly Store _store;

        public HalalWalletClient(IHttpClientFactory clientFactory, Store store)
        {
            _client = clientFactory.CreateClient("HalalPayAPI");
            _store = store;
        }
        // /api/Wallets/transfer

        public async Task<UserDetailsResult> GetUserDetails(string walletNumber)
        {
            var result = await GetAsync<UserDetailsResult>($"users/details/walletNumer/{walletNumber}");
            if (!string.IsNullOrWhiteSpace(result.WalletNumber))
            {
                _store.StoreLogin(result);
            }
            return result;
        }

        public async Task<RegisterationResult> Register(RegistrationRequest request)
        {
            var result = await PostAsync<RegisterationResult>(request, "users/register");
            if (!string.IsNullOrWhiteSpace(result.Wallet.WalletNumber))
            {
                _store.RegistredUsers.Add(result);
            }

            return result;
        }
        public async Task<FundTransferResult> TrasnferFund(FundtransferRequest request)
        {
            var result = await PostAsync<FundTransferResult>(request, "wallets/transfer");
            ////if (!string.IsNullOrWhiteSpace(result.ReceiverWalletNumber))
            ////{     
            ////    var receiver = _store.RegistredUsers.Where(c => c.Wallet.WalletNumber == result.ReceiverWalletNumber).FirstOrDefault() ?? new();
            ////    var sender = _store.RegistredUsers.Where(c => c.Wallet.WalletNumber == result.ReceiverWalletNumber).FirstOrDefault() ?? new();

            ////    _store.RegistredUsers.Remove(sender);
            ////    _store.RegistredUsers.Remove(receiver);

            ////    _store.RegistredUsers.Add(await GetUpdateDetails(sender.User.UserId));
            ////    _store.RegistredUsers.Add(await GetUpdateDetails(receiver.User.UserId));
            ////}
            return result;
        }


        public async Task<RegisterationResult> GetUpdateDetails(Guid userId)
        {
            var result = await GetAsync<List<RegisterationResult>>($"users/details") ?? new();
            if (result.Any())
            {
                return result.Where(r => r.User.UserId == userId).FirstOrDefault() ?? new();
            }

            return new();
        }
        #region
        ///api/Users/details/walletNumer/{walletNumer}
        private async Task<T> PostAsync<T>(object request, string endpoint) where T : class, new()
        {
            T result = new();
            var data =
                  new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(endpoint, data);
            var content = await response.Content.ReadAsStringAsync();

            try
            {

                if (response.IsSuccessStatusCode)
                {
                    result = JsonSerializer.Deserialize<T>(content, _options);
                }
                else
                {
                    var problemResults = JsonSerializer.Deserialize<string>(content, _options);
                    return new();
                }

            }
            catch (Exception ex)
            {
                //log error here
            }
            return result;
        }
        private async Task<T> GetAsync<T>(string endpoint) where T : class, new()
        {
            try
            {
                return await JsonSerializer.DeserializeAsync<T>
                (await _client.GetStreamAsync($"{endpoint}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }
            catch (Exception ex)
            {
                // _logger.LogError($"Could not get Account details from fcube:: :{ex.Message}", ex);

                return new();
            }
        }


        #endregion
    }
}

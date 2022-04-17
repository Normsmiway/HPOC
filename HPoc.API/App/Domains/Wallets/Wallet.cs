using System;
using System.Linq;
using Newtonsoft.Json;
using App.Domains.ValueObjects;
using System.Collections.Generic;
using System.Collections.Immutable;
namespace App.Domains.Wallets
{
    public sealed class Wallet : IAggregateRoot<Guid>
    {
        private TransactionCollection _transactions;
        public Guid Id { get; private set; }
        public string UserId { get; private set; }
        public WalletNumber WalletNumber { get; private set; }
        public WalletType WalletType { get; private set; }
        public string CurrencyCode { get; private set; }
        public IReadOnlyCollection<ITransaction> GetWalletTransactions(int take = 0)
        {
            IReadOnlyCollection<ITransaction> readOnly = _transactions.GetTransactions();
            if (take > 0)
                return readOnly.OrderByDescending(t => t.TransactionDate).Take(take).ToImmutableList();
            return readOnly;
        }
        [JsonConstructor]
        private Wallet(string userId, WalletNumber number, WalletType type, string currencyCode)
        {
            Id = Guid.NewGuid();
            WalletNumber = number;
            WalletType = type;
            CurrencyCode = currencyCode;
            _transactions = new TransactionCollection();
            UserId = userId;

            //raise new userwallet created domain event
        }

        public static Wallet Create(string userId,WalletNumber number,WalletType walletType,string currencyCode)
        {
            return new(userId, number, walletType, currencyCode);
        }

        public void FundWallet(Amount amount, string marchantrefence)
        {
            Credit credit = new(Id, amount, marchantrefence);
            _transactions.Add(credit);
        }

        public void Withraw(Amount amount, string narration)
        {
            if (_transactions.GetCurrentBalance() < amount)
                throw new InsuficientFundsException($"Insufficient fund ({amount})");
            Debit debit = new(Id, amount, narration);
            _transactions.Add(debit);

            //raise cash withrwal domain event
        }

        public Amount GetWalletBalance()
        {
            Amount totalAmount = _transactions.GetCurrentBalance();
            return totalAmount;
        }

        public void TransferFund(Guid receivingWalletId, Amount amount, string narration, string merchantReference)
        {
            Withraw(amount, narration);
            Credit credit = new(receivingWalletId, amount, merchantReference);
            _transactions.Add(credit);

            //raise cash transfer domain even
        }

        public ITransaction GetLastTransaction()
        {
            ITransaction transaction = _transactions.GetLastTransaction();
            return transaction;
        }
        public void Deactivate()
        {
            if (_transactions.GetCurrentBalance() > 0)
                throw new WalletCannotBeClosedException("Wallet with available fund cannot not be deactivated");
            
        }
        public Amount GetTotalIcome()
        {
            var incoming = _transactions.GetTotalDepoit();
            return incoming;
        }

        public Amount GetTotalExpenses()
        {
            var outgoing = _transactions.GetTotalWithdrawal();
            return outgoing;
        }
        private Wallet() { }

        public static Wallet Load(Guid id, string userId, string walletNumber,
            string walletType, string currencyCode, TransactionCollection transactions)
        {
            return new Wallet()
            {
                Id = id,
                UserId = userId,
                WalletNumber = walletNumber,
                WalletType = walletType,
                CurrencyCode = currencyCode,
                _transactions = transactions
            };
        }

    }
}

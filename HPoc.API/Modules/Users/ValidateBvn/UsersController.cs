using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Users.ValidateBvn
{
    public sealed class UsersController : BaseController
    {
        [HttpPost("bvn/validate", Name = "ValidateBVN")]
        public async Task<IActionResult> Post()
        {
            return await Task.FromResult(new ObjectResult(new { Id = 123 }));
        }
    }
}

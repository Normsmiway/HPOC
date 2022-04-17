using App.Applications.UseCases.Registers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Users.Register
{
    public sealed partial  class UsersController : BaseController
    {
        private readonly IRegister _register;

        public UsersController(IRegister register)
        {
            _register = register;
        }
        [HttpPost("register", Name = "Register")]
        public async Task<IActionResult> Post([FromBody]RegisterRequest request)
        {
            var result = await _register.Execute(request.Name, request.Email, request.PhoneNumber,
                request.DateOfBirth, request.InitialAmount);

            if(result is null) { return new NoContentResult(); }
    
             return await Task.FromResult(CreatedAtRoute("GetUserDetails", new { userId = result.User.UserId }, result));
        }
    }

 
}

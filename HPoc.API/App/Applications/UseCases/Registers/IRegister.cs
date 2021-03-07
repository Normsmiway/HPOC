using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Registers
{
    public interface IRegister
    {
        Task<RegisterResult> Execute(string name,
            string email, string phoneNumber,
            DateTime dateOfBirth, decimal intialAmount);
    }
}

using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Deactivate
{

    public interface IDeactivateAccount
    {
        Task<Guid> Execute(Guid walletId);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using Study52ABP.Authorization.Accounts.Dto;

namespace Study52ABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

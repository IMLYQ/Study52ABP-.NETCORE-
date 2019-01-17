using System.Threading.Tasks;
using Abp.Application.Services;
using Study52ABP.Sessions.Dto;

namespace Study52ABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Study52ABP.MultiTenancy.Dto;

namespace Study52ABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

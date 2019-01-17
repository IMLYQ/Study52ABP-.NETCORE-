using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Study52ABP.MultiTenancy;

namespace Study52ABP.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}

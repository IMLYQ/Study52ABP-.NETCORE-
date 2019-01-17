using Study52ABP.MultiTenancy.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Study52ABP.MultiTenancy
{
    public interface ITenantRegistrationAppService
    {
        /// <summary>
        /// 注册租户信息
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        Task<TenantDto> RegisterTenantAsync(CreateTenantDto input);
    }
}

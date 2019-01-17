using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Study52ABP.Roles.Dto;

namespace Study52ABP.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}

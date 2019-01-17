using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Study52ABP.Roles.Dto;
using Study52ABP.Users.Dto;

namespace Study52ABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Demo.Roles.Dto;
using Demo.Users.Dto;

namespace Demo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

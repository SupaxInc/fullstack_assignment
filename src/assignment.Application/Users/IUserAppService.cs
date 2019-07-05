using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using assignment.Roles.Dto;
using assignment.Users.Dto;

namespace assignment.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

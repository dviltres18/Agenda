using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Agenda.Roles.Dto;
using Agenda.Users.Dto;

namespace Agenda.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

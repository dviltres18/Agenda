using System.Threading.Tasks;
using Abp.Application.Services;
using Agenda.Authorization.Accounts.Dto;

namespace Agenda.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

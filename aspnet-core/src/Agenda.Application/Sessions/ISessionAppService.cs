using System.Threading.Tasks;
using Abp.Application.Services;
using Agenda.Sessions.Dto;

namespace Agenda.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

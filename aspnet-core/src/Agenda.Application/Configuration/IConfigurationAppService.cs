using System.Threading.Tasks;
using Agenda.Configuration.Dto;

namespace Agenda.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Agenda.Configuration.Dto;

namespace Agenda.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AgendaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

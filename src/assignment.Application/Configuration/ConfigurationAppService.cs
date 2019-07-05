using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using assignment.Configuration.Dto;

namespace assignment.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : assignmentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPDemoProject.Configuration.Dto;

namespace ABPDemoProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPDemoProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

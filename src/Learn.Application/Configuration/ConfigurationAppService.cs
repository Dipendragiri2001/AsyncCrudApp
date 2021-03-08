using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Learn.Configuration.Dto;

namespace Learn.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LearnAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

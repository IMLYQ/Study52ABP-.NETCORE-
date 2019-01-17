using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Study52ABP.Configuration.Dto;

namespace Study52ABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Study52ABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

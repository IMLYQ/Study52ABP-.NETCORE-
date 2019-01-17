using System.Threading.Tasks;
using Study52ABP.Configuration.Dto;

namespace Study52ABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

using System.Threading.Tasks;
using Learn.Configuration.Dto;

namespace Learn.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

using System.Threading.Tasks;
using assignment.Configuration.Dto;

namespace assignment.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

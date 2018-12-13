using System.Threading.Tasks;
using Abp.Application.Services;
using ABPDemoProject.Configuration.Dto;

namespace ABPDemoProject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
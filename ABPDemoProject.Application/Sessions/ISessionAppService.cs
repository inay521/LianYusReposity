using System.Threading.Tasks;
using Abp.Application.Services;
using ABPDemoProject.Sessions.Dto;

namespace ABPDemoProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

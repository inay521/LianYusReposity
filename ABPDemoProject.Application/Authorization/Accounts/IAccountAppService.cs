using System.Threading.Tasks;
using Abp.Application.Services;
using ABPDemoProject.Authorization.Accounts.Dto;

namespace ABPDemoProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

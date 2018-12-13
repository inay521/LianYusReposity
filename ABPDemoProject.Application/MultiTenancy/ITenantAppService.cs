using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPDemoProject.MultiTenancy.Dto;

namespace ABPDemoProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

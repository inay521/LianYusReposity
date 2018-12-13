using Abp.AutoMapper;
using ABPDemoProject.Sessions.Dto;

namespace ABPDemoProject.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
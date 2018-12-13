using System.Linq;
using ABPDemoProject.EntityFramework;
using ABPDemoProject.MultiTenancy;

namespace ABPDemoProject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPDemoProjectDbContext _context;

        public DefaultTenantCreator(ABPDemoProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

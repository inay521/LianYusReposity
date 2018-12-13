using ABPDemoProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPDemoProject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPDemoProjectDbContext _context;

        public InitialHostDbBuilder(ABPDemoProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

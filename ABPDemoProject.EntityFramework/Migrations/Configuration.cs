using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using ABPDemoProject.entity;
using ABPDemoProject.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace ABPDemoProject.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ABPDemoProject.EntityFramework.ABPDemoProjectDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ABPDemoProject";
        }

        protected override void Seed(ABPDemoProject.EntityFramework.ABPDemoProjectDbContext context)
        {
            context.DisableAllFilters();

            context.People.AddOrUpdate(p=>p.Name,
                new Person {Name="Zhangsan" },
                new Person { Name = "Lisi" },
                new Person { Name = "wangwu" });

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}

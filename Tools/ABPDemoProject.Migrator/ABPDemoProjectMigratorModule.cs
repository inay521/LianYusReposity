using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPDemoProject.EntityFramework;

namespace ABPDemoProject.Migrator
{
    [DependsOn(typeof(ABPDemoProjectDataModule))]
    public class ABPDemoProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPDemoProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
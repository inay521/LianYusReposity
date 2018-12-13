using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ABPDemoProject.EntityFramework;

namespace ABPDemoProject
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ABPDemoProjectCoreModule))]
    public class ABPDemoProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ABPDemoProjectDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

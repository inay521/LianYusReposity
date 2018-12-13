using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPDemoProject.EntityFramework.Repositories
{
    public abstract class ABPDemoProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPDemoProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPDemoProjectRepositoryBase(IDbContextProvider<ABPDemoProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPDemoProjectRepositoryBase<TEntity> : ABPDemoProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPDemoProjectRepositoryBase(IDbContextProvider<ABPDemoProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

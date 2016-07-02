using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace WexOne.EntityFramework.Repositories
{
    public abstract class WexRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WexDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WexRepositoryBase(IDbContextProvider<WexDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WexRepositoryBase<TEntity> : WexRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WexRepositoryBase(IDbContextProvider<WexDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

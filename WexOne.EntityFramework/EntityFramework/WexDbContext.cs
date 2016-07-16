using System.Data.Common;
using Abp.Zero.EntityFramework;
using WexOne.Authorization.Roles;
using WexOne.MultiTenancy;
using WexOne.Users;
using System.Data.Entity;
using WexOne.Core;
using WexOne.WeChat;

namespace WexOne.EntityFramework
{
    public class WexDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WexDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WexDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WexDbContext since ABP automatically handles it.
         */
        public WexDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WexDbContext(DbConnection connection)
            : base(connection, true)
        {

        }

        public IDbSet<WeChatEventLog> WeChatEventLogs { get; set; }
    }
}

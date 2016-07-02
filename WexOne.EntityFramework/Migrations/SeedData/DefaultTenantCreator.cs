using System.Linq;
using WexOne.EntityFramework;
using WexOne.MultiTenancy;

namespace WexOne.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly WexDbContext _context;

        public DefaultTenantCreator(WexDbContext context)
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

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == "Default");
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = "Default", Name = "Default"});
                _context.SaveChanges();
            }
        }
    }
}
using WexOne.EntityFramework;
using EntityFramework.DynamicFilters;

namespace WexOne.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly WexDbContext _context;

        public InitialHostDbBuilder(WexDbContext context)
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

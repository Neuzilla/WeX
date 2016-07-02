using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Zero.Configuration;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.Web.SignalR;
using WexOne.Api;
using Hangfire;

namespace WexOne.Web
{
    [DependsOn(
        typeof(WexOneDataModule),
        typeof(WexApplicationModule),
        typeof(WexWebApiModule),
        typeof(AbpWebSignalRModule),
        typeof(AbpHangfireModule),
        typeof(AbpWebMvcModule))]
    public class WexWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Enable localization
            Configuration.Localization.Languages.Add(new Abp.Localization.LanguageInfo("zh-CN", "中文", "famfamfam-flag-cn", true));
            Configuration.Localization.Languages.Add(new Abp.Localization.LanguageInfo("en", "English", "famfamfam-flag-us", false));

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<WexNavigationProvider>();

            //Configure Hangfire
            Configuration.BackgroundJobs.UseHangfire(configuration =>
            {
                configuration.GlobalConfiguration.UseSqlServerStorage("Default");
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

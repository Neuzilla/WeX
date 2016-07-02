using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace WexOne
{
    [DependsOn(typeof(WexOneCoreModule), typeof(AbpAutoMapperModule))]
    public class WexApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

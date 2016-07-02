using Abp.Web.Mvc.Views;

namespace WexOne.Web.Views
{
    public abstract class WexWebViewPageBase : WexWebViewPageBase<dynamic>
    {

    }

    public abstract class WexWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WexWebViewPageBase()
        {
            LocalizationSourceName = WexOneConsts.LocalizationSourceName;
        }
    }
}
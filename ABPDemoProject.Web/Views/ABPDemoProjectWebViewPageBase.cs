using Abp.Web.Mvc.Views;

namespace ABPDemoProject.Web.Views
{
    public abstract class ABPDemoProjectWebViewPageBase : ABPDemoProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPDemoProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPDemoProjectWebViewPageBase()
        {
            LocalizationSourceName = ABPDemoProjectConsts.LocalizationSourceName;
        }
    }
}
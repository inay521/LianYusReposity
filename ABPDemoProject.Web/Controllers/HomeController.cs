using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPDemoProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPDemoProjectControllerBase
    {
        public ActionResult Index()
        {
            Logger.Debug("A sample log message...");
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}
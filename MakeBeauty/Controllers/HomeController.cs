// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.Controllers
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using System.Web.Security;

    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Admin(string something)
        {
            var requestResult = Request.Form["computer-code"];

            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(requestResult, "SHA1");

            if (FormsAuthentication.Authenticate("admin", requestResult))
            {
                FormsAuthentication.SetAuthCookie("admin", true);
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }
    }
}

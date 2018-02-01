using System.Web.Security;
using Microsoft.AspNetCore.Mvc;

namespace Ilaro.Admin.Areas.IlaroAdmin.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost, ValidateAntiForgeryToken]
        public virtual ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/");
        }
    }
}

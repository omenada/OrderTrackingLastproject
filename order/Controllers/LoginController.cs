using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace order.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()

        {
            return View();
        }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Login(user)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            using (DB_Entities db = new DB_Entities())
        //            {
        //                var obj = db.UserProfiles.Where(a => a.u_name.Equals(user.u_name) && a.u_password.Equals(objUser.Password)).FirstOrDefault();
        //                if (obj != null)
        //                {
        //                    Session["UserID"] = obj.u_id.ToString();
        //                    Session["UserName"] = obj.u_name.ToString();
        //                    return RedirectToAction("UserDashBoard");
        //                }
        //            }
        //        }
        //        return View(objUser);
        //    }

        //}

        //internal class DB_Entities
        //{
        //    internal IEnumerable<user> UserProfiles;
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModel;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        //get
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
                Test = "This is my test value set in my controller"
            });
        }

        //post

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            form.Test = "This is a value set in my post action";
            return View(form);
        }
    }
}
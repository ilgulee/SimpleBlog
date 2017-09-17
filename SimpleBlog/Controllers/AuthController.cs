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
            return View();
        }

        //post
   
    [HttpPost]
    public ActionResult Login(AuthLogin form)
        {
            return Content("HI "+form.Username);
        }
    }
}
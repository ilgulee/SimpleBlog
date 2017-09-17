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
                
            });
        }

        //post

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            if (form.Username != "rainbow dash")
            {
                ModelState.AddModelError("Username","Username or Password isn't 20% cooler");
                return View(form);
            }
            return Content("The form is valid");
        }
    }
}
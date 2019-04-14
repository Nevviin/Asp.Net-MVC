using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcFormsAuthentication.Models;

namespace MvcFormsAuthentication.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult LogOn()
        {

            return View();
        }


        [HttpPost]
        public ActionResult LogOn( LoginModel loginModel, string ReturnUrl = ""  )
        {


            if (loginModel.UserName == "username" && loginModel.Password == "pwd")
            {
                FormsAuthentication.SetAuthCookie(loginModel.UserName, loginModel.RememberMe);
                if(Url.IsLocalUrl(ReturnUrl))
                {

                    return Redirect(ReturnUrl);
                }
                else
                {

                    
                }

            }



            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


    }
}

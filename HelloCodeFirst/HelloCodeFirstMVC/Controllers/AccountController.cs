using HelloCodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelloCodeFirstMVC.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(FormCollection formCollection, String ReturnUrl)
        {
            String account = formCollection["account"];
            if (account == null)
            {
                return View();
            }
            using (var db = new HelloContext())
            {
                //db.Employees.Add(new Employee()
                //{
                //    Email = "gene.chen@hg-asia.com",
                //    Address = "test"
                //});
                //db.SaveChanges();
                Employee emp = db.Employees.Where(o => o.Email.Contains(account.Trim())).FirstOrDefault();
                if (emp != null)
                {
                    ViewData["result"] = "success";
                    Session.RemoveAll();

                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                      emp.Email,//你想要存放在 User.Identy.Name 的值，通常是使用者帳號
                      DateTime.Now,
                      DateTime.Now.AddMinutes(30),
                      false,//將管理者登入的 Cookie 設定成 Session Cookie
                      emp.Address,//userdata看你想存放啥
                      FormsAuthentication.FormsCookiePath);

                    string encTicket = FormsAuthentication.Encrypt(ticket);

                    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                    if (String.IsNullOrEmpty(ReturnUrl)) 
                    {
                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        return Redirect(ReturnUrl);
                    }
                   

                }


            }

            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}

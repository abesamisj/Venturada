using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Venturada.UI.Dataservice;
using Venturada.UI.Models;
using Venturada.UI.ViewModels;

namespace Venturada.UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            return View();
        }


        private ActionResult RedirectToLocal(string returnUrl)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Login
        public ActionResult Login(string returnUrl)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UserDataService userDataService = new UserDataService();

            DataSet ds = new DataSet();

            ds = userDataService.GetUsersByUserName(model.UserName);
            if (ds != null)
            {
                if (ds.Tables[0] != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (model.Password == Convert.ToString(ds.Tables[0].Rows[0]["UserPassword"])
                            && model.UserName == Convert.ToString(ds.Tables[0].Rows[0]["UserName"]))
                        {
                            HttpCookie FormsCookie = Cookies.CreateAuthenticationCookie(model.UserName, model.LastName);
                            Response.Cookies.Add(FormsCookie);
                            Session.Remove("UserName");
                            Session.Remove("FirstName");
                            Session.Remove("LastName");
                            Session["UserName"] = model.UserName;
                            Session["FirstName"] = model.FirstName;
                            Session["LastName"] = model.LastName;
                            return RedirectToLocal(returnUrl);
                        }
                        else
                        {
                            ModelState.AddModelError("", "Invalid login attempt.");
                            return View(model);

                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View(model);
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);

                }


            }
            else
            {
                ModelState.AddModelError("", "User does not exists!");
                return View(model);
            }
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        public ActionResult Logoff()
        {
            CommonDataService cds = new CommonDataService();

            CommonModel cm = new CommonModel();

            cm = cds.GenerateCommonModel();
            Session["FaceBook"] = cm.FaceBook;
            Session["Twitter"] = cm.Twitter;
            Session["Youtube"] = cm.Youtube;
            Session["Instagram"] = cm.Instagram;
            Session["PhoneNumber"] = cm.PhoneNumber;
            Session["Email"] = cm.Email;
            Session["ShoppingHours"] = cm.ShoppingHours;
            Session.Remove("UserName");
            Session.Remove("FirstName");
            Session.Remove("LastName");
            return RedirectToAction("Index", "Home");
        }
    }
}
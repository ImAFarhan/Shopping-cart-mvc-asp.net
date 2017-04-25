﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        DbHandlerDataContext db = new DbHandlerDataContext();

        [HttpGet]
        [ActionName("SignUp")]
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }
        [HttpPost]
        [ActionName("SignUp")]
        public ActionResult SignUp_post(Customer user)
        {
            if (ModelState.IsValid == true)
            {
                Customer u = db.Customers.Where(x => x.UEmail == user.UEmail).FirstOrDefault();
                if (u != null)
                {
                    ModelState.AddModelError("", "Email already exists");

                    return View();

                }
                else
                {
                    db.Customers.InsertOnSubmit(user);
                    db.SubmitChanges();
                    return RedirectToAction("MainPage", "Home");
                }
            }

            else
                return View();


        }

        public ActionResult DisplayDetails(int? id)
        {

            return View();
        }

        public ActionResult MainPage()
        {
            return View();
        }


        public void DisplayDetailsVendor()
        {
        }
        [ActionName("Login")]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public ActionResult Login_post(FormCollection form)
        {
            string upass = Request.Form["password"].ToString();
            string email = Request.Form["username"].ToString();
          
            Vendor v = db.Vendors.Where(x => x.VEmail == email && x.VPassword == upass).FirstOrDefault();
            if (v != null)
            {
                TempData["VName"] = v.VName;
                return RedirectToAction("Index", "Products");
            }
            else
            {
                ViewBag.errorMsg = "RECORD NOT FOUND";

                return View();
            }
            
        }

        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }

        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}
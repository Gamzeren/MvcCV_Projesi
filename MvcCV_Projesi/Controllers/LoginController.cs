﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcCV_Projesi.Models.Entity;

namespace MvcCV_Projesi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            DbCVEntities db=new DbCVEntities();
            var bilgi=db.TblAdmin.FirstOrDefault(x=>x.KullaniciAdi==p.KullaniciAdi && x.Sifre==p.Sifre);
            if (bilgi !=null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAdi, false);
                Session["KullaniciAdi"]=bilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index","Hakkımda");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
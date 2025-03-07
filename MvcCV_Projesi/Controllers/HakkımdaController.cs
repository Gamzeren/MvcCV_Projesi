﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV_Projesi.Models.Entity;
using MvcCV_Projesi.Repositories;

namespace MvcCV_Projesi.Controllers
{
    public class HakkımdaController : Controller
    {
        // GET: Hakkımda
        DbCVEntities db=new DbCVEntities();
        GenericRepository<TblHakkımda> repo = new GenericRepository<TblHakkımda>();

        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkımda p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Mail = p.Mail;
            t.Telefon = p.Telefon;
            t.Aciklama = p.Aciklama;
            t.Resim=p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
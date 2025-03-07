using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV_Projesi.Models.Entity;

namespace MvcCV_Projesi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCVEntities db=new DbCVEntities();
        public ActionResult Index()
        {
            var degerler=db.TblHakkımda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalMedya = db.TblSosyalMedya.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalMedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler=db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var Yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(Yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var Hobiler = db.TblHobilerim.ToList();
            return PartialView(Hobiler);
        }
        public PartialViewResult Sertifikalarım()
        {
            var Sertifikalar = db.TblSertifikalarim.ToList();
            return PartialView(Sertifikalar);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(TblIletisim t)
        {
            t.Tarih=DateTime.Parse( DateTime.Now.ToShortDateString());
            db.TblIletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}
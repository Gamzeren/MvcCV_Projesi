using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV_Projesi.Models.Entity;
using MvcCV_Projesi.Repositories;

namespace MvcCV_Projesi.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<TblHobilerim> repo=new GenericRepository<TblHobilerim>();

        [HttpGet]
        public ActionResult Index()
        {
            var hobiler=repo.List();
            return View(hobiler);
        }
        [HttpPost]
        public ActionResult Index(TblHobilerim p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Aciklama1=p.Aciklama1;
            t.Aciklama2 =p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
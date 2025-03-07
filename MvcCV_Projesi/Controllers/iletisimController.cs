using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV_Projesi.Models.Entity;
using MvcCV_Projesi.Repositories;

namespace MvcCV_Projesi.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<TblIletisim> repo=new GenericRepository<TblIletisim>();
        public ActionResult Index()
        {
            var mesajlar=repo.List();
            return View(mesajlar);
        }
    }
}
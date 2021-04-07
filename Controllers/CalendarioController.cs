using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using Calendario;


namespace Calendario.Controllers
{
    public class CalendarioController : Controller
    {

        public portafolioEntities db = new portafolioEntities();
        
        // GET: Calendario
        public ActionResult Index()
        {
            return View(db.Eventos.ToList());
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using Calendario;
using Calendario.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Calendario.Controllers
{
    public class CalendarioController : Controller
    {

        public portafolioEntities db = new portafolioEntities();
        
        // GET: Calendario
        public ActionResult Index()
        {
            
            var Eventos = db.Eventos.Select(q => new EventosModel
            {
                id = q.Id,
                title = q.Titulo,
                start = q.Inicio,
                end = q.Fin,
                description = q.Descripcion,
                color = q.Color

            });

            var ListaEventos = Eventos.AsQueryable();
            return View(ListaEventos);

        }

        public JsonResult GetEventos()
        {
            var Eventos = db.Eventos.Select(q => new EventosModel
            {
                id = q.Id,
                title = q.Titulo,
                start = q.Inicio,
                end = q.Fin,
                description = q.Descripcion,
                color = q.Color
            }); ; ;

            var json = Eventos.ToArray();
            string jsonst = Json(json).ToString();
            //return Json(jsonst, JsonRequestBehavior.AllowGet); ;
            //return Json(new {Data = Eventos.ToArray() }, JsonRequestBehavior.AllowGet);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Inicio()
        {


            return View();

        }






    }
}
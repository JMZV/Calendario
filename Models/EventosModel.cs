using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendario.Models
{
    public class EventosModel
    {
          
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
      
    }
}
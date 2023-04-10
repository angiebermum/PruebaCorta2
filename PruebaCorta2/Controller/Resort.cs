using PruebaCorta2.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using m = PruebaCorta2.Model;
using System.Web.Mvc;
using PruebaCorta2.Model;
//using PruebaCorta2.Database;

namespace PruebaCorta2.Controllers
{
    public class ResortsController : Controller
    {

        // Método que devuelve una vista de la página principal con una lista de resorts cargada desde la base de datos
        public ActionResult Principal()
        {

            // Se crea un nuevo contexto de base de datos ResortsContext
            using (var db = new ResortsContext())
            {
                // Se obtiene una lista de resorts desde la base de datos
                List<Resort> resorts = db.Resorts.ToList();

                // Se devuelve una vista llamada "Principal" con la lista de resorts como modelo de datos
                return View(resorts); 
            }
        }

        // Método que devuelve una lista de resorts cargada desde la base de datos
        public List<m.Resort> GetResorts()
        {

            // Se crea un nuevo contexto de base de datos ResortsContext
            using (var db = new ResortsContext())
            {

                // Se obtiene una lista de resorts desde la base de datos y se devuelve como resultado del método
                return db.Resorts.ToList();
            }
        }

    }
}






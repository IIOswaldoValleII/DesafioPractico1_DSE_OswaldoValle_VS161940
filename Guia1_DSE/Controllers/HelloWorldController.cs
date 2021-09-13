using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        /*   public string Index()
           {
               return "Esta es mi acción <b> predeterminada </b> ...";
           }*/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /HelloWorld/Welcome/
        /*    public string Welcome()
            {
                return "Este es el método de acción Bienvenido ...";
            }*/

        public ActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            
            ViewBag.NumVeces = numVeces;
            ViewBag.Mensaje = "Hola " + nombre + " " + apellido ;
            return View();

  
        }
      /*  public string Welcome(string nombre, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hola " + nombre + ", ID: " + ID);
        }
    */
    }
}

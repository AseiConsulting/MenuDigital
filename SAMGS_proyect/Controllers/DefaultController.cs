using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SAMGS.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

       [HttpGet]
       public bool Prueba()
        {
            return BussinesLogic.Models.PruebaConexion.pruebaconexion();
        }
    }
}

using BussinesLogic.Models.Areas;
using BussinesLogic.Models.Depto;
using BussinesLogic.Models.Usuarios;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAMGS.Controllers.Utilerias
{
    public class AreasController : Controller
    {
        // GET: Areas
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult LstAreas()
        {
            var Parametros = new object[] { };
            //Mandamos a traer los datos del repositorio que enviará en formato JSON
            var Datos = CatAreas.BSLCatAreas();
            var jsonResult = Json(new { success = true, data = Datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            //MaxJsonLength nos ayuda a obtener o establecer la longitud máxima de contenido JSON que enviará. El valor predeterminado para esto es 2097152 caracteres, que es igual a 4 MB de datos de cadena Unicode. Incluso puede aumentar el tamaño según sea necesario, para eso tendrá una idea más adelante en este artículo.
            jsonResult.MaxJsonLength = int.MaxValue;
            //Regresamos los datos en el formato JSON
            return jsonResult;
        }

        public JsonResult updateAreas(Area lstarea)
        {
            var Parametros = new object[] { };
            //Mandamos a traer los datos del repositorio que enviará en formato JSON
            var Datos = CatAreas.UpdateADDArea(lstarea);
            var jsonResult = Json(new { success = true, data = Datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            //MaxJsonLength nos ayuda a obtener o establecer la longitud máxima de contenido JSON que enviará. El valor predeterminado para esto es 2097152 caracteres, que es igual a 4 MB de datos de cadena Unicode. Incluso puede aumentar el tamaño según sea necesario, para eso tendrá una idea más adelante en este artículo.
            jsonResult.MaxJsonLength = int.MaxValue;
            //Regresamos los datos en el formato JSON
            return jsonResult;
        }



    }
}
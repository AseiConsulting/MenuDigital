using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinesLogic.Models.Usuarios;
using static Modelos.Models.MneuAccsUsrcs;

namespace SAMGS.Controllers
{
    public class UsuariosController : Controller
    {

        // GET: Usuarios
        public ActionResult Index()
        {

            return View();
        }


        [HttpGet]
        public JsonResult LstUsuarios()
        {
            //Mandamos a traer los datos del repositorio que enviará en formato JSON
            var Datos = CatUsuarios.BSLCatUsuarios();
            var jsonResult = Json(new { success = true, data = Datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            //MaxJsonLength nos ayuda a obtener o establecer la longitud máxima de contenido JSON que enviará. El valor predeterminado para esto es 2097152 caracteres, que es igual a 4 MB de datos de cadena Unicode. Incluso puede aumentar el tamaño según sea necesario, para eso tendrá una idea más adelante en este artículo.
            jsonResult.MaxJsonLength = int.MaxValue;
            //Regresamos los datos en el formato JSON
            return jsonResult;
        }
        public JsonResult UpdateAddUser(MenuAccsUsr usuario)
        {
            var Parametros = new object[] {usuario.iUserID, usuario.VCHUSUARIO,usuario.vchidUserCorp,usuario.sUserName,usuario.sPasword,usuario.iPerfilId,usuario.idDepto,usuario.sPreguntaSecreta,usuario.sRespuestaSecreta,usuario.bActivo,usuario.iCaducidad,usuario.iEsEmp,Session["idUsuario"]};
            //Mandamos a traer los datos del repositorio que enviará en formato JSON
            var Datos = CatUsuarios.BSLUpadduSER(usuario);
            var jsonResult = Json(new { success = true, data = Datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            //MaxJsonLength nos ayuda a obtener o establecer la longitud máxima de contenido JSON que enviará. El valor predeterminado para esto es 2097152 caracteres, que es igual a 4 MB de datos de cadena Unicode. Incluso puede aumentar el tamaño según sea necesario, para eso tendrá una idea más adelante en este artículo.
            jsonResult.MaxJsonLength = int.MaxValue;
            //Regresamos los datos en el formato JSON
            return jsonResult;
        }


        public JsonResult listarEmpleados()
        {
            
            //Mandamos a traer los datos del repositorio que enviará en formato JSON
            var Datos = CatUsuarios.BSLEmpleados();
            var jsonResult = Json(new { success = true, data = Datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            //MaxJsonLength nos ayuda a obtener o establecer la longitud máxima de contenido JSON que enviará. El valor predeterminado para esto es 2097152 caracteres, que es igual a 4 MB de datos de cadena Unicode. Incluso puede aumentar el tamaño según sea necesario, para eso tendrá una idea más adelante en este artículo.
            jsonResult.MaxJsonLength = int.MaxValue;
            //Regresamos los datos en el formato JSON
            return jsonResult;
        }

    }
}

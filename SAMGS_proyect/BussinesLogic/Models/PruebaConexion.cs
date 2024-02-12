using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinesLogic.Models
{
    public class PruebaConexion
    {
        public static bool pruebaconexion()
        {
            return DataBase.DataBase.Usuarios.Usuarios.pruebaconct();

        }
    }
}
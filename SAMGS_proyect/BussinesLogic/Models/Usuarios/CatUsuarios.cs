using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataBase.Modelos.Usuarios;
using static Modelos.Models.MneuAccsUsrcs;
using static Modelos.Models.Empleados.EmpleadosList;
using Modelos.Models.Empleados;

namespace BussinesLogic.Models.Usuarios
{
    public class CatUsuarios
    {
        public static List<MenuAccsUsr> BSLCatUsuarios()
        {
            return UsuariosProc.lstUsrSys();
       }
        public static bool BSLUpadduSER(MenuAccsUsr usuario)
        {
            return UsuariosProc.UpdateAddUsuario(usuario);
        }

        public static List<EmpleadosList> BSLEmpleados()
        {
            return UsuariosProc.lstEmpleado();
        }
        public static List<CatDepto_Perfil> lstCatalogo(int value)
        {
            return UsuariosProc.lstPerfiles(value);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DataBase.Modelos.Departamentos;
using DataBase.Modelos.Usuarios;
using Modelos.Models;
using static Modelos.Models.Deptos;
using static Modelos.Models.MneuAccsUsrcs;

namespace BussinesLogic.Models.Depto
{
    public class CatDepto
    {
        public static List<Deptos> BSLCatDepto()
        {
            return DataBase.Modelos.Departamentos.DepartamentosProc.lstDepSys();

        }

        public static bool UpdateADDDepto(Deptos _depto)
        {
            return DataBase.Modelos.Departamentos.DepartamentosProc.UpdateADDDepto(_depto);

        }

      

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DataBase.Modelos.Departamentos;
using DataBase.Modelos.Usuarios;
using Modelos.Models;
using static Modelos.Models.Perfil;
using static Modelos.Models.MneuAccsUsrcs;

namespace BussinesLogic.Models.Perfiles
{
    public class CatPerfiles
    {

        public static List<Perfil>BSLCatPerfiles()
        {
            return DataBase.Modelos.Perfiles.PerfilesProc.lstPerfSys();

        }

        public static bool UpdateADDPerfil(Perfil _lstPerf)
        {
            return DataBase.Modelos.Perfiles.PerfilesProc.UpdateADDPerfil(_lstPerf);

        }


    }
}
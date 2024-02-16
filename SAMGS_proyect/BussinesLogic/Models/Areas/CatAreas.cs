using DataBase.Modelos.Areas;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Modelos.Models.Area;

namespace BussinesLogic.Models.Areas
{
    public class CatAreas
    {
        
        public static List<Area> BSLCatAreas()
        {
            return DataBase.Modelos.Areas.AreasProc.lstAreSys();
        }


        public static bool UpdateADDArea(Area _lstarea)
        {
            return DataBase.Modelos.Areas.AreasProc.UpdateADDArea(_lstarea);

        }
    }
        
    
}
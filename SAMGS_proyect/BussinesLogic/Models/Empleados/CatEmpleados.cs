using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinesLogic.Models.Empleados
{
    public class CatEmpleados
    {

        public static List<Empleado>BSLCatEmpleados()
        {
            return DataBase.Modelos.Empleados.EmpleadosProc.lstEmpSys();

        }

        public static bool UpdateADDDempl(Empleado _empl)
        {
            return DataBase.Modelos.Empleados.EmpleadosProc.UpdateADDEmpl(_empl);

        }


        public static List<Deptos> BSLEmplDepto()
        {
            return DataBase.Modelos.Departamentos.DepartamentosProc.lstdempl();

        }



    }

}
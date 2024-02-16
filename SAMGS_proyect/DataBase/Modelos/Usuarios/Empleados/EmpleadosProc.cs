using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Modelos.Models;
using static Modelos.Models.Empleado;
using static Modelos.Models.MneuAccsUsrcs;
using System.Data;


namespace DataBase.Modelos.Empleados
{
    public class EmpleadosProc
    {

        public static List<Empleado> lstEmpSys()
        {
            List<Empleado> _lstEmpl = new List<Empleado>();

            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("select  ID_CONS ,CTA_USU_LOCAL,NOMBRE,APATERNO,APMATERNO,EDEPTO,EAREA,DIRECCION,TELEFONO,CELULAR,EMAIL,CTA_USU_GLOBAL from tbl_cat_empleados ", cnn);

                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();


                    while (rd.Read())
                    {
                        _lstEmpl.Add(new Empleado()
                        {
                            idcons = Convert.ToInt32(rd["ID_CONS"]),
                            ctaloc = rd["CTA_USU_LOCAL"].ToString(),
                            nombre = rd["NOMBRE"].ToString(),
                            appat = rd["APATERNO"].ToString(),
                            apmat = rd["APMATERNO"].ToString(),
                            edepto = Convert.ToInt32(rd["EDEPTO"]),
                            earea = Convert.ToInt32(rd["EAREA"]),
                            direcc = rd["DIRECCION"].ToString(),
                            tel = rd["TELEFONO"].ToString(),
                            cel = rd["CELULAR"].ToString(),
                            email = rd["EMAIL"].ToString(),
                            ctausglo = rd["CTA_USU_GLOBAL"].ToString(),


                        });


                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstEmpl;
                }
                catch (Exception ex)
                {
                    return _lstEmpl;
                }
                finally
                {

                }
            }
        }



        public static bool UpdateADDEmpl(Empleado lstdempl)
        {
            DataTable oDt = new DataTable();
            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("sp_updadd_Empl", cnn);
                    cmd.Parameters.Add("i_d", lstdempl.idcons);
                    cmd.Parameters.Add("i_Ctaloc", lstdempl.ctaloc);
                    cmd.Parameters.Add("i_nombre", lstdempl.nombre);
                    cmd.Parameters.Add("i_apPate", lstdempl.appat);
                    cmd.Parameters.Add("i_apmater", lstdempl.apmat);
                    cmd.Parameters.Add("i_edepti", lstdempl.edepto);
                    cmd.Parameters.Add("i_earea", lstdempl.earea);
                    cmd.Parameters.Add("i_direccion", lstdempl.direcc);
                    cmd.Parameters.Add("i_telef", lstdempl.tel);
                    cmd.Parameters.Add("i_celul", lstdempl.cel);
                    cmd.Parameters.Add("i_email", lstdempl.email);
                    cmd.Parameters.Add("i_Ctaglob", lstdempl.ctausglo);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {

                }


            }

        }




    }
}
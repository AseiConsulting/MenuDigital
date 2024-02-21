using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Modelos.Models;
using static Modelos.Models.Deptos;
using static Modelos.Models.MneuAccsUsrcs;
using System.Data;
namespace DataBase.Modelos.Departamentos
{
    public class DepartamentosProc
    {
        public static List<Deptos> lstDepSys()
        {
            List<Deptos> _lstDepto = new List<Deptos>();

            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("select  ID_DEPTO,DESCRIPCION from tbl_cat_departamento ", cnn);
                    
                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();


                    while (rd.Read())
                    {
                        _lstDepto.Add(new Deptos()
                        {
                            idDepto = Convert.ToInt32(rd["ID_DEPTO"]),
                            ddescripcion = rd["DESCRIPCION"].ToString(),


                        });


                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstDepto;
                }
                catch (Exception ex)
                {
                    return _lstDepto;
                }
                finally
                {

                }
            }
        }

        public static bool UpdateADDDepto(Deptos lstdepto)
        {
            DataTable oDt = new DataTable();
            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("sp_updadd_Depto", cnn);
                    cmd.Parameters.Add("id_depto", lstdepto.idDepto);
                    cmd.Parameters.Add("d_descrip", lstdepto.ddescripcion);

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


         public static List<Deptos>lstdempl()
         {

            List<Deptos> _lstnomDept = new List<Deptos>();

            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand(" select (id_Depto||'-'||descripcion) as Departamento from tbl_cat_departamento", cnn);
                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        _lstnomDept.Add(new Deptos()
                        {
                            ddesc = rd["Departamento"].ToString()
                            
                        });


                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstnomDept;
                }
                catch (Exception ex)
                {
                    return _lstnomDept;
                }
                finally
                {

                }
            }
         }





    }

}


    






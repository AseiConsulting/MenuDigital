using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Modelos.Models;
using static Modelos.Models.Perfil;
using System.Data;

namespace DataBase.Modelos.Perfiles
{
    public class PerfilesProc
    {

        public static List<Perfil>lstPerfSys()
        {
            List<Perfil> _lstPerf = new List<Perfil>();

            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("select  IPERFILID ,DESCRIPCION from tbl_cat_perfil ", cnn);

                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();


                    while (rd.Read())
                    {
                        _lstPerf.Add(new Perfil()
                        {
                            idPerfil = Convert.ToInt32(rd["IPERFILID"]),
                            pfdescripcion = rd["DESCRIPCION"].ToString(),


                        });


                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstPerf;
                }
                catch (Exception ex)
                {
                    return _lstPerf;
                }
                finally
                {

                }
            }
        }



        public static bool UpdateADDPerfil(Perfil lstPerfil)
        {
            DataTable oDt = new DataTable();
            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("sp_updadd_Perfil", cnn);
                    cmd.Parameters.Add("id_pfil", lstPerfil.idPerfil);
                    cmd.Parameters.Add("pf_descrip", lstPerfil.pfdescripcion);

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
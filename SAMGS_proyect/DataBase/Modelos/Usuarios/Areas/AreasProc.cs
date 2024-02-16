using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Modelos.Models;
using static Modelos.Models.Area;
using System.Data;

namespace DataBase.Modelos.Areas
{
    public class AreasProc
    {
        public static List<Area> lstAreSys()
        {
            List<Area> _lstArea = new List<Area>();

            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("select ID_AREA ,DEPTO,DESCRIPCION from tbl_cat_area ", cnn);
                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();


                    while (rd.Read())
                    {
                         _lstArea.Add(new Area()
                        {
                             idArea = Convert.ToInt32(rd["Id_Area"]),
                             adepto = Convert.ToInt32(rd["DEPTO"]),
                             descripcion = rd["Descripcion"].ToString(),
                             
                         });


                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstArea;
                }
                catch (Exception ex)
                {
                    return _lstArea;
                }
                finally
                {

                }
            }
        }


        public static bool UpdateADDArea(Area lstarea)
        {
            DataTable oDt = new DataTable();
            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("sp_updadd_Area", cnn);
                    cmd.Parameters.Add("idArea", lstarea.idArea);
                    cmd.Parameters.Add("adepto", lstarea.adepto);
                    cmd.Parameters.Add("descripcion", lstarea.descripcion);
                    

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
    

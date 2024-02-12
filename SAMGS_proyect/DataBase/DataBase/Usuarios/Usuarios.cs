using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;



namespace DataBase.DataBase.Usuarios
{
    public class Usuarios
    {
        public static  bool pruebaconct ()
        {
            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    cnn.Open();
                    return true;
                }
                catch 
                { return false; }
            }
             
        }
    }
}
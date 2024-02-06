using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace DataBase.DataBase
{
    public class ConexionDB
    {
        public static String con = ConfigurationManager.AppSettings["connectdatabase"];

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos.Models
{
    public class MneuAccsUsrcs
    {
        public class MenuAccsUsr
        {

            public int iUserID { get; set; }
            public string vchidUserCorp { get; set; }
            public string sUserName { get; set; }
            public string sPasword { get; set; }
            public int iPerfilId { get; set; }
            public int idDepto { get; set; }
            public string sPreguntaSecreta { get; set; }
            public string sRespuestaSecreta { get; set; }
            public int bActivo { get; set; }
            public int iCaducidad { get; set; }
            public int iEsEmp { get; set; }
        }

    }
}
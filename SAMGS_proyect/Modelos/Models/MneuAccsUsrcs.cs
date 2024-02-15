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
            public string VCHUSUARIO { get; set; }
            public string sUserName { get; set; }
            public string sPasword { get; set; }
            public string iPerfilId { get; set; }
            public string idDepto { get; set; }
            public string Email { get; set; }
            public int bActivo { get; set; }
            public int iCaducidad { get; set; }
            public int iEsEmp { get; set; }
            public int iUsuarioAlta { get; set; }
        }

    }
}
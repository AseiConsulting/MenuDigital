using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Modelos.Models;
using static Modelos.Models.MneuAccsUsrcs;
using Modelos.Models.Empleados;
using System.Data;

namespace DataBase.Modelos.Usuarios
{
    public class UsuariosProc
    {
        public static List<MenuAccsUsr> lstUsrSys()
        {
            List<MenuAccsUsr> _lstUsr = new List<MenuAccsUsr>();

            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("select iUserID,nvl(vchidUserCorp,'') as vchidUserCorp ,VCHUSUARIO,sUserName,sPasword,vchPerfilId,vchDepto,vchEmail,bActivo,iCaducidad,NVL(iESEmp,0)as iESEmp from tbl_sistema_Usuarios ", cnn);
                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();


                    while (rd.Read())
                    {
                        _lstUsr.Add(new MenuAccsUsr()
                        {
                            iUserID = Convert.ToInt32(rd["iUserID"]),
                            vchidUserCorp = rd["vchidUserCorp"].ToString(),
                            VCHUSUARIO  = rd["VCHUSUARIO"].ToString(),
                            sUserName = rd["sUserName"].ToString(),
                            sPasword = rd["sPasword"].ToString(),
                            iPerfilId = rd["vchPerfilId"].ToString(),
                            idDepto = rd["vchDepto"].ToString(),
                            Email = rd["vchEmail"].ToString(),
                            bActivo = Convert.ToInt32(rd["bActivo"]),
                            iCaducidad = Convert.ToInt32(rd["iCaducidad"]),
                            iEsEmp = Convert.ToInt32(rd["iEsEmp"])
                        });


                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstUsr;
                }
                catch (Exception ex)
                {
                    return _lstUsr;
                }
                finally
                {

                }
            }
        }

        public static bool UpdateAddUsuario(MenuAccsUsr usuario)
        {
            
            DataTable oDt = new DataTable();
            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                     OracleCommand cmd = new OracleCommand("SP_ALTA_MODUSR", cnn);
                    cmd.Parameters.Add("iUser", usuario.iUserID);
                    cmd.Parameters.Add("idUserCorp", usuario.vchidUserCorp);
                    cmd.Parameters.Add("vchUserName", usuario.sUserName);
                    cmd.Parameters.Add("vchPasword", usuario.sPasword);
                    cmd.Parameters.Add("vchPerfilId", usuario.iPerfilId);
                    cmd.Parameters.Add("vchDepto", usuario.idDepto);
                    cmd.Parameters.Add("email", usuario.Email);
                    cmd.Parameters.Add("intActivo", usuario.bActivo);
                    cmd.Parameters.Add("intCaduca", usuario.iCaducidad);
                    cmd.Parameters.Add("intUalta", usuario.iUsuarioAlta);
                    cmd.Parameters.Add("intEsEmpleado", usuario.iEsEmp);
                    cmd.Parameters.Add("nomUsuario", usuario.VCHUSUARIO);
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

        public static List<EmpleadosList> lstEmpleado()
        {

            List <EmpleadosList> _lstEmp = new List<EmpleadosList>();

            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand("select idEmpleado,(Nombre||' '||APaterno||' '||ApMaterno) as Nombre from tbl_Cat_empleados", cnn);
                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        _lstEmp.Add(new EmpleadosList()
                        {
                            idEmpleado = rd["idEmpleado"].ToString(),
                            nombreEmp = rd["Nombre"].ToString(),
                        });


                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstEmp;
                }
                catch (Exception ex)
                {
                    return _lstEmp;
                }
                finally
                {

                }
            }
        }

        public static List<CatDepto_Perfil> lstPerfiles(int value)
        {
            List<CatDepto_Perfil> _lstCatalogo = new List<CatDepto_Perfil>();
            string sQLquery = "";
            if (value==1) {
                sQLquery = "select (iPerfilId||'-'||Descripcion) AS DescripcionCat from tbl_Cat_PERFIL";
            }
            else { 
                sQLquery = "SELECT (idDepto||'-'||Descripcion) as DescripcionCat FROM tbl_Cat_Departamento"; 
            }
            
            OracleConnection cnn = new OracleConnection(DataBase.ConexionDB.con);
            using (cnn)
            {
                try
                {
                    OracleCommand cmd = new OracleCommand(sQLquery, cnn);
                    cnn.Open();
                    OracleDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        _lstCatalogo.Add(new CatDepto_Perfil()
                        {
                            descripcion = rd["DescripcionCat"].ToString()
                        });
                    }
                    // always call Close when done reading.
                    rd.Close();
                    return _lstCatalogo;
                }
                catch (Exception ex)
                {
                    return _lstCatalogo;
                }
                finally
                {

                }
            }
        }
    }
}
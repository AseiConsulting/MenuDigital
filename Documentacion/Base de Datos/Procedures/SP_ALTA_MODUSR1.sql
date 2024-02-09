/*
AUTHO: JABO
DATE: 09/02/2024
DESCRIPCION: ALTA Y MODIFICACION DE USUARIOS DEL SISTEMA
EXECUTE SP_ALTA_MODUSR(IUSER IN NUMBER, IDUSERCORP IN VARCHAR2, VCHUSERNAME IN VARCHAR2, VCHPASWORD IN VARCHAR2, INTPERFILID IN NUMBER, INTDDEPTO IN NUMBER, VCHPREGUNTASEC IN VARCHAR2, VCHRESPUESTASEC IN VARCHAR2, INTACTIVO IN NUMBER, INTCADUCA IN NUMBER, INTUALTA IN NUMBER)
*/


CREATE OR REPLACE PROCEDURE SP_ALTA_MODUSR( 
iUser number
,idUserCorp varchar2
,vchUserName varchar2
,vchPasword varchar2
,intPerfilId number
,intdDepto number
,vchPreguntaSec varchar2
,vchRespuestaSec varchar2
,intActivo number
,intCaduca number
,intUalta number 
)
AS

 iUsr NUMBER;
 DatFechaCambio timestamp;
 IntDias NUMBER;

        
BEGIN
    SELECT intDias INTO IntDias from TBL_PARAM_SISTEMA;
    DatFechaCambio := SYSDATE +  IntDias;
    IF iUser=0 THEN
        SELECT NVL(MAX(iUserID),0) INTO iUsr from tbl_sistema_Usuarios;
        INSERT INTO tbl_sistema_Usuarios(iUserID,vchidUserCorp,sUserName,sPasword,iPerfilId,idDepto,sPreguntaSecreta,sRespuestaSecreta,bActivo,FCambioPass,iCaducidad,UAlta) 
        values (iUser, idUserCorp,   vchUserName,vchPasword,intPerfilId,intdDepto,vchPreguntaSec,vchRespuestaSec,intActivo,DatFechaCambio,intCaduca,intUalta);
    ELSE
        UPDATE  tbl_sistema_Usuarios
          SET   
            vchidUserCorp       = idUserCorp,
            sPasword            = vchPasword,
            iPerfilId           = intPerfilId,
            idDepto             = intdDepto,
            sPreguntaSecreta    = vchPreguntaSec,   
            sRespuestaSecreta   = vchRespuestaSec,
            bActivo             = intActivo,
            FCambioPass         = DatFechaCambio,
            iCaducidad          = intCaduca,
            UAlta               = intUalta,  
            Fmodificacion       = SYSDATE
       WHERE iUserid = iUser;

    END IF;
END;


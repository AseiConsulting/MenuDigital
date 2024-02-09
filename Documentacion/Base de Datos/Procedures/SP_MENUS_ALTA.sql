/*
AUTHOR;jabo
DATE:08/02/2024
DESCRIPCION:STORED PARA ALTA DE MNUS

EXECUTE SP_MENUS_ALTA(INTMENUID IN NUMBER, VCHDESCRIPCION IN VARCHAR2, INTPADREID IN NUMBER, INTPOSICION IN NUMBER, VCHURL IN VARCHAR2, IUSERIDCRE IN NUMBER, IUSUARIOIDMOD IN NUMBER)

*/

   
CREATE OR REPLACE PROCEDURE SP_MENUS_ALTA (
 intMenuId  NUMBER
,vchDescripcion   varchar2
,intPadreId   NUMBER
,intPosicion  NUMBER
,vchUrl  VARCHAR2
,IUseriDCre  Number
,IUsuarioIdMod  number
)
as
  idMen NUMBER;
BEGIN
    if intMenuId = 0 THEN  
        select NVL(MAX(iMenuId),0)+1  into idMen from tbl_sistema_Menus;
       
        INSERT INTO tbl_sistema_Menus(iMenuId,sDescripcion,iPadreId,iPosicion,sUrl,IUseriDCreacion)
        VALUES(idMen,vchDescripcion,intPadreId,intPosicion,vchUrl,IUseriDCre);
        
        insert into tbl_sistema_AsignaPerfilesMenu(iPerfilId,iMenuId)
        Select DISTINCT iPerfilId,idMen from tbl_sistema_AsignaPerfilesMenu;
    ELSE
        UPDATE tbl_sistema_Menus
        SET sDescripcion = vchDescripcion,
            iPadreId = intPadreId,
            iPosicion = intPosicion,
            sUrl = vchUrl,
            IUsuarioIdModificaion= IUsuarioIdMod,
            DfECHAmOD = SYSDATE
        WHERE iMenuId = intMenuId ;
    END IF;
COMMIT;
    
END;


    
    
  
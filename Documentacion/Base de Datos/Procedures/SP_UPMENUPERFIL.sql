/*
AUTHOR: JABO
DATE:09/02/2024
DESCRIPCION actualiza datos de acceso
EXCECUTE SP_MENULIST(IpERFIL)

*/

CREATE OR REPLACE PROCEDURE SP_UPMENUPERFIL(
iPerfil number, 
iMenu number,
iPerAcc number,
iPerMod number,
iPerDel number  
)
as
BEGIN
 Update tbl_sistema_AsignaPerfilesMenu
 set 
    bPermiteAcceso = iPerAcc ,
    bPermiteMod = iPerMod,
    bPermiteDel = iPerDel
  where iPerfilid = iPerfil and
        iMenuId = iMenu;
END;


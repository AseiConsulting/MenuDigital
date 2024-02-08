
CREATE TABLE tbl_sistema_AsignaPerfilesMenu(
iPerfilId Number(3) NOT NULL , 
iMenuId Number (3)NOT NULL ,
bPermiteAcceso Number(1) NOT NULL,
bPermiteMod Number(1) NOT NULL,
bPermiteDel Number(1) NOT NULL,
FAlta TIMESTAMP DEFAULT SYSDATE NOT NULL,
UAlta number(3) NOT NULL,
FInactivo TIMESTAMP NULL
);




COMMIT;

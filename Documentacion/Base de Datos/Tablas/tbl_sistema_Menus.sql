
CREATE TABLE tbl_sistema_Menus(
iMenuId numeric(4) not NULL
,sDescripcion varchar2(100)
,iPadreId NUMBER(4)
,iPosicion NUMBER(2)
,sUrl VARCHAR2(100)
,dFechaCreacion timestamp DEFAULT(SYSDATE) NOT NULL
,IUseriDCreacion NUMBER(3)
,dFechaMod DATE NULL
,IUsuarioIdModificaion number(3) 
,FAlta timestamp DEFAULT SYSDATE NOT NULL
,FInactivo NUMBER (1)
)


CREATE TABLE tbl_sistema_Usuarios(
iUserID number(3)
,vchidUserCorp varchar2(30)
,sUserName varchar2(10)
,sPasword varchar2(10)
,iPerfilId number(2)
,idDepto number(2)
,sPreguntaSecreta varchar2(100)
,sRespuestaSecreta varchar2(100)
,bActivo number(1)
,FCambioPass timestamp 
,iCaducidad number(1) 
,FAlta timestamp default sysdate not null
,UAlta number(3)
,BInactivo number(1)
,Fmodificacion timestamp
,Fbaja timestamp
);


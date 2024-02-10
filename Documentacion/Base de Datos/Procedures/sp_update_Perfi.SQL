---Creacion de Procedure para la actualizacion del catalogo de PERFIL  J.A.V.R----


CREATE OR REPLACE PROCEDURE sp_update_Perfil(
	   i_dperfil IN NUMBER,
	   i_descripf IN VARCHAR2)
IS
BEGIN

  UPDATE TBL_CAT_PERFIL
  SET DESCRIPCION = i_descripf 
  where IPERFILID = i_dperfil;
  
  COMMIT;

END;
/

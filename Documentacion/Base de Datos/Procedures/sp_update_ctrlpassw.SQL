---Creacion de Procedure para la actualizacion del catalogo de HISTÓRICO PASSWORD  J.A.V.R----


CREATE OR REPLACE PROCEDURE sp_update_ctrlpassw(
	   i_id IN NUMBER,
	   i_usid IN VARCHAR2,
       i_passw IN VARCHAR2,
       i_fechalt IN DATE)
IS
BEGIN

  UPDATE TBL_CONTROL_PASSWORD
  SET USER_ID = i_usid,
      PASSWORD_ACTUAL = i_passw,
      FALTA = i_fechalt
      
  where ID = i_id;
  
  COMMIT;

END;
/
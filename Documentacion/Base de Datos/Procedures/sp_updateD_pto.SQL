---Creacion de Procedure para la actualizacion del catalogo de Departamento  J.A.V.R----


CREATE OR REPLACE PROCEDURE sp_updateD_pto(
	   i_ddepto IN NUMBER,
	   i_descrip IN VARCHAR2)
IS
BEGIN

  UPDATE TBL_CAT_DEPARTAMENTO
  SET DESCRIPCION = i_descrip 
  where IDDEPTO = i_ddepto;
  
  COMMIT;

END;
/


---Creacion de Procedure para la actualizacion del catalogo de EMPLEADOS  J.A.V.R----


CREATE OR REPLACE PROCEDURE sp_update_Empl(
	   i_dempl IN VARCHAR2,
	   i_nombre IN VARCHAR2,
       i_apPate IN VARCHAR2,
       i_apmater IN VARCHAR2,
       i_edepti NUMBER,
       i_earea IN VARCHAR2,
       i_direccion IN VARCHAR2,
       i_telef IN VARCHAR2,
       i_celul IN VARCHAR2,
       i_email IN VARCHAR2,
       i_fecalta IN DATE,
       i_Ctaloc IN VARCHAR2,
       i_Ctaglob IN VARCHAR2)
IS
BEGIN

  UPDATE TBL_CAT_EMPLEADOS
  SET NOMBRE = i_nombre,
      APATERNO = i_apPate,
      APMATERNO = i_apPate,
      EDEPTO = i_edepti,
      EAREA = i_earea,
      DIRECCION = i_direccion,
      TELEFONO = i_telef,
      CELULAR = i_celul,
      EMAIL = i_email,
      FALTAE = i_fecalta,
      CTA_USU_LOCAL = i_Ctaloc,
      CTA_USU_GLOBAL =i_Ctaglob
      
  where IDEMPLEADO = i_dempl;
  
  COMMIT;

END;
/
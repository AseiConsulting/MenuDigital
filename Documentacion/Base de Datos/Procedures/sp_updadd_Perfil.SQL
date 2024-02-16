--Procedimiento para Insertar o Actualizar datos de la tabla Perfiles  J.A.V.R----

create or replace PROCEDURE sp_updadd_Perfil(
	   id_pfil  IN  NUMBER,
       pf_descrip IN VARCHAR2)
AS
 v_final_grade NUMBER;
BEGIN
    IF id_pfil = 0 THEN
        insert INTO TBL_CAT_PERFIL(DESCRIPCION)
        values(pf_descrip);
        commit;
    ELSE
      UPDATE TBL_CAT_PERFIL
      SET IPERFILID = id_pfil,
          DESCRIPCION = pf_descrip
         
      where IPERFILID = id_pfil;
      COMMIT;
    END IF;
EXCEPTION
      WHEN NO_DATA_FOUND THEN
        v_final_grade := NULL;
END;
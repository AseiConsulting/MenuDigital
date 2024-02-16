--Procedimiento para Insertar o Actualizar datos de la tabla Deptos  J.A.V.R----

create or replace PROCEDURE sp_updadd_Depto(
	   id_depto  IN  NUMBER,
       d_descrip IN VARCHAR2)
AS
 v_final_grade NUMBER;
BEGIN
    IF id_depto = 0 THEN
        insert INTO tbl_cat_departamento(DESCRIPCION)
        values(d_descrip);
        commit;
    ELSE
      UPDATE tbl_cat_departamento
      SET ID_DEPTO = id_depto,
          DESCRIPCION = d_descrip
         
      where ID_DEPTO = id_depto;
      COMMIT;
    END IF;
EXCEPTION
      WHEN NO_DATA_FOUND THEN
        v_final_grade := NULL;
END;
--Procedimiento para Insertar o Actualizar datos de la tabla Areas  J.A.V.R----


create or replace PROCEDURE sp_updadd_Area(
	   id_area  IN  NUMBER,
       a_depto IN NUMBER,
       a_descrip IN VARCHAR2)
AS
 v_final_grade NUMBER;
BEGIN
    IF id_area = 0 THEN
        insert INTO tbl_cat_area(DEPTO,DESCRIPCION)
        values(a_depto,a_descrip);
        commit;
    ELSE
      UPDATE tbl_cat_area
      SET ID_AREA = id_area,
          DEPTO = a_depto,
          DESCRIPCION = a_descrip
         
      where ID_AREA = id_area;
      COMMIT;
    END IF;
EXCEPTION
      WHEN NO_DATA_FOUND THEN
        v_final_grade := NULL;
END;
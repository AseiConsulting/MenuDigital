create or replace PROCEDURE sp_updadd_Depto(
	   iddepto  NUMBER,
       d_descrip VARCHAR2)
AS
 v_final_grade NUMBER;
 idepto NUMBER;
BEGIN
    IF iddepto = 0 THEN
            select NVL(MAX(id_depto),0)+1  into idepto from tbl_cat_departamento;
            insert INTO tbl_cat_departamento(id_depto,DESCRIPCION)
            values(idepto,d_descrip);
        commit; 
    ELSE    
      UPDATE tbl_cat_departamento
      SET DESCRIPCION = d_descrip
      where ID_DEPTO = iddepto;
      COMMIT;

    END IF;

EXCEPTION
      WHEN NO_DATA_FOUND THEN
        v_final_grade := NULL;

END;
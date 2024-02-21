create or replace PROCEDURE sp_updadd_Empl(
	   i_d  IN  NUMBER,
       i_Ctaloc IN VARCHAR2,
	   i_nombre IN VARCHAR2,
       i_apPate IN VARCHAR2,
       i_apmater IN VARCHAR2,
       i_edepti IN VARCHAR2,
       i_direccion IN VARCHAR2,
       i_telef IN VARCHAR2,
       i_celul IN VARCHAR2,
       i_email IN VARCHAR2,
       i_Ctaglob IN VARCHAR2)
AS
 v_final_grade NUMBER;
 v_searchDepto number;
 idemple NUMBER;
BEGIN
 select ID_DEPTO into  v_searchDepto from TBL_CAT_DEPARTAMENTO WHERE DESCRIPCION=i_edepti;

    IF i_d=0 THEN
        select NVL(MAX(ID_CONS),0)+1  into idemple from TBL_CAT_EMPLEADOS;
        insert INTO TBL_CAT_EMPLEADOS(ID_CONS,CTA_USU_LOCAL,NOMBRE,APATERNO,APMATERNO,EDEPTO,DIRECCION,TELEFONO,CELULAR,EMAIL,CTA_USU_GLOBAL)
        values(idemple,i_Ctaloc,i_nombre,i_apPate,i_apmater,v_searchDepto,i_direccion,i_telef,i_celul,i_email,i_Ctaglob);
        commit;
    ELSE
      UPDATE TBL_CAT_EMPLEADOS
      SET CTA_USU_LOCAL =i_Ctaloc,
          NOMBRE = i_nombre,
          APATERNO = i_apPate,
          APMATERNO = i_apPate,
          EDEPTO = v_searchDepto,
          DIRECCION = i_direccion,
          TELEFONO = i_telef,
          CELULAR = i_celul,
          EMAIL = i_email,
          CTA_USU_GLOBAL =i_Ctaglob         
      where ID_CONS = i_d;
      COMMIT;
    END IF;
EXCEPTION
      WHEN NO_DATA_FOUND THEN
        v_final_grade := NULL;
END;
create or replace PROCEDURE sp_updadd_Perfil(
	   id_pfil  NUMBER,
       pf_descrip VARCHAR2)
AS
 v_final_grade NUMBER;
 idepfl NUMBER;
BEGIN
    IF id_pfil = 0 THEN
            select NVL(MAX(iperfilid),0)+1  into idepfl from tbl_cat_perfil;
            insert INTO tbl_cat_perfil(iperfilid,descripcionpf)
            values(idepfl,pf_descrip);
        commit; 
    ELSE    
      UPDATE tbl_cat_perfil
      SET descripcionpf = pf_descrip
      where iperfilid = id_pfil;
      COMMIT;

    END IF;

EXCEPTION
      WHEN NO_DATA_FOUND THEN
        v_final_grade := NULL;

END;
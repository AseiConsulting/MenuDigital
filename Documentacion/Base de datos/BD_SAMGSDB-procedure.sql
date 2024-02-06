--procedure para insertar datos del DEPTO--

CREATE OR REPLACE PROCEDURE SP_DEPTO_INSERT( ID_DEPTO IN VARCHAR2,DESCRIPCION IN VARCHAR2, F_ALTA IN DATE)
IS
BEGIN
insert into "TBL_CAT_DEPARTAMENTO"("IDDEPTO","DESCRIPCION","FALTA") values (id_depto, descripcion,f_alta);
END SP_DEPTO_INSERT;

DESCRIBE TBL_CAT_DEPARTAMENTO;

EXECUTE SP_DEPTO_INSERT('200','teso','07-022024')

insert into TBL_CAT_DEPARTAMENTO values('100','RH','06-022024')

-----------------------------------------------------------------------------------------------
--procedure para insertar datos del catalogo Empeado--


DESCRIBE TBL_CAT_EMPLEADOS

CREATE OR REPLACE PROCEDURE SP_EMPL_INSERT( ID_EMPL IN VARCHAR2,NOMBRE IN VARCHAR2,A_PATERNO IN VARCHAR2,
                                            A_MATERNO IN VARCHAR2,E_DEPTO IN VARCHAR2,E_AREA IN VARCHAR2, 
                                            DIRE IN VARCHAR2,TEL IN VARCHAR2,CEL IN VARCHAR2,
                                            E_MAIL IN VARCHAR2)
IS
BEGIN
insert into TBL_CAT_EMPLEADOS(IDEMPLEADO,NOMBRE,APATERNO,APMATERNO,EDEPTO,EAREA,DIRECCION,TELEFONO,CELULAR,EMAIL)
values (ID_EMPL, NOMBRE,A_PATERNO,A_MATERNO,E_DEPTO,E_AREA,DIRE,TEL,CEL,E_MAIL);
END;

EXECUTE SP_EMPL_INSERT('SAM01','JOSE ANTONIO','VASQUEZ','REYNA','200','DIRECCION DE TESORERIA','TOLUCA','5529806724','5581701346','josea.vasquezrey.javr@gmail.com');

--------------------------------------------------------------------------------------------------------

--procedure para insertar datos del catalogo Perfiles--

describe TBL_CAT_PERFILES;

CREATE OR REPLACE PROCEDURE SP_PERFIL_INSERT( ID_PERFIL IN VARCHAR2,DESCRIPCION IN VARCHAR2)
IS
BEGIN
insert into TBL_CAT_PERFILES(IDPERFIL,DESCRIPCION) values (ID_PERFIL, DESCRIPCION);
END;

EXECUTE SP_PERFIL_INSERT ('10','ADMINISTRADOR');

---------------------------------------------------------------


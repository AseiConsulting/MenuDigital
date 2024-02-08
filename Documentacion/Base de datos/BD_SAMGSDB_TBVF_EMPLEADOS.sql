 --Tabla Empleado--
 
CREATE TABLE tbl_Cat_empleados
(	    idEmpleado VARCHAR2(10 BYTE) NOT NULL ENABLE, 
        Nombre VARCHAR2(100),
	    APaterno VARCHAR2(100),
        ApMaterno VARCHAR2(100),
        EDepto NUMBER(10),
        EArea VARCHAR2(200),
        Direccion VARCHAR2(200),
        Telefono  VARCHAR2(14),
        Celular   VARCHAR2(16),
        Email     VARCHAR2(100),
        FaltaE  DATE DEFAULT SYSDATE,
        CTA_USU_LOCAL VARCHAR2(10),
        CTA_USU_GLOBAL VARCHAR2(10),
        CONSTRAINT tbl_Cat_empleados_PK PRIMARY KEY (idEmpleado),
        CONSTRAINT fk_EDepto FOREIGN KEY (EDepto) REFERENCES TBL_CAT_DEPARTAMENTO(IDDEPTO));
 
 
---PROCEDIMIENTO ALMACENADO DE LA TABLA EMPLEADOS---

create or replace PROCEDURE SP_EMPL_INSERT( ID_EMPL IN VARCHAR2,NOMBRE IN VARCHAR2,A_PATERNO IN VARCHAR2,
                                            A_MATERNO IN VARCHAR2,E_DEPTO IN NUMBER,E_AREA IN VARCHAR2, 
                                            DIRE IN VARCHAR2,TEL IN VARCHAR2,CEL IN VARCHAR2,
                                            E_MAIL IN VARCHAR2)
IS
BEGIN
insert into TBL_CAT_EMPLEADOS(IDEMPLEADO,NOMBRE,APATERNO,APMATERNO,EDEPTO,EAREA,DIRECCION,TELEFONO,CELULAR,EMAIL)
values (ID_EMPL, NOMBRE,A_PATERNO,A_MATERNO,E_DEPTO,E_AREA,DIRE,TEL,CEL,E_MAIL);
END;


    --Llamar el procedimiento insert de Empleados---
EXECUTE SP_EMPL_INSERT('SAM01','JOSE ANTONIO','VASQUEZ','REYNA','1','DIRECCION DE RECURSOS HUMANOS','TOLUCA MEXICO','5529806724','5581701346','josea.vasquezrey.javr@gmail.com');  
    
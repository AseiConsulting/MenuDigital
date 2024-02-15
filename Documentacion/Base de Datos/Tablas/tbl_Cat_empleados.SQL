----Tabla Empleados   J.A..V.R. Para cargar la informacion de los empleados----


CREATE TABLE tbl_Cat_empleados
(	    Id NUMBER (10) not NULL,
        idEmpleado VARCHAR2(10 BYTE), 
        Nombre VARCHAR2(100),
	    APaterno VARCHAR2(100),
        ApMaterno VARCHAR2(100),
        EDepto NUMBER(10),
        EArea NUMBER(10),
        Direccion VARCHAR2(200),
        Telefono  VARCHAR2(14),
        Celular   VARCHAR2(16),
        Email     VARCHAR2(100),
        FaltaE  DATE DEFAULT SYSDATE,
        CTA_USU_LOCAL VARCHAR2(10),
        CTA_USU_GLOBAL VARCHAR2(10),
        CONSTRAINT tbl_Cat_empleados_PK PRIMARY KEY (idEmpleado),
        CONSTRAINT fk_EDepto FOREIGN KEY (EDepto) REFERENCES TBL_DEPTO(Id_Depto),
        CONSTRAINT fk_EArea FOREIGN KEY (EArea) REFERENCES TBL_CAT_AREA(Id_Area));
        

 --CREACION DE SECUENCIA INCRMENTO 1---   
CREATE SEQUENCE INCREMEMPL
START WITH 1
INCREMENT BY 1;

--TRIGEER PARA EL INCREMENENTO DE 1----

CREATE OR REPLACE TRIGGER TRGEMPL
BEFORE INSERT ON tbl_Cat_empleados
FOR EACH ROW
BEGIN 
    SELECT INCREMEMPL.NEXTVAL INTO  :NEW.Id FROM DUAL;    
END;
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
 
 

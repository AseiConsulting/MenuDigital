---Tabla Sistema_Usuarios---

CREATE TABLE tbl_sistema_Usuarios
   (	iUserID VARCHAR2(10 BYTE) NOT NULL ENABLE, 
        sUserName VARCHAR2(10 BYTE),
        sPasword  VARCHAR2(8 BYTE),
        iPerfilId NUMBER(10),
        idDepto   NUMBER(10),
        sPreguntaSecreta VARCHAR2(200),
        sRespuestaSecreta VARCHAR2(200),
        horaAcceso DATE,
        bActivo NUMBER(2,0),
        FCambioPass DATE,
        iCaducidad  NUMBER(10,0),
        FAlta DATE DEFAULT SYSDATE,
        UEmAlta NUMBER(10),
        BInactivo NUMBER(2,0), 
	    CONSTRAINT tbl_sistema_Usuarios_PK PRIMARY KEY (iUserID),
        CONSTRAINT fk_iPerfilId FOREIGN KEY (iPerfilId) REFERENCES TBL_CAT_PERFIL(iPerfilId),
        CONSTRAINT fk_idDepto FOREIGN KEY (idDepto) REFERENCES tbl_Cat_Departamento(IDDEPTO));

DESCRIBE tbl_sistema_Usuarios;
    
    

--PROCEDURE LISTA DE LA TABALA----




--Llamar el procedure de DPTO---

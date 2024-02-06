//Tabla Sistema_Usuarios//
CREATE TABLE tbl_sistema_Usuarios
   (	iUserID VARCHAR2(10 BYTE) NOT NULL ENABLE, 
	vchidUserCorp VARCHAR2(10 BYTE),
        sUserName VARCHAR2(10 BYTE),
        sPasword  VARCHAR2(8 BYTE),
        iPerfilId VARCHAR2(10 BYTE),
        idDepto   VARCHAR2(10 BYTE),
        sPreguntaSecreta VARCHAR2(200),
        sRespuestaSecreta VARCHAR2(200),
        horaAcceso DATE,
        bActivo NUMBER(2,0),
        FCambioPass DATE,
        iCaducidad DATE,
        FAlta DATE,
        UEmAlta VARCHAR2(10 BYTE),
        BInactivo NUMBER(2,0), 
	    CONSTRAINT tbl_sistema_Usuarios_PK PRIMARY KEY (iUserID),
        CONSTRAINT fk_iPerfilId FOREIGN KEY (iPerfilId) REFERENCES tbl_Cat_Perfiles(idPerfil),
        CONSTRAINT fk_idDepto FOREIGN KEY (idDepto) REFERENCES tbl_Cat_Departamento(idDepto),
        CONSTRAINT fk_UEmAlta FOREIGN KEY (UEmAlta) REFERENCES tbl_Cat_empleados(idEmpleado));

//Tabla Sistema Menu//
CREATE TABLE tbl_sistema_Menus
(	iMenuId VARCHAR2(10 BYTE) NOT NULL ENABLE, 
	sDescripcion VARCHAR2(200),
        iPadreId  NUMBER(12,0),
        iPosicion NUMBER(12,0),
        sIcono NUMBER(12,0),
        sUrl   VARCHAR2(10 BYTE),
        dFechaCreacion DATE,
        sUserCreacion VARCHAR2(10 BYTE),
        dFechaModificacion DATE,
        sUsuarioModificacion VARCHAR2(10 BYTE),
        FAlta DATE,
        iUAlta VARCHAR2(10 BYTE),
        FInactivo DATE, 
	    CONSTRAINT tbl_sistema_Menus_PK PRIMARY KEY (iMenuId),
        CONSTRAINT fk_iUAlta FOREIGN KEY (iUAlta) REFERENCES tbl_sistema_Usuarios(iUserID));
    
    
//Tabla Usuario seguimiento//
CREATE TABLE tbl_Sys_Usuarios_Seguimiento
(	iUserID VARCHAR2(10 BYTE), 
	Consec NUMBER(12,0),
    SID    NUMBER(12,0),
    IP     NUMBER(12,0),
    iEstatusId NUMBER(12,0),
    FAlta   DATE,
    MenuAcceso VARCHAR2(10 BYTE),
    TipoProceso VARCHAR2(300),
    descripcion_proceso VARCHAR2(2000),
    CONSTRAINT fk_iUserID FOREIGN KEY (iUserID) REFERENCES tbl_sistema_Usuarios(iUserID),
    CONSTRAINT fk_MenuAcceso FOREIGN KEY (MenuAcceso) REFERENCES tbl_sistema_Menus(iMenuId));
    
    
    //Tabla Catalogo Departamento//
CREATE TABLE tbl_Cat_Departamento
(	idDepto VARCHAR2(10 BYTE) NOT NULL ENABLE, 
	Descripcion VARCHAR2(400),
        Falta DATE,
        CONSTRAINT tbl_Cat_Departamento_PK PRIMARY KEY (idDepto));
        
    
   //Tabla Catalogo Perfiles// 
CREATE TABLE tbl_Cat_Perfiles
(	idPerfil VARCHAR2(10 BYTE) NOT NULL ENABLE, 
	Descripcion VARCHAR2(400),
    CONSTRAINT tbl_Cat_Perfiles_PK PRIMARY KEY (idPerfil));


    //Tabla Empleado//
CREATE TABLE tbl_Cat_empleados
(	idEmpleado VARCHAR2(10 BYTE) NOT NULL ENABLE, 
        Nombre VARCHAR2(100),
	APaterno VARCHAR2(100),
        ApMaterno VARCHAR2(100),
        EDepto VARCHAR2(200),
        EÁrea VARCHAR2(200),
        Direccion VARCHAR2(200),
        Telefono  VARCHAR2(14),
        Celular   VARCHAR2(16),
        Email     VARCHAR2(100),
        FaltaE DATE,
        CONSTRAINT tbl_Cat_empleados_PK PRIMARY KEY (idEmpleado),
        CONSTRAINT fk_UAlta FOREIGN KEY (EDepto) REFERENCES tbl_Cat_Departamento(idDepto));
   
   
   //Tabla Relación_usua_menu//   
CREATE TABLE tbl_relacion_usuarios_menu
(	    idUsuario VARCHAR2(10 BYTE), 
        Idmenu VARCHAR2(10 BYTE),
        CONSTRAINT fk_idUsuario FOREIGN KEY (idUsuario) REFERENCES tbl_sistema_Usuarios(iUserID),
        CONSTRAINT fk_Idmenu FOREIGN KEY (Idmenu) REFERENCES tbl_sistema_Menus(iMenuId));
        

        

        
        
        
    
    
    
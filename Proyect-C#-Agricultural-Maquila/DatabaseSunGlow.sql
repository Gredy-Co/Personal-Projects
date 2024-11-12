-- Crear la base de datos SunGlow
CREATE DATABASE SunGlow;
GO



-- Tabla de Usuarios
CREATE TABLE Usuarios (
    ID_Usuario			INTEGER Not Null PRIMARY KEY,
    Nombre_Usuario		VARCHAR(15) Not Null UNIQUE,
    Contrasena			VARCHAR(255) Not Null,
	Cedula				VARCHAR(50)	Not Null UNIQUE,
	Nombre				VARCHAR(15) Not Null,
	Apellido1			VARCHAR(15) Not Null,
	Apellido2			VARCHAR(15) Not Null,
    Fecha_Creacion		DATETIME Not Null,
    Rol					VARCHAR(100) Not Null,
    Estado				VARCHAR(10)Not Null 
);
GO



-- Tabla de Proveedores
CREATE TABLE Proveedores (
    ID_Proveedor				INTEGER Not Null PRIMARY KEY,
    Nombre_Proveedor			VARCHAR(100) Not Null,
    Direccion					VARCHAR(255) Not Null,
    Ciudad						VARCHAR(100) Not Null,
    Pais						VARCHAR(100) Not Null,
    Telefono					VARCHAR(20) Not Null,
    Correo_Electronico			VARCHAR(100) Not Null,
    Categoria_Producto_Servicio VARCHAR(100) Not Null,
    Estado						VARCHAR(10) Not Null
);
GO



-- Tabla Movimientos
CREATE TABLE Movimientos (
    ID_Movimiento				INT PRIMARY KEY Not Null,
    ID_Usuario					INT Not Null,
    Seccion						VARCHAR(50) Not Null,
    Tipo_Movimiento				VARCHAR(50) Not Null,
    Fecha_Movimiento			DATE Not Null,
    Hora_Movimiento				TIME Not Null,
    Estado						VARCHAR(10) Not Null
);



-- Tabla de Tipo de Fruto
CREATE TABLE Tipos_De_Frutos (
    ID_Tipo_De_Fruto			INT PRIMARY KEY Not Null,
    Tipos_De_Frutos				VARCHAR(100) Not Null,
    Descripcion_Tipo_De_Fruto	VARCHAR(255) Null,
    Estado						VARCHAR(10) Not Null
);



-- Tabla de Variedad de Fruto
CREATE TABLE Variedades_De_Frutos (
    ID_Variedad_Fruto			INT PRIMARY KEY Not Null,
    Nombre_Variedad				VARCHAR(100) Not Null,
    Descripcion_Variedad		VARCHAR(255) Not Null,
    Temporada_Cosecha			VARCHAR(100) Not Null,
    Estado						VARCHAR(10) Not Null
);



-- Tabla de Fincas
CREATE TABLE Fincas (
    ID_Finca					INT PRIMARY KEY Not Null,
    Nombre_Finca				VARCHAR(100) Not Null,
    Ubicacion					VARCHAR(255) Not Null,
    Area_Total					DECIMAL(10, 2) Not Null,
    Tipo_Suelo					VARCHAR(50) Not Null,
    Proveedor_ID				INT Not Null,
    Estado						VARCHAR(10) Not Null,

	CONSTRAINT FK_Proveedor		FOREIGN KEY (Proveedor_ID) REFERENCES Proveedores(ID_Proveedor)
);



-- Tabla de Lotes
CREATE TABLE Lotes (
    ID_Lote						INT PRIMARY KEY Not Null,
    Nombre_Lote					VARCHAR(100) Not Null,
    Area_Total					DECIMAL(10, 2) Not Null,
    Finca_ID					INT Not Null,
    Estado						VARCHAR(10) Not Null,

	CONSTRAINT FK_Finca FOREIGN KEY (Finca_ID) REFERENCES Fincas(ID_Finca)
);



-- Tabla de Bloques
CREATE TABLE Bloques (
    ID_Bloque					INT PRIMARY KEY Not Null,
    Nombre_Bloque				VARCHAR(100) Not Null,
    Lote_ID						INT Not Null,
    Variedad_Fruto_ID			INT Not Null,
    Estado						VARCHAR(10) Not Null,

	CONSTRAINT FK_Lote FOREIGN KEY (Lote_ID) REFERENCES Lotes(ID_Lote),
	CONSTRAINT FK_VariedadFruto FOREIGN KEY (Variedad_Fruto_ID) REFERENCES Variedades_De_Frutos(ID_Variedad_Fruto)
);



-- Tabla de Bines
CREATE TABLE Bines (
    ID_Bin						INT PRIMARY KEY Not Null,
    Numero_Bin					INT Not Null,
	Detalle						VARCHAR(100),
    Estado						VARCHAR(10) Not Null
);



-- Tabla de Recepcion Envio
CREATE TABLE Recepcion_Envio (
    ID_Recepcion				INT PRIMARY KEY Not Null,
    Nombre_Conductor			VARCHAR(100)Not Null,
    Placa_Camion				VARCHAR(20) Not Null,
    Cedula						VARCHAR(20) Not Null,
    N_Bines						INT Not Null,
    Hora_Envio					TIME Not Null,
    Hora_Llegada				TIME Not Null,
    Fecha						DATE Not Null,
    Peso_Neto					DECIMAL(10, 2) Not Null,
    Estado						VARCHAR(10) Not Null,
);



-- Tabla de Boleta Cosecha
CREATE TABLE Boleta_Cosecha (
    ID_Boleta					INT PRIMARY KEY Not Null,
    Consecutivo_Boleta			INT Not Null,
    Envio_ID					INT Not Null,
    Cuadrilla					VARCHAR(100) Not Null,
    Fecha_Cosecha				DATE Not Null,
    Hora_Cosecha				TIME Not Null,
    Estado						VARCHAR(10) Not Null,

    CONSTRAINT FK_Envio FOREIGN KEY (Envio_ID) REFERENCES Recepcion_Envio(ID_Recepcion)
);



-- Tabla Detalle de Cosecha
CREATE TABLE Detalle_Cosecha (
    ID_Detalle					INT PRIMARY KEY Not Null,
    Boleta_ID					INT Not Null,
    N_Bin						INT Not Null,
    Cantidad_Fruta				INT Not Null,
    Promedio_Fruta				DECIMAL(10, 2) Not Null,
    Finca_ID					INT Not Null,
    Lote_ID						INT Not Null,
    Bloque_ID					INT Not Null,
    Variedad_Fruto_ID			INT Not Null,
    Tipo_Fruto_ID				INT Not Null,
    Estado						VARCHAR(10) Not Null,

    CONSTRAINT FK_Boleta FOREIGN KEY (Boleta_ID) REFERENCES Boleta_Cosecha(ID_Boleta),
    CONSTRAINT FK_Bin FOREIGN KEY (N_Bin) REFERENCES Bines(ID_Bin),
    CONSTRAINT FKD_Finca FOREIGN KEY (Finca_ID) REFERENCES Fincas(ID_Finca),
    CONSTRAINT FKD_Lote FOREIGN KEY (Lote_ID) REFERENCES Lotes(ID_Lote),
    CONSTRAINT FKD_Bloque FOREIGN KEY (Bloque_ID) REFERENCES Bloques(ID_Bloque),
    CONSTRAINT FKD_Variedad FOREIGN KEY (Variedad_Fruto_ID) REFERENCES Variedades_De_Frutos(ID_Variedad_Fruto),
    CONSTRAINT FKD_Tipo FOREIGN KEY (Tipo_Fruto_ID) REFERENCES Tipos_De_Frutos(ID_Tipo_De_Fruto)
);


-- Tabla de Inmersión
CREATE TABLE Inmersion (
    ID_Inmersion				INT PRIMARY KEY Not Null,
    DetalleBol_ID				INT Not Null,
    N_Bin						INT Not Null,
    Fecha_Inmersion				DATE Not Null,
    Hora_Inmersion				TIME Not Null,
    Temperatura_Agua			DECIMAL(10,2) Not Null,
    Duracion_Inmersion			INT Not Null,
    Estado						VARCHAR(10) Not Null,

    CONSTRAINT FK_DetalleBol FOREIGN KEY (DetalleBol_ID) REFERENCES Detalle_Cosecha(ID_Detalle),
    CONSTRAINT FK_BinID FOREIGN KEY (N_Bin) REFERENCES Bines(ID_Bin),
);



-- Tabla Empaque
CREATE TABLE Empaque (
    ID_Empaque					INT PRIMARY KEY Not Null,
    Tamano_Fruta				INT Not Null,
	Cantidad_Fruta				INT Not Null,
	Cantidad_Cajas				INT Not Null,
    Fecha_Empaque				DATE Not Null,
    Hora_Empaque				TIME Not Null,
    Estado						VARCHAR(10) Not Null,
);

-- Tabla Palletizado
CREATE TABLE Palletizado (
    ID_Palletizado				INT PRIMARY KEY Not Null,
    Numero_Pallet				INT Not Null,
    Cantidad_Cajas_En_Pallet	INT Not Null,
    Fecha_Palletizado			DATE Not Null,
    Hora_Palletizado			TIME Not Null,
    Destino_Pallet				VARCHAR(100) Not Null,
    Estado						VARCHAR(10) Not Null,
);



--Consultas
Select * from Usuarios
Select * from Proveedores
Select * from Movimientos
Select * from Tipos_De_Frutos
Select * from Variedades_De_Frutos
Select * from Fincas
Select * from Lotes
Select * from Bloques
Select * from Bines
Select * from Recepcion_Envio
Select * from Boleta_Cosecha
Select * from Detalle_Cosecha
Select * from Inmersion
Select * from Empaque
Select * from Palletizado





UPDATE Inmersion SET Estado = 'Activo' WHERE Estado = 'Inactivo'



--Eliminar información de la tabla
delete from Palletizado



--Actualizar Inmersion 
UPDATE Inmersion SET Estado = 'Activo'
WHERE ID_Inmersion = 1



--Renombra
EXEC sp_rename 'Inmersion.Bin_ID', 'N_Bin', 'COLUMN';
EXEC sp_rename 'Bines', 'Bino';



--Modifica datos de la tabla
ALTER TABLE Usuarios
ALTER COLUMN Estado VARCHAR(10);



--Borra ID 
Delete from Bloques 
Where ID_Bloque = 4


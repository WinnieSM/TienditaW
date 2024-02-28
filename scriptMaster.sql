CREATE Database TienditaW
USE TienditaW

--USE master
--DROP DATABASE TienditaW

drop TABLE dbo.Usuarios
CREATE TABLE dbo.Usuarios(
iIdUsuario int IDENTITY(1,1) PRIMARY KEY,
cNombres varchar (50),
cApellidos  varchar (50),
cCorreo varchar (50),
cUsuario  varchar (20),
cPassword  varchar (50),
lReestablecer bit default 1,
lActivo bit default 1,
dtCreacion datetime,
dtModificacion datetime,
)

CREATE TABLE dbo.Proveedor(
iIdProveedor int IDENTITY(1,1) PRIMARY KEY,
cNombre varchar(50),
lActivo bit default 1,
)

CREATE TABLE dbo.Productos(
iIdProducto int IDENTITY(1,1) PRIMARY KEY,
cDescripcion varchar(50),
iPrecio float,
iCosto float,
iCantidad int,
lActivo bit default 1,
iIdProveedor int,
FOREIGN KEY(iIdProveedor) REFERENCES dbo.Proveedor
)

CREATE TABLE dbo.Clientes(
iIdCliente int IDENTITY(1,1) PRIMARY KEY,
cNombres varchar(30),
cApellidos varchar(30),
lDeuda bit default 0,
cCorreo varchar(30),
lActivo bit default 1,
dtCreacion datetime,
dtModificacion datetime,
)

CREATE TABLE dbo.Rel_Ventas(
iIdVenta int IDENTITY(1,1) PRIMARY KEY,
iIdProducto int,
iIdCliente int,
iTotal float,
lPagado bit, --1 = SI - 0 = NO
dtVenta datetime,
dtModificado datetime,
lActivo bit default 1,
FOREIGN KEY(iIdProducto) REFERENCES dbo.Productos,
FOREIGN KEY(iIdCliente) REFERENCES dbo.Clientes
)


-----------------------------------------------------------------------------------------------------------------------------

SELECT iIdUsuario, cUsuario, cNombres, cApellidos, cCorreo, cPassword, lReestablecer, lActivo FROM dbo.Usuarios



-----------------------------------------------------------------------------------------------------------------------------

INSERT INTO [dbo].[Usuarios] (cNombres,cApellidos,cCorreo,cUsuario,cPassword, lReestablecer, dtCreacion, dtModificacion)
VALUES ('Winnie Adriel','Solis Mendiburu', 'winniemendiburu@gmail.com','Winnie.Solis','12345',0,GETDATE(),GETDATE())

INSERT INTO [dbo].[Usuarios] (cNombres,cApellidos,cCorreo,cUsuario,cPassword, lReestablecer, dtCreacion, dtModificacion)
VALUES ('Administrador','', 'winniemendiburu@gmail.com','Administrador','12345',0,GETDATE(),GETDATE())


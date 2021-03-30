/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : SQL Server
 Source Server Version : 13005026
 Source Host           : DESKTOP-5GILTJU\SQLEXPRESS:1433
 Source Catalog        : OpheliaFacturacion
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 13005026
 File Encoding         : 65001

 Date: 30/03/2021 16:49:18
*/


-- ----------------------------
-- Table structure for Cliente
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cliente]') AND type IN ('U'))
	DROP TABLE [dbo].[Cliente]
GO

CREATE TABLE [dbo].[Cliente] (
  [clienteId] int  IDENTITY(1,1) NOT NULL,
  [nombres] nchar(200) COLLATE Modern_Spanish_CI_AS  NULL,
  [fechaNacimiento] date  NULL
)
GO

ALTER TABLE [dbo].[Cliente] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Cliente
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Cliente] ON
GO

INSERT INTO [dbo].[Cliente] ([clienteId], [nombres], [fechaNacimiento]) VALUES (N'1', N'Santiago Contreras                                                                                                                                                                                      ', N'1998-03-23'), (N'2', N'Sara Lugo                                                                                                                                                                                               ', N'1966-03-23'), (N'3', N'Felipe Hernandez                                                                                                                                                                                        ', N'1999-03-23'), (N'4', N'Diego Perez                                                                                                                                                                                             ', N'1968-03-23'), (N'5', N'Laura Tobón                                                                                                                                                                                             ', N'1978-03-23'), (N'6', N'Liam Contreras                                                                                                                                                                                          ', N'1988-03-23')
GO

SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for factura
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[factura]') AND type IN ('U'))
	DROP TABLE [dbo].[factura]
GO

CREATE TABLE [dbo].[factura] (
  [facturaId] int  IDENTITY(1,1) NOT NULL,
  [clienteId] int  NULL,
  [fechaCompra] datetime  NULL,
  [totalFactura] float(53)  NULL
)
GO

ALTER TABLE [dbo].[factura] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of factura
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[factura] ON
GO

INSERT INTO [dbo].[factura] ([facturaId], [clienteId], [fechaCompra], [totalFactura]) VALUES (N'1', N'1', N'2021-03-30 16:46:55.000', N'200'), (N'2', N'2', N'2020-03-30 16:46:55.000', N'200'), (N'3', N'3', N'2019-03-30 16:46:55.000', N'200'), (N'4', N'4', N'2019-03-30 16:46:55.000', N'200')
GO

SET IDENTITY_INSERT [dbo].[factura] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for FacturaDetalle
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[FacturaDetalle]') AND type IN ('U'))
	DROP TABLE [dbo].[FacturaDetalle]
GO

CREATE TABLE [dbo].[FacturaDetalle] (
  [facturaDetalleId] int  IDENTITY(1,1) NOT NULL,
  [facturaId] int  NULL,
  [productoId] int  NULL,
  [cantidad] int  NULL
)
GO

ALTER TABLE [dbo].[FacturaDetalle] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of FacturaDetalle
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[FacturaDetalle] ON
GO

INSERT INTO [dbo].[FacturaDetalle] ([facturaDetalleId], [facturaId], [productoId], [cantidad]) VALUES (N'1', N'4', N'1', N'2'), (N'2', N'3', N'2', N'1'), (N'3', N'2', N'3', N'1'), (N'4', N'1', N'4', N'1')
GO

SET IDENTITY_INSERT [dbo].[FacturaDetalle] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Inventario
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventario]') AND type IN ('U'))
	DROP TABLE [dbo].[Inventario]
GO

CREATE TABLE [dbo].[Inventario] (
  [intentarioId] int  IDENTITY(1,1) NOT NULL,
  [productoId] int  NULL,
  [cantidadActual] int  NULL
)
GO

ALTER TABLE [dbo].[Inventario] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Inventario
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Inventario] ON
GO

INSERT INTO [dbo].[Inventario] ([intentarioId], [productoId], [cantidadActual]) VALUES (N'1', N'1', N'20'), (N'2', N'2', N'20'), (N'3', N'3', N'20'), (N'4', N'4', N'20'), (N'5', N'5', N'20'), (N'6', N'6', N'20'), (N'7', N'7', N'20')
GO

SET IDENTITY_INSERT [dbo].[Inventario] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Producto
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Producto]') AND type IN ('U'))
	DROP TABLE [dbo].[Producto]
GO

CREATE TABLE [dbo].[Producto] (
  [productoId] int  IDENTITY(1,1) NOT NULL,
  [nombre] nchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [valorUnitario] float(53)  NOT NULL
)
GO

ALTER TABLE [dbo].[Producto] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Producto
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Producto] ON
GO

INSERT INTO [dbo].[Producto] ([productoId], [nombre], [valorUnitario]) VALUES (N'1', N'lapiz                                                                                               ', N'100'), (N'2', N'hoja carta                                                                                          ', N'50'), (N'3', N'hoja oficio                                                                                         ', N'75'), (N'4', N'resma de papel carta                                                                                ', N'7000'), (N'5', N'cuaderno 50 hojas                                                                                   ', N'1500'), (N'6', N'baterias AA                                                                                         ', N'500'), (N'7', N'baterias AAA                                                                                        ', N'700')
GO

SET IDENTITY_INSERT [dbo].[Producto] OFF
GO

COMMIT
GO


-- ----------------------------
-- Primary Key structure for table Cliente
-- ----------------------------
ALTER TABLE [dbo].[Cliente] ADD CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([clienteId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table factura
-- ----------------------------
ALTER TABLE [dbo].[factura] ADD CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED ([facturaId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table FacturaDetalle
-- ----------------------------
ALTER TABLE [dbo].[FacturaDetalle] ADD CONSTRAINT [PK_FacturaDetalle] PRIMARY KEY CLUSTERED ([facturaDetalleId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Inventario
-- ----------------------------
ALTER TABLE [dbo].[Inventario] ADD CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED ([intentarioId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Producto
-- ----------------------------
ALTER TABLE [dbo].[Producto] ADD CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([productoId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table factura
-- ----------------------------
ALTER TABLE [dbo].[factura] ADD CONSTRAINT [fk_factura_Cliente_1] FOREIGN KEY ([clienteId]) REFERENCES [dbo].[Cliente] ([clienteId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table FacturaDetalle
-- ----------------------------
ALTER TABLE [dbo].[FacturaDetalle] ADD CONSTRAINT [fk_FacturaDetalle_factura_1] FOREIGN KEY ([facturaId]) REFERENCES [dbo].[factura] ([facturaId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[FacturaDetalle] ADD CONSTRAINT [fk_FacturaDetalle_Producto_1] FOREIGN KEY ([productoId]) REFERENCES [dbo].[Producto] ([productoId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Inventario
-- ----------------------------
ALTER TABLE [dbo].[Inventario] ADD CONSTRAINT [fk_Inventario_Producto_1] FOREIGN KEY ([productoId]) REFERENCES [dbo].[Producto] ([productoId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


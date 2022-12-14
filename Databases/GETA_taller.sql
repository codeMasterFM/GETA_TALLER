USE [master]
GO
/****** Object:  Database [GETA_taller]    Script Date: 7/4/2022 11:43:49 PM ******/
CREATE DATABASE [GETA_taller]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GETA_taller', FILENAME = N'C:\Users\Franklyn\GETA_taller.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GETA_taller_log', FILENAME = N'C:\Users\Franklyn\GETA_taller_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GETA_taller] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GETA_taller].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GETA_taller] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GETA_taller] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GETA_taller] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GETA_taller] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GETA_taller] SET ARITHABORT OFF 
GO
ALTER DATABASE [GETA_taller] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GETA_taller] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GETA_taller] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GETA_taller] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GETA_taller] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GETA_taller] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GETA_taller] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GETA_taller] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GETA_taller] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GETA_taller] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GETA_taller] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GETA_taller] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GETA_taller] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GETA_taller] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GETA_taller] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GETA_taller] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GETA_taller] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GETA_taller] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GETA_taller] SET  MULTI_USER 
GO
ALTER DATABASE [GETA_taller] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GETA_taller] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GETA_taller] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GETA_taller] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GETA_taller] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GETA_taller] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GETA_taller] SET QUERY_STORE = OFF
GO
USE [GETA_taller]
GO
/****** Object:  Table [dbo].[GETA_cliente]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](60) NULL,
	[APELLIDO] [varchar](60) NULL,
	[DIRECCION] [varchar](100) NULL,
	[TELEFONO] [varchar](50) NULL,
	[FECHA_REGISTRO] [datetimeoffset](7) NULL,
	[ESTADO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_detalle_reparacion]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_detalle_reparacion](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[CANTIDAD] [varchar](100) NULL,
	[MANO_OBRA] [float] NULL,
	[COMETARIO] [text] NULL,
	[id_servicio] [int] NULL,
	[id_inventario] [int] NULL,
	[ESTADO] [int] NULL,
	[id_mecanico] [int] NULL,
	[id_vehiculo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_factura]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[SUBTOTAL] [float] NULL,
	[ITB] [float] NULL,
	[TOTAL] [float] NULL,
	[fecha_salida] [datetime] NULL,
	[id_mecanico] [int] NULL,
	[id_cliente] [int] NULL,
	[id_taller] [int] NULL,
	[id_vehiculo] [int] NULL,
	[PAGO] [varchar](30) NULL,
	[ESTADO] [int] NULL,
	[detalle] [int] NULL,
	[id_inventario] [int] NULL,
	[id_detalle] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_inventario_repuesto]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_inventario_repuesto](
	[id_inventario] [int] IDENTITY(1,1) NOT NULL,
	[CATEGORIA] [varchar](60) NULL,
	[NOMBRE_PIEZAS] [varchar](100) NULL,
	[CANTIDAD_DISPONIBLE] [int] NULL,
	[PRECIO] [float] NULL,
	[ESTADO] [int] NULL,
	[id_detalle] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_mecanico]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_mecanico](
	[id_mecanico] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](60) NULL,
	[APELLID0] [varchar](60) NULL,
	[CEDULA] [varchar](100) NULL,
	[ESTADO] [int] NULL,
	[id_detalle] [int] NULL,
	[ELIMINAR] [int] NULL,
	[id_vehiculo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mecanico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_servicio]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_servicio](
	[id_servicio] [int] IDENTITY(1,1) NOT NULL,
	[EVALUCION] [text] NULL,
	[PRECIO] [int] NULL,
	[id_vehiculo] [int] NULL,
	[ESTADO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_taller]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_taller](
	[id_taller] [int] IDENTITY(1,1) NOT NULL,
	[RNC] [varchar](100) NULL,
	[NOMBRE] [varchar](60) NULL,
	[TELEFONO] [varchar](30) NULL,
	[CORREO] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_taller] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_usuario]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[ROL] [int] NULL,
	[NOMBRE] [varchar](60) NULL,
	[USUARIO] [varchar](30) NULL,
	[CONTRASENA] [varchar](30) NULL,
	[id_mecanico] [int] NULL,
	[ESTADO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GETA_vehiculo]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETA_vehiculo](
	[id_vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[MATRICULA] [varchar](20) NULL,
	[MODELO] [varchar](30) NULL,
	[COLOR] [varchar](30) NULL,
	[id_cliente] [int] NULL,
	[ESTADO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GETA_detalle_reparacion]  WITH CHECK ADD FOREIGN KEY([id_inventario])
REFERENCES [dbo].[GETA_inventario_repuesto] ([id_inventario])
GO
ALTER TABLE [dbo].[GETA_detalle_reparacion]  WITH CHECK ADD FOREIGN KEY([id_mecanico])
REFERENCES [dbo].[GETA_mecanico] ([id_mecanico])
GO
ALTER TABLE [dbo].[GETA_detalle_reparacion]  WITH CHECK ADD FOREIGN KEY([id_servicio])
REFERENCES [dbo].[GETA_servicio] ([id_servicio])
GO
ALTER TABLE [dbo].[GETA_detalle_reparacion]  WITH CHECK ADD FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[GETA_vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[GETA_factura]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[GETA_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[GETA_factura]  WITH CHECK ADD FOREIGN KEY([id_detalle])
REFERENCES [dbo].[GETA_detalle_reparacion] ([id_detalle])
GO
ALTER TABLE [dbo].[GETA_factura]  WITH CHECK ADD FOREIGN KEY([id_inventario])
REFERENCES [dbo].[GETA_inventario_repuesto] ([id_inventario])
GO
ALTER TABLE [dbo].[GETA_factura]  WITH CHECK ADD FOREIGN KEY([id_mecanico])
REFERENCES [dbo].[GETA_mecanico] ([id_mecanico])
GO
ALTER TABLE [dbo].[GETA_factura]  WITH CHECK ADD FOREIGN KEY([id_taller])
REFERENCES [dbo].[GETA_taller] ([id_taller])
GO
ALTER TABLE [dbo].[GETA_factura]  WITH CHECK ADD FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[GETA_vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[GETA_inventario_repuesto]  WITH CHECK ADD FOREIGN KEY([id_detalle])
REFERENCES [dbo].[GETA_detalle_reparacion] ([id_detalle])
GO
ALTER TABLE [dbo].[GETA_mecanico]  WITH CHECK ADD FOREIGN KEY([id_detalle])
REFERENCES [dbo].[GETA_detalle_reparacion] ([id_detalle])
GO
ALTER TABLE [dbo].[GETA_mecanico]  WITH CHECK ADD FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[GETA_vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[GETA_servicio]  WITH CHECK ADD FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[GETA_vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[GETA_usuario]  WITH CHECK ADD FOREIGN KEY([id_mecanico])
REFERENCES [dbo].[GETA_mecanico] ([id_mecanico])
GO
ALTER TABLE [dbo].[GETA_vehiculo]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[GETA_cliente] ([id_cliente])
GO
/****** Object:  StoredProcedure [dbo].[detalle_factura]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detalle_factura] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE, GETA_cliente.APELLIDO , GETA_cliente.TELEFONO, GETA_cliente.DIRECCION,
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'NOMBRE MECANICO' , GETA_mecanico.APELLID0 , GETA_mecanico.CEDULA,
GETA_taller.NOMBRE , GETA_taller.TELEFONO,GETA_taller.CORREO ,GETA_taller.CORREO
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[detalle_factura1]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detalle_factura1] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE, GETA_cliente.APELLIDO , GETA_cliente.TELEFONO, GETA_cliente.DIRECCION,
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'NOMBRE MECANICO' , GETA_mecanico.APELLID0 , GETA_mecanico.CEDULA,
GETA_taller.NOMBRE , GETA_taller.TELEFONO,GETA_taller.CORREO ,GETA_taller.CORREO
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
 exec detalle_factura 1
GO
/****** Object:  StoredProcedure [dbo].[factura]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE, GETA_cliente.APELLIDO , GETA_cliente.TELEFONO, GETA_cliente.DIRECCION,
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'NOMBRE MECANICO' , GETA_mecanico.APELLID0 , GETA_mecanico.CEDULA,
GETA_taller.NOMBRE , GETA_taller.TELEFONO,GETA_taller.CORREO ,GETA_taller.CORREO
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE as 'NOMBRE CLIENTE', GETA_cliente.APELLIDO as 'NOMBRE APELLIDO'  , GETA_cliente.TELEFONO as 'CLIENTE TELEFONO', GETA_cliente.DIRECCION as 'CLIENTE DIRECCION',
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'NOMBRE MECANICO' , GETA_mecanico.APELLID0 as 'APELLIDO MECANICO' , GETA_mecanico.CEDULA as 'CEDULA MECANICO',
GETA_taller.NOMBRE as 'NOMBRE TALLER' , GETA_taller.TELEFONO,GETA_taller.CORREO as 'CORREO TALLER'
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
 exec detalle_factura 10
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle1]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle1] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE as 'CLIENTE NOMBRE ', GETA_cliente.APELLIDO as 'CLIENTE APELLIDO'  , GETA_cliente.TELEFONO as 'CLIENTE TELEFONO', GETA_cliente.DIRECCION as 'CLIENTE DIRECCION',
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'MECANICO NOMBRE ' , GETA_mecanico.APELLID0 as 'MECANICO APELLIDO ' , GETA_mecanico.CEDULA as 'MECANICO CEDULA ',
GETA_taller.NOMBRE as ' TALLER NOMBRE' , GETA_taller.TELEFONO,GETA_taller.CORREO as 'TALLER CORREO '
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
 exec factura_detalle 1
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle10]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle10] (@id_cliente int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.NOMBRE as 'CLIENTE_NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE_APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE_DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE_TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 'MECANICO_APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA,GETA_cliente.FECHA_REGISTRO,PAGO
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
		where GETA_cliente.id_cliente = @id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle11]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle11](@id_cliente int , @id_mecanico int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.id_cliente,
		GETA_cliente.NOMBRE as 'CLIENTE_NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE_APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE_DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE_TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 'MECANICO_APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA,GETA_cliente.FECHA_REGISTRO,PAGO
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
		where GETA_cliente.id_cliente = @id_cliente and GETA_mecanico.id_mecanico = 1
end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle2]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle2] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE as 'CLIENTE NOMBRE ', GETA_cliente.APELLIDO as 'CLIENTE APELLIDO'  , GETA_cliente.TELEFONO as 'CLIENTE TELEFONO', GETA_cliente.DIRECCION as 'CLIENTE DIRECCION',
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'MECANICO NOMBRE ' , GETA_mecanico.APELLID0 as 'MECANICO APELLIDO ' , GETA_mecanico.CEDULA as 'MECANICO CEDULA ',
GETA_taller.NOMBRE as ' TALLER NOMBRE' , GETA_taller.TELEFONO,GETA_taller.CORREO as 'TALLER CORREO ',GETA_factura.SUBTOTAL,
GETA_factura.ITB,GETA_factura.TOTAL,GETA_factura.PAGO
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
 exec factura_detalle2 1
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle3]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle3] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE as 'CLIENTE NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE APELLIDO'  , GETA_cliente.TELEFONO as 'CLIENTE TELEFONO', GETA_cliente.DIRECCION as 'CLIENTE DIRECCION',
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'MECANICO NOMBRE ' , GETA_mecanico.APELLID0 as 'MECANICO APELLIDO ' , GETA_mecanico.CEDULA as 'MECANICO CEDULA ',
GETA_taller.NOMBRE as ' TALLER NOMBRE' , GETA_taller.TELEFONO,GETA_taller.CORREO as 'TALLER CORREO ',GETA_factura.SUBTOTAL,
GETA_factura.ITB,GETA_factura.TOTAL,GETA_factura.PAGO
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
 exec factura_detalle2 200
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle4]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle4] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE as 'CLIENTE NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE APELLIDO'  , GETA_cliente.TELEFONO as 'CLIENTE TELEFONO', GETA_cliente.DIRECCION as 'CLIENTE DIRECCION',
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'MECANICO NOMBRE ' , GETA_mecanico.APELLID0 as 'MECANICO APELLIDO ' , GETA_mecanico.CEDULA as 'MECANICO CEDULA ',
GETA_taller.NOMBRE as ' TALLER NOMBRE' , GETA_taller.TELEFONO,GETA_taller.CORREO as 'TALLER CORREO '
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
where GETA_cliente.id_cliente = @id_cliente
end
 exec factura_detalle2 200
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle5]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle5] (@id_cliente int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.NOMBRE as 'CLIENTE NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE MECANICO', GETA_mecanico.APELLID0 'MECANICO APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_factura
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
end
 exec factura_detalle4 200
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle6]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle6] (@id_cliente int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.NOMBRE as 'CLIENTE NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE MECANICO', GETA_mecanico.APELLID0 'MECANICO APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_factura
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle7]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle7] (@id_cliente int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.NOMBRE as 'CLIENTE NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE MECANICO', GETA_mecanico.APELLID0 'MECANICO APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_factura
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
		where GETA_cliente.id_cliente = @id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle8]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle8] (@id_cliente int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.NOMBRE as 'CLIENTE_NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE_APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE_DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE_TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 'MECANICO_APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA,GETA_cliente.FECHA_REGISTRO
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_factura
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
		where GETA_cliente.id_cliente = @id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalle9]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalle9] (@id_cliente int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.NOMBRE as 'CLIENTE_NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE_APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE_DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE_TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 'MECANICO_APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA,GETA_cliente.FECHA_REGISTRO
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
		where GETA_cliente.id_cliente = @id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalleA1]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalleA1] (@id_cliente int)
AS
begin
select GETA_cliente.id_cliente, GETA_cliente.NOMBRE AS 'NOMBRE_CLIENTE', GETA_cliente.APELLIDO AS 'APELLIDO_CLIENTE' , GETA_cliente.DIRECCION , GETA_cliente.FECHA_REGISTRO,
		GETA_mecanico.NOMBRE AS 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 AS 'APELLIDO_MECANICO',GETA_mecanico.CEDULA,GETA_inventario_repuesto.NOMBRE_PIEZAS,
		GETA_detalle_reparacion.CANTIDAD,GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.MANO_OBRA,
		GETA_inventario_repuesto.PRECIO*GETA_detalle_reparacion.CANTIDAD+MANO_OBRA as 'SUB_TOTAL',
		GETA_inventario_repuesto.PRECIO*GETA_detalle_reparacion.CANTIDAD+MANO_OBRA*1.6 as total
		from GETA_cliente
		join GETA_vehiculo on GETA_vehiculo.id_cliente = GETA_cliente.id_cliente
		join GETA_mecanico on GETA_mecanico.id_vehiculo = GETA_vehiculo.id_vehiculo
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_vehiculo = GETA_vehiculo.id_vehiculo
		join GETA_inventario_repuesto on GETA_inventario_repuesto.id_inventario = GETA_detalle_reparacion.id_inventario
		where GETA_cliente.id_cliente = @id_cliente
		end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalleA2]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[factura_detalleA2] (@id_cliente int)
AS
begin
select GETA_cliente.id_cliente, GETA_cliente.NOMBRE AS 'NOMBRE_CLIENTE', GETA_cliente.APELLIDO AS 'APELLIDO_CLIENTE' , GETA_cliente.DIRECCION , GETA_cliente.FECHA_REGISTRO,
		GETA_mecanico.NOMBRE AS 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 AS 'APELLIDO_MECANICO',GETA_mecanico.CEDULA,GETA_inventario_repuesto.NOMBRE_PIEZAS,
		GETA_detalle_reparacion.CANTIDAD,GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.MANO_OBRA,
		GETA_inventario_repuesto.PRECIO*GETA_detalle_reparacion.CANTIDAD+MANO_OBRA as 'SUB_TOTAL',
		GETA_inventario_repuesto.PRECIO*GETA_detalle_reparacion.CANTIDAD+MANO_OBRA*0.16 as total
		from GETA_cliente
		join GETA_vehiculo on GETA_vehiculo.id_cliente = GETA_cliente.id_cliente
		join GETA_mecanico on GETA_mecanico.id_vehiculo = GETA_vehiculo.id_vehiculo
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_vehiculo = GETA_vehiculo.id_vehiculo
		join GETA_inventario_repuesto on GETA_inventario_repuesto.id_inventario = GETA_detalle_reparacion.id_inventario
		where GETA_cliente.id_cliente = @id_cliente
		end
GO
/****** Object:  StoredProcedure [dbo].[factura_detalleA3]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[factura_detalleA3] (@id_cliente int)
AS
begin
select GETA_cliente.id_cliente, GETA_cliente.NOMBRE AS 'NOMBRE_CLIENTE', GETA_cliente.APELLIDO AS 'APELLIDO_CLIENTE' , GETA_cliente.DIRECCION , GETA_cliente.FECHA_REGISTRO,
		GETA_mecanico.NOMBRE AS 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 AS 'APELLIDO_MECANICO',GETA_mecanico.CEDULA,GETA_inventario_repuesto.NOMBRE_PIEZAS,
		GETA_detalle_reparacion.CANTIDAD,GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.MANO_OBRA,
		GETA_inventario_repuesto.PRECIO*GETA_detalle_reparacion.CANTIDAD+MANO_OBRA as 'SUB_TOTAL',
		GETA_inventario_repuesto.PRECIO*GETA_detalle_reparacion.CANTIDAD+MANO_OBRA*0.16 as ITB
		from GETA_cliente
		join GETA_vehiculo on GETA_vehiculo.id_cliente = GETA_cliente.id_cliente
		join GETA_mecanico on GETA_mecanico.id_vehiculo = GETA_vehiculo.id_vehiculo
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_vehiculo = GETA_vehiculo.id_vehiculo
		join GETA_inventario_repuesto on GETA_inventario_repuesto.id_inventario = GETA_detalle_reparacion.id_inventario
		where GETA_cliente.id_cliente = @id_cliente
		end
GO
/****** Object:  StoredProcedure [dbo].[id_mecanico]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[id_mecanico](@id_cliente int , @id_mecanico int)
AS
begin
	select GETA_factura.SUBTOTAL , GETA_factura.ITB, GETA_factura.TOTAL,
		GETA_cliente.id_cliente,
		GETA_cliente.NOMBRE as 'CLIENTE_NOMBRE', GETA_cliente.APELLIDO as 'CLIENTE_APELLIDO',
		GETA_cliente.DIRECCION as 'CLIENTE_DIRECCION' ,GETA_cliente.TELEFONO as 'CLIENTE_TELEFONO',
		GETA_mecanico.NOMBRE as 'NOMBRE_MECANICO', GETA_mecanico.APELLID0 'MECANICO_APELLIDO',GETA_mecanico.CEDULA,
		GETA_inventario_repuesto.NOMBRE_PIEZAS as 'REPUESTOS',GETA_inventario_repuesto.PRECIO,GETA_detalle_reparacion.CANTIDAD,
		GETA_detalle_reparacion.MANO_OBRA,GETA_cliente.FECHA_REGISTRO,PAGO
		from GETA_factura
		join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
		join GETA_mecanico on GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
		join GETA_inventario_repuesto on GETA_factura.id_inventario = GETA_inventario_repuesto.id_inventario
		join GETA_detalle_reparacion on GETA_detalle_reparacion.id_detalle = GETA_factura.id_detalle
		where GETA_cliente.id_cliente = @id_cliente and GETA_mecanico.id_mecanico = 1
end
GO
/****** Object:  StoredProcedure [dbo].[proceso_factura]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proceso_factura] (@id_cliente int)
AS
begin
	SELECT GETA_cliente.NOMBRE, GETA_cliente.APELLIDO , GETA_cliente.TELEFONO, GETA_cliente.DIRECCION,
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'NOMBRE MECANICO' , GETA_mecanico.APELLID0 , GETA_mecanico.CEDULA,
GETA_taller.NOMBRE , GETA_taller.TELEFONO,GETA_taller.CORREO ,GETA_taller.CORREO
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
end
 exec factura 105
GO
/****** Object:  StoredProcedure [dbo].[proceso_factura1]    Script Date: 7/4/2022 11:43:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proceso_factura1] (@id_cliente float)
AS
begin
	SELECT GETA_cliente.NOMBRE, GETA_cliente.APELLIDO , GETA_cliente.TELEFONO, GETA_cliente.DIRECCION,
GETA_vehiculo.MATRICULA,GETA_vehiculo.MODELO,GETA_vehiculo.COLOR ,
GETA_mecanico.NOMBRE as 'NOMBRE MECANICO' , GETA_mecanico.APELLID0 , GETA_mecanico.CEDULA,
GETA_taller.NOMBRE , GETA_taller.TELEFONO,GETA_taller.CORREO ,GETA_taller.CORREO
FROM GETA_factura
join GETA_taller on GETA_taller.id_taller = GETA_factura.id_taller
join GETA_mecanico on  GETA_mecanico.id_mecanico = GETA_factura.id_mecanico
join GETA_vehiculo on GETA_vehiculo.id_vehiculo = GETA_factura.id_vehiculo
join GETA_cliente on GETA_factura.id_cliente = GETA_factura.id_cliente
end
 exec proceso_factura1 105
GO
USE [master]
GO
ALTER DATABASE [GETA_taller] SET  READ_WRITE 
GO

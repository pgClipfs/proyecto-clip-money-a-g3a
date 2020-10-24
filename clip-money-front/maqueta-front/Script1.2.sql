USE clipmoney_testing;


CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[dni] [char](8) NULL,
	[cuenta] [varchar](30) NULL,
	[contraseña] [varchar](20) NULL,
	[edad] [tinyint] NULL,
	[domicilio] [varchar](20) NULL,
	[fecha_registro] [date] NULL
	PRIMARY KEY (id_usuario)
)

CREATE TABLE [dbo].[Cuenta](
	[id_cuenta] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] UNIQUE  NOT NULL,
	[usuario_cvu] [varchar](30) NULL,
	[saldo] [money] NULL,
	[tipo] [varchar](15) NULL,
	[nro_cuenta] [int] NULL,
	PRIMARY KEY (id_cuenta),
	FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
)



CREATE TABLE [dbo].[Operacion](
	[id_operacion] [int] UNIQUE IDENTITY(1 ,1) NOT NULL,
	[id_cuenta] [int] UNIQUE NOT NULL,
	[tipo] [varchar](15) NULL,
	[estado] [varchar](10) NULL,
	[fecha] [date] NULL,
    [Descripcion] [varchar](100)
	PRIMARY KEY (id_operacion),
	FOREIGN KEY (id_cuenta) REFERENCES Cuenta(id_cuenta)	
)

CREATE TABLE [dbo].[Pagos](
	[id_pago] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[id_operacion] [int] UNIQUE NOT NULL,
	[monto] [money] NULL,
	[fecha] [date] NULL,
	[tipo] [varchar](20) NULL, 
	[Estado] [varchar](10) NULL,
	[alias] [varchar](20) NULL,
	[titular] [varchar](30) NULL,
	[cvu] [varchar](30) NULL,
	PRIMARY KEY (id_pago),
	FOREIGN KEY (id_operacion) REFERENCES Operacion(id_operacion)
 
)

CREATE TABLE [dbo].[Factura](
	[Nro_factura] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[monto] [money] NOT NULL,
	[fecha] [date] NOT NULL,
	[fecha_vencimiento] [date] NULL
	PRIMARY KEY (Nro_factura) 
)

CREATE TABLE [dbo].[Servicios](
	[id_servicio] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[Nro_factura] [int] UNIQUE  NOT NULL,
	[monto] [money] NULL,
	[fecha] [date] NULL,
	[fecha_vencimiento] [date] NULL
	PRIMARY KEY (id_servicio)
	FOREIGN KEY (Nro_factura) REFERENCES Factura(Nro_factura)

)

CREATE TABLE [dbo].[Transferencia](
	[id_transferencia] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[id_operacion] [int] UNIQUE NOT NULL,
	[fecha] [date] NOT NULL,
	[cvu_origen] [varchar](30) NOT NULL,
	[cvu_destino] [varchar](30) NULL,
	[cbu_destino] [varchar](30) NULL,
	[monto] [money] NOT NULL
	PRIMARY KEY (id_transferencia),
	FOREIGN KEY (id_operacion) REFERENCES Operacion(id_operacion)

)

CREATE TABLE [dbo].[Inversion](
	[id_inversion] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[id_operacion] [int] UNIQUE NOT NULL,
	[fecha] [date] NULL,
	[monto_capital] [money] NULL,
	[monto_ganancia] [money] NULL
	PRIMARY KEY (id_inversion),
	FOREIGN KEY (id_operacion) REFERENCES Operacion(id_operacion)

)

CREATE TABLE [dbo].[Moneda](
	[id_moneda] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[id_inversion] [int] UNIQUE NOT NULL,
	[tipo] [varchar](20) NULL,
	[valor_actual] [int] NULL
	PRIMARY KEY (id_moneda),
	FOREIGN KEY (id_inversion) REFERENCES Inversion(id_inversion)

) 




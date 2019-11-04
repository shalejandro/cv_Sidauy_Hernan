create DATABASE [TPC_Sidauy]

go

USE [TPC_Sidauy]


GO

CREATE TABLE [dbo].[Pais](
	[idPais] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Pais] [varchar](50) NOT NULL,
 )
 
 go

CREATE TABLE [dbo].[Provincia](
	[idProvincia] [int]  NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Provincia] [varchar](50) NOT NULL,
	[idPais] [int] NOT NULL FOREIGN KEY REFERENCES Pais(idPais)
 )
 
GO

CREATE TABLE [dbo].[Localidad](
	[idLocalidad] [int] NOT NULL primary key,
	[Localidad] [varchar](50) NOT NULL,
	[idProvincia] [int] NOT NULL FOREIGN KEY REFERENCES Provincia(idProvincia),
	estado int not null,
 )

GO


CREATE TABLE [dbo].[Marca](
	[idMarca] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL
)

GO

CREATE TABLE [dbo].[TipoInsumo](
	[idTipo] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[idMarca] [int] NOT NULL FOREIGN KEY REFERENCES Marca(idMarca)
)

GO 

CREATE TABLE [dbo].[TipoPuesto](
			id int not null primary key identity(1,1),
			tipo varchar (50) not null
			)
			
			GO 

CREATE TABLE [dbo].[TipoTurno](
			id int not null primary key identity(1,1),
			tipo varchar (50) not null,
			descripcion varchar (50) not null
			)
	
	GO

CREATE TABLE [dbo].[Interno](
	idinterno int not null primary key identity(1,1),
	[dni] [bigint] NOT NULL,
	[legajo] [int] NOT NULL ,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[cp] [int] NOT NULL FOREIGN KEY REFERENCES Localidad(idLocalidad),
	[usuario] [varchar](50) NOT NULL,
	[clave] [varchar](50) NOT NULL,
	[idPuesto] [int] NOT NULL FOREIGN KEY REFERENCES TipoPuesto(id),
	[sexo] [varchar](50) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[idTurno] int NOT NULL FOREIGN KEY REFERENCES TipoTurno(id),
	[mail] varchar (50) not null,
	estado int not null
 )
 
 go
 
 create table Entrada(
		id int not null identity(1,1),
		descripcion varchar (50) not null,
		pu money not null,
		disponibles int not null,
		primary key (id,descripcion)
		)
		
go
		
create table Bebida(
		id int not null identity(1,1),
		descripcion varchar (50) not null,
		pu money not null,
		disponibles int not null,
		primary key (id,descripcion)
		)
		
go
		
Create table Comida(
		id int not null identity(1,1),
		descripcion varchar (50) not null,
		pu money not null,
		disponibles int not null,
		primary key (id,descripcion)
		)
		
go
		
create table Postre(
		id int not null identity(1,1),
		descripcion varchar (50) not null,
		pu money not null,
		disponibles int not null,
		primary key (id,descripcion)
		)
		
go
		
create table Otros(
		id int not null identity(1,1),
		descripcion varchar (50) not null,
		pu money not null,
		disponibles int not null,
		primary key (id,descripcion)
		)
		
go

CREATE TABLE [dbo].[Proveedor](
	[id] [int] NOT NULL  identity(1,1),
	[cuit] [varchar](50) NOT NULL,
	[nroproveedor] [int] NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[cp] [int] NOT NULL,
	[telefono] [bigint] NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[inicioact] [date] NOT NULL,
	estado int not null,
	primary key (id,cuit,nroproveedor)
	)
	
go
	
create table cliente(
	idCliente int not null identity(1,1),
	dni bigint not null,
	nrocliente int not null,
	apellido varchar(50) not null,
	nombre varchar(50) not null,
	direccion varchar(50) not null,
	telefono bigint not null,
	cp int null,
	mail varchar(50) not null,
	estado int not null,
	primary key (idcliente,dni,nrocliente)
	)
	
go

create table mozoxmesa(
	numeromesa int not null primary key,
	mozoasignado varchar(50) not null
) 

go

create table entradaxmesa(
	id int not null primary key identity (1,1),
	numeropedido int not null,
	descripcion varchar(50) not null,
	pu money not null,
	fecha datetime not null
	)
	
	go
	
create table comidaxmesa(
	id int not null primary key identity (1,1),
	numeropedido int not null,
	descripcion varchar(50) not null,
	pu money not null,
	fecha datetime not null
	)
	
	go
	
create table bebidaxmesa(
	id int not null primary key identity (1,1),
	numeropedido int not null,
	descripcion varchar(50) not null,
	pu money not null,
	fecha datetime not null
	)
	
	go
	
create table postrexmesa(
	id int not null primary key identity (1,1),
	numeropedido int not null,
	descripcion varchar(50) not null,
	pu money not null,
	fecha datetime not null	
	)
	
	go
	
create table otroxmesa(
	id int not null primary key identity (1,1),
	numeropedido int not null,
	descripcion varchar(50) not null,
	pu money not null,
	fecha datetime not null,
	)
	
go
	
create table pedidoxmesa(
	numeropedido int not null identity(1,1),
	numeromesa int not null ,
	cantidadcomenzales int null,
    estado int not null,
    mozoasignado varchar(50) null,
    fechahoraapertura datetime not null,
    fechahoracierre datetime not null,
    total money null,
    totalbebida money null,
    totalcomida money null,
    totalentrada money null,
    totalpostre money null,
    totalotro money null,
    primary key (numeromesa,numeropedido)
    )
	
	go
	
	create table numeromesa(
		numero int not null primary key
		)

go 

create table datosmesa(
	numeromesa int not null primary key,
	mozoasignado varchar(50) not null
	)
	

go 
--drop table totales
go
create table totales(
	id bigint not null primary key identity(1,1),
	numeromesa int not null,
	numeropedido int not null ,
	total int not null,
	totalbebida money not null,
	totalcomida money not null,
	totalentrada money not null,
	totalpostre money not null,
	totalotro money not null
	)
	
go

create table usuariologueado(
	 id int not null primary key identity(1,1),
	 usuario varchar(50) not null,
     clave varchar(50) not null,
     idpuesto int not null,
     nombre varchar(50) not null,
     apellido varchar(50) not null,
     descripcion varchar(50) not null,
     fechahora datetime not null
)	

go

create table reservas(
	idreserva int not null primary key identity(1,1),
	cliente varchar(50) not null,
	fecha datetime not null,
	hora int not null,
	minutos int not null,
	numeromesa int not null,
	mozoasignado varchar(50) null,
	estado int not null
	)
	
-------------
---------------------------------------------------------
----------------------------------------------------------------------

insert into Pais(Pais)
values ('Argentina'),('Brasil'),('Bolivia'),('Peru'),('Uruguay'),('Paraguay')

insert into Provincia(Provincia, idPais)
values ('Buenos Aires',1),('Catamarca',1),('Chaco',1),('Chubut',1),('Cordoba',1),('Corrientes',1),('Entre Rios',1),('Corrientes',1),('Formosa',1),('Jujuy',1),('La Pampa',1),('La Rioja',1),('Mendoza',1),('Misiones',1),('Neuquen',1),('Rio Negro',1),('Salta',1),('San Juan',1),('San Luis',1),('Santa Cruz',1),('Santa Fe',1),('Santiago del Estero',1),('Tierra del Fuego',1),('Tucuman',1)

insert into Localidad(idLocalidad, Localidad, idProvincia,estado)
values (1625,'Escobar',1,1),(1627,'Pilar',1,1),(1630,'San Fernando',1,1)

insert into TipoPuesto(tipo)
values ('Administrador'),('Cajero/a'),('Mozo/a'),('Seguridad'),('Limpieza')

insert into TipoTurno(tipo,descripcion)
values ('Mañana','6 a 14 hs'),('Tarde','14 a 22 hs'),('Cortado','8 a 12hs / 17 a 22hs'),('Corrido','8 a 17 hs'),('Relevo','Personalizado')

insert into Interno(dni,legajo,nombre,apellido,direccion,cp,usuario,clave,idpuesto,sexo, fechaNacimiento,idTurno,mail,estado)
values (24938014,1920,'Hernan','Sidauy','Asborno 865',1625,'Admin','Admin',1,'Hombre','11-10-1975',1,'shalejandro@hotmail.com',1),(32658497,1258,'Maria','Perez','9 de Julio 1202',1627,'moza','moza',3,'Mujer','02-04-1987',3,'mariajosefa@gmail.com',1),(22587965,1945,'Juan','Pelota','Orquideas 334',1630,'mozo','mozo',3,'Hombre','2-3-1987',2,'PedroPedro@yahoo.com',1),(25487828,1658,'Raul','Mareco','Neuquen 988',1627,'cajero','cajero',2,'Hombre','11-10-1970',3,'SarmientoXXX@gmail.com',1),(29348788,1660,'Selene','Rosales','Almafuerte 588',1630,'cajera','cajera',2,'Mujer','11-10-1970',3,'lascamelias23@yahoo.com.ar',1)

insert into Marca(Descripcion)
values ('COCACOLA'),('PEPSI'),('VILLAVICENCIO'),('VILLADELSUR'),('TERMIDOR'),('SANCOR'),('CRESPI'),('LASERENISIMA'),('KELLOGS')

insert into TipoInsumo(descripcion,idMarca)
values ('GASEOSA COLA 2LTS ',1),('GASEOSA COLA 1,25LTS',1),('GASEOSA COLA 600CC',1),('GASEOSA LIGHT COLA 2LTS',1),
		('GASEOSA LIGHT COLA 1,25LTS',1),('GASEOSA LIMA LIMÓN 2LTS',2),('GASEOSA LIMA LIMÓN 1,25LTS',2),('GASEOSA LIGHT LIMA LIMÓN 2LTS',2),('GASEOSA LIGHT LIMA LIMÓN 1,25LTS',1)

insert into entrada(descripcion,pu,disponibles)
values ('Entrada 1',20,100),('Entrada 2',10,100),('Entrada 3',35,100),('Entrada 4',50,100),('Entrada 5',17,100),('Entrada 6',20,100)

insert into bebida(descripcion,pu,disponibles)
values ('Bebida 1',20,100),('Bebida 2',10,100),('Bebida 3',35,100),('Bebida 4',50,100),('Bebida 5',17,100),('Bebida 6',20,100)

insert into comida(descripcion,pu,disponibles)
values ('Comida 1',20,100),('Comida 2',10,100),('Comida 3',35,100),('Comida 4',50,100),('Comida 5',17,100),('Comida 6',20,100)

insert into postre(descripcion,pu,disponibles)
values ('Postre 1',20,100),('Postre 2',10,100),('Postre 3',35,100),('Postre 4',50,100),('Postre 5',17,100),('Postre 6',20,100)

insert into otros(descripcion,pu,disponibles)
values ('Otros 1',20,100),('Otros 2',10,100),('Otros 3',35,100),('Otros 4',50,100),('Otros 5',17,100),('Otros 6',20,100)
		
insert into cliente(dni,nrocliente,apellido,nombre,direccion,telefono,cp,mail,estado)
values (32765698,0001,'Seara','Carla','Asborno 865',3484338438,1625,'carchizzo@hotmail.com',1),(27536271,0002,'Ramirez','Raul','San Juan 1065',1154586598,1627,'Ramirez_Raul@hotmail.com',1)

insert into numeromesa(numero)
values (1),(2),(3),(4),(5),(6),(7),(8),(9),(10),(11),(12),(13),(14),(15),(16),(17),(18),(19),(20)

insert into mozoxmesa(numeromesa,mozoasignado)
values (1,'Sin Mozo'),(2,'Sin Mozo'),(3,'Sin Mozo'),(4,'Sin Mozo'),(5,'Sin Mozo'),(6,'Sin Mozo'),(7,'Sin Mozo'),(8,'Sin Mozo'),(9,'Sin Mozo'),(10,'Sin Mozo'),
(11,'Sin Mozo'),(12,'Sin Mozo'),(13,'Sin Mozo'),(14,'Sin Mozo'),(15,'Sin Mozo'),(16,'Sin Mozo'),(17,'Sin Mozo'),(18,'Sin Mozo'),(19,'Sin Mozo'),(20,'Sin Mozo')

go

------------------------------------------------------
------------------------------------------------------
--  STOREDPROCEDURE ----------------------------------
------------------------------------------------------
------------------------------------------------------

create procedure sp_mesa_agregar(
@numeromesa int,
@mozoasignado varchar(50),
@estado int

)
as
begin
	insert into mesa(numeromesa,mozoasignado,estado) 
	values (@numeromesa,@mozoasignado,@estado)
end

go 

create procedure sp_descontar_insumo_entrada( -- descuenta insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Entrada set disponibles=disponibles-1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_descontar_insumo_bebida( -- descuenta insumo
@id int,
@descripcion varchar (50)
)
as
begin
	update Bebida set disponibles=disponibles-1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_descontar_insumo_comida( -- descuenta insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Comida set disponibles=disponibles-1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_descontar_insumo_postre( -- descuenta insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Postre set disponibles=disponibles-1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_descontar_insumo_otros( -- descuenta insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Otros set disponibles=disponibles-1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_agregar_insumo_entrada( -- agrega insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Entrada set disponibles=disponibles+1 where id=@id and descripcion=@descripcion
end

go
----------------------------------------------------------------------------
create procedure sp_agregar_insumo_bebida( -- agrega insumo
@id int,
@descripcion varchar (50)
)
as
begin
	update Bebida set disponibles=disponibles+1 where id=@id and descripcion=@descripcion
end
---------------------------------------------------------------------------
go

create procedure sp_agregar_insumo_comida( -- agrega insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Comida set disponibles=disponibles+1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_agregar_insumo_postre( -- agrega insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Postre set disponibles=disponibles+1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_agregar_insumo_otros( -- agrega insumo
@id int,
@descripcion varchar(50)
)
as
begin
	update Otros set disponibles=disponibles+1 where id=@id and descripcion=@descripcion
end

go

create procedure sp_guardar_mozoxmesa( -- deja guardado el mozo asignado a la mesa
@numeromesa int,
@mozoasignado varchar(50)
)
as
begin
	insert into mozoxmesa(numeromesa,mozoasignado)
	values (@numeromesa,@mozoasignado)
end

go

create procedure sp_actualizar_mozoxmesa(
@numeromesa int,
@mozoasignado varchar(50)
)
as
begin
	update mozoxmesa set mozoasignado=@mozoasignado where numeromesa=@numeromesa
	update pedidoxmesa set mozoasignado=@mozoasignado where numeromesa=@numeromesa
end
  
 

 
 
go

create procedure sp_quitar_mozoxmesa 
(
@numeromesa int
)
as
begin
	delete from mozoxmesa where numeromesa=@numeromesa
end


go 

create procedure sp_leer_mesas --para borrar
as
begin
	select * from numeromesa
end

go

create procedure sp_quitar_mesa -- elimina mesa del combo para quitar disponibilidad
@numero int
as
begin
	delete from numeromesa where numero=@numero
end

go 

create procedure sp_agregar_mesa -- agrega mesa cuando que a sido eliminada con anterioridad
@numero int
as
begin

	declare @esta int
	
	if not exists (select numero from numeromesa where numero=@numero)
		begin
			insert into numeromesa(numero) values(@numero)
		end	
end

go

create procedure sp_cargar_mesas --elimina tabla y la crea cargando los numeros de mesa
as
begin
	drop table numeromesa
	create table numeromesa(
		numero int not null primary key
		)
	insert into numeromesa(numero)
values (1),(2),(3),(4),(5),(6),(7),(8),(9),(10),(11),(12),(13),(14),(15),(16),(17),(18),(19),(20)
end

go

create procedure sp_limpiar_mozoxmesa 
as
begin
	drop table mozoxmesa
	create table mozoxmesa(
	numeromesa int not null primary key,
	mozoasignado varchar(50) not null
) 
end

go

create procedure sp_datos_mesas_guardar  --en caso de cerrar ventana accidental se guarda el estado de la mesa
@numeromesa int,
@mozoasignado varchar(50)
as
begin
	insert into datosmesa(numeromesa,mozoasignado)
	values(@numeromesa,@mozoasignado)
end

go

create procedure sp_limpiar_datos_mesa  -- borra estado de mesas de la tabla de seguridad
as
begin
	drop table datosmesa
	create table datosmesa(
	numeromesa int not null primary key,
	mozoasignado varchar(50) not null
	)
end

go

create procedure sp_alta_mesa( -- procedimiento para el alta de la mesa, solo guarda registros iniciales
@numeromesa int,
@cantidadcomenzales int,
@estado int,
@mozoasignado varchar (50)
)
as
begin
		declare @estado_actual int
		select @estado_actual=estado from pedidoxmesa where numeromesa=@numeromesa
		if (@estado_actual=0)
		begin
			update pedidoxmesa set mozoasignado=@mozoasignado where numeromesa=@numeromesa
		end
		else
			insert into pedidoxmesa(numeromesa,cantidadcomenzales,estado,mozoasignado,fechahoraapertura,fechahoracierre)
			values (@numeromesa,@cantidadcomenzales,@estado,@mozoasignado,GETDATE(),GETDATE())
end

go

create procedure sp_agregar_mozoamesa( -- agrega mozo a pedidoxmesa cuando se da de alta el pedido
@numeromesa int,
@mozoasignado varchar(50)
)
as
begin
	update pedidoxmesa set mozoasignado=@mozoasignado where numeromesa=@numeromesa
end

go 

/*create procedure sp_baja_mesa( -- procedimiento para la baja de la mesa, boton VACIAR
@numeromesa int
)
as
begin
	delete from pedidoxmesa where numeromesa=@numeromesa and estado=1
end*/

go 

create procedure sp_leer_numero_mesa(
@numeromesa int
)
as
begin
	select numeropedido from pedidoxmesa where numeromesa=@numeromesa and estado=1
end

go 

create procedure sp_guardar_comenzales(
@cantidadcomenzales int,
@numeromesa int,
@numeropedido int
)
as
begin
	update pedidoxmesa set cantidadcomenzales=@cantidadcomenzales where numeromesa=@numeromesa and numeropedido=@numeropedido
end

go 

create procedure sp_guardar_totales(
@numeromesa int,
@numeropedido int,
@total money,
@totalbebida money,
@totalcomida money,
@totalentrada money,
@totalpostre money,
@totalotro money
)
as
begin
	insert into totales (total, totalbebida,totalcomida,totalentrada,totalpostre,totalotro,numeromesa,numeropedido)
	values(@total ,@totalbebida,@totalcomida,@totalentrada,@totalpostre,@totalotro,@numeromesa,@numeropedido)
end

go

create procedure sp_iniciar_totales(  --inicia los totales de la tabla en 0  --POR BORRAR
@numeromesa int
)
as
begin
	insert into totales(numeromesa,numeropedido,total,totalbebida,totalcomida,totalentrada,totalotro,totalpostre)
	values (@numeromesa,0,0,0,0,0,0,0)
end

go 

create procedure sp_limpiar_totales --limpia al inicio cualquier total guardado anteriormente
as
begin
	drop table totales
create table totales(
id bigint not null primary key identity(1,1),
	numeromesa int not null,
	numeropedido int not null ,
	total int not null,
	totalbebida money not null,
	totalcomida money not null,
	totalentrada money not null,
	totalpostre money not null,
	totalotro money not null
	)
end
  
go

create procedure sp_agregar_datos_insumos_entrada(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	insert into entradaxmesa(descripcion,pu,numeropedido,fecha)
	values (@descripcion,@pu,@numeropedido,@fecha)	
end

go

create procedure sp_agregar_datos_insumos_bebida(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	insert into bebidaxmesa(descripcion,pu,numeropedido,fecha)
	values (@descripcion,@pu,@numeropedido,@fecha)	
end

go

create procedure sp_agregar_datos_insumos_comida(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	insert into comidaxmesa(descripcion,pu,numeropedido,fecha)
	values (@descripcion,@pu,@numeropedido,@fecha)	
end

go

create procedure sp_agregar_datos_insumos_postre(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	insert into postrexmesa(descripcion,pu,numeropedido,fecha)
	values (@descripcion,@pu,@numeropedido,@fecha)	
end

go

create procedure sp_agregar_datos_insumos_otro(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	insert into otroxmesa(descripcion,pu,numeropedido,fecha)
	values (@descripcion,@pu,@numeropedido,@fecha)	
end

go

create procedure sp_quitar_datos_insumos_entrada(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	delete from entradaxmesa where descripcion=@descripcion and numeropedido=@numeropedido
end

go
-----------------------------------------------------------
create procedure sp_quitar_datos_insumos_bebida(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	delete from bebidaxmesa where descripcion=@descripcion and numeropedido=@numeropedido
end
--------------------------------------------------------------
go

create procedure sp_quitar_datos_insumos_comida(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	delete from comidaxmesa where descripcion=@descripcion and numeropedido=@numeropedido
end

go

create procedure sp_quitar_datos_insumos_postre(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	delete from postrexmesa where descripcion=@descripcion and numeropedido=@numeropedido
end

go

create procedure sp_quitar_datos_insumos_otro(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@fecha datetime
) 
as
begin
	delete from otroxmesa where descripcion=@descripcion and numeropedido=@numeropedido
end

go

create procedure sp_insumoseleccionado_entradas(
@descripcion varchar(50),
@pu money,
@numeropedido int
)
as
begin
	begin tran 
		update Entrada set disponibles=disponibles-1 where descripcion=@descripcion
		insert into entradaxmesa (descripcion,numeropedido,pu,fecha)
		values(@descripcion,@numeropedido,@pu,GETDATE())
	commit
end

go

create procedure sp_insumoseleccionado_comidas(
@descripcion varchar(50),
@pu money,
@numeropedido int
)
as
begin
	begin tran 
		update Comida set disponibles=disponibles-1 where descripcion=@descripcion
		insert into comidaxmesa (descripcion,numeropedido,pu,fecha)
		values(@descripcion,@numeropedido,@pu,GETDATE())
	commit
end

go

create procedure sp_insumoseleccionado_bebidas(
@descripcion varchar(50),
@pu money,
@numeropedido int
)
as
begin
	begin tran 
		update Bebida set disponibles=disponibles-1 where descripcion=@descripcion
		insert into bebidaxmesa (descripcion,numeropedido,pu,fecha)
		values(@descripcion,@numeropedido,@pu,GETDATE())
	commit
end

go

create procedure sp_insumoseleccionado_postres(
@descripcion varchar(50),
@pu money,
@numeropedido int
)
as
begin
	begin tran 
		update Postre set disponibles=disponibles-1 where descripcion=@descripcion
		insert into postrexmesa (descripcion,numeropedido,pu,fecha)
		values(@descripcion,@numeropedido,@pu,GETDATE())
	commit
end

go

create procedure sp_insumoseleccionado_otros(
@descripcion varchar(50),
@pu money,
@numeropedido int
)
as
begin
	begin tran 
		update Otros set disponibles=disponibles-1 where descripcion=@descripcion
		insert into otroxmesa (descripcion,numeropedido,pu,fecha)
		values(@descripcion,@numeropedido,@pu,GETDATE())
	commit
end

go

create procedure sp_insumosDeseleccionado_entradas(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@id int
)
as
begin
	begin tran 
		update Entrada set disponibles=disponibles+1 where descripcion=@descripcion
		delete from entradaxmesa where descripcion=@descripcion and id=@id
	commit
end

go

create procedure sp_insumosDeseleccionado_bebidas(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@id int
)
as
begin
	begin tran 
		update Bebida set disponibles=disponibles+1 where descripcion=@descripcion
		delete from bebidaxmesa where descripcion=@descripcion and id=@id
	commit
end

go

create procedure sp_insumosDeseleccionado_comidas(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@id int
)
as
begin
	begin tran 
		update Comida set disponibles=disponibles+1 where descripcion=@descripcion
		delete from comidaxmesa where descripcion=@descripcion and id=@id
	commit
end

go

create procedure sp_insumosDeseleccionado_postres(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@id int
)
as
begin
	begin tran 
		update Postre set disponibles=disponibles+1 where descripcion=@descripcion
		delete from postrexmesa where descripcion=@descripcion and id=@id
	commit
end

go

create procedure sp_insumosDeseleccionado_otros(
@descripcion varchar(50),
@pu money,
@numeropedido int,
@id int
)
as
begin
	begin tran 
		update Otros set disponibles=disponibles+1 where descripcion=@descripcion
		delete from otroxmesa where descripcion=@descripcion and id=@id
	commit
end

go

create procedure sp_iniciar_mesas
as
begin
	insert into pedidoxmesa(numeromesa,estado,mozoasignado)
	values (1,0,'sinmozo'),(2,0,'sinmozo'),(3,0,'sinmozo'),(4,0,'sinmozo'),(5,0,'sinmozo'),(6,0,'sinmozo'),(7,0,'sinmozo'),
	(8,0,'sinmozo'),(9,0,'sinmozo'),(10,0,'sinmozo'),(11,0,'sinmozo'),(12,0,'sinmozo'),(13,0,'sinmozo'),(14,0,'sinmozo'),
	(15,0,'sinmozo'),(16,0,'sinmozo'),(17,0,'sinmozo'),(18,0,'sinmozo'),(19,0,'sinmozo'),(20,0,'sinmozo')
end

go

create procedure sp_cerrar_mesa(  -- deja asignado el mozo al cambiar a estado 2 la mesa
@numeromesa int,
@numeropedido int
)
as 
begin
	declare @mozoasignado varchar(50)
	select @mozoasignado=mozoasignado from pedidoxmesa where numeromesa=@numeromesa and numeropedido=@numeropedido
	update pedidoxmesa set estado=2, fechahoracierre=getdate() where numeromesa=@numeromesa and numeropedido=@numeropedido
	insert into pedidoxmesa (cantidadcomenzales,mozoasignado,estado,numeromesa,fechahoraapertura,fechahoracierre) values (0,@mozoasignado,0,@numeromesa,GETDATE(),GETDATE())
end

go 

create procedure sp_cancelar_mesa(  -- deja asignado el mozo al cambiar a estado 2 la mesa
@numeromesa int,
@numeropedido int
)
as 
begin
	declare @mozoasignado varchar(50)
	select @mozoasignado=mozoasignado from pedidoxmesa where numeromesa=@numeromesa and numeropedido=@numeropedido
	update pedidoxmesa set estado=3, fechahoracierre=getdate() where numeromesa=@numeromesa and numeropedido=@numeropedido
	insert into pedidoxmesa (cantidadcomenzales,mozoasignado,estado,numeromesa,fechahoraapertura,fechahoracierre) values (0,@mozoasignado,0,@numeromesa,GETDATE(),GETDATE())
end

go

create procedure sp_devolver_insumo_bebida(
@id int,
@descripcion varchar(50),
@numeromesa int,
@numeropedido int
)
as
begin
	begin try
		begin transaction
			delete from bebidaxmesa where id=@id and numeropedido=@numeropedido and descripcion=@descripcion
			update Bebida set disponibles=disponibles+1 where descripcion=@descripcion
		commit transaction
	end try
	begin catch
		rollback transaction
		raiserror('No se realizo la transaccion',16,1)
	end catch
end

go

create procedure sp_devolver_insumo_comida(
@id int,
@descripcion varchar(50),
@numeromesa int,
@numeropedido int
)
as
begin
	begin try
		begin transaction
			delete from comidaxmesa where id=@id and numeropedido=@numeropedido and descripcion=@descripcion
			update Comida set disponibles=disponibles+1 where descripcion=@descripcion
		commit transaction
	end try
	begin catch
		rollback transaction
		raiserror('No se realizo la transaccion',16,1)
	end catch
end

go

create procedure sp_devolver_insumo_entrada(
@id int,
@descripcion varchar(50),
@numeromesa int,
@numeropedido int
)
as
begin
	begin try
		begin transaction
			delete from entradaxmesa where id=@id and numeropedido=@numeropedido and descripcion=@descripcion
			update Entrada set disponibles=disponibles+1 where descripcion=@descripcion
		commit transaction
	end try
	begin catch
		rollback transaction
		raiserror('No se realizo la transaccion',16,1)
	end catch
end

go

create procedure sp_devolver_insumo_postre(
@id int,
@descripcion varchar(50),
@numeromesa int,
@numeropedido int
)
as
begin
	begin try
		begin transaction
			delete from postrexmesa where id=@id and numeropedido=@numeropedido and descripcion=@descripcion
			update Postre set disponibles=disponibles+1 where descripcion=@descripcion
		commit transaction
	end try
	begin catch
		rollback transaction
		raiserror('No se realizo la transaccion',16,1)
	end catch
end

go

create procedure sp_devolver_insumo_otro(
@id int,
@descripcion varchar(50),
@numeromesa int,
@numeropedido int
)
as
begin
	begin try
		begin transaction
			delete from otroxmesa where id=@id and numeropedido=@numeropedido and descripcion=@descripcion
			update Otro set disponibles=disponibles+1 where descripcion=@descripcion
		commit transaction
	end try
	begin catch
		rollback transaction
		raiserror('No se realizo la transaccion',16,1)
	end catch
end

go

create procedure sp_usuario_logueado(
@usuario varchar(50),
@clave varchar(50),
@idpuesto int,
@nombre varchar(50),
@apellido varchar(50),
@descripcion varchar(50)
)
as
begin
	insert into usuariologueado(usuario,clave,idpuesto,nombre,apellido,descripcion,fechahora)
	values (@usuario,@clave,@idpuesto,@nombre,@apellido,@descripcion,GETDATE())
end

go

create procedure sp_agregar_cp(
@idlocalidad int,
@localidad varchar(50),
@idprovincia int
)
as
begin
	begin try
		begin transaction
			insert into Localidad (idLocalidad,Localidad,idProvincia,estado)
			values (@idlocalidad,@localidad,@idprovincia,1)
		commit transaction
	end try
	begin catch
		rollback transaction
		raiserror('No se pudo realizar el agregado',16,1)
	end catch
end

 go
 
 create trigger tr_agregar_mozo on mozoxmesa 
 after update
 as
 begin
	begin try
		begin transaction
			declare @numeromesa int
			declare @mozoasignado varchar(50)
			select @numeromesa=numeromesa,@mozoasignado=mozoasignado from inserted
			update pedidoxmesa set mozoasignado=@mozoasignado where numeromesa=@numeromesa and estado=1
		commit transaction
	end try
	begin catch
		rollback transaction
		raiserror('No se realizo la transaccion',16,1)
	end catch 
 end
 
 go
 
-- create view vw_ventas_dia
 -- as	select numeromesa,numeropedido,cantidadcomenzales,mozoasignado,fechahoraapertura,fechahoracierre from pedidoxmesa where estado=0 and day(GETDATE())=DAY(fechahoraapertura) and month(GETDATE())=MONTH(fechahoraapertura) and year(GETDATE())=YEAR(fechahoraapertura);
 
 create procedure sp_pasar_totales_tabla_mesa(
 @numeropedido int,
 @numeromesa int,
 @total money,
 @totalbebida money,
 @totalcomida money,
 @totalentrada money,
 @totalpostre money,
 @totalotro money
 )
 as
 begin
	update pedidoxmesa set total=@total,  totalbebida=@totalbebida, totalcomida=@totalcomida,totalpostre=@totalpostre, totalotro=@totalotro, totalentrada=@totalentrada where numeromesa=@numeromesa and numeropedido=@numeropedido
 end
 
 go
 
 create procedure sp_guardarReserva(
 @cliente varchar(50),
 @fecha datetime,
 @hora int,
 @minutos int,
 @numeromesa int,
 @mozoasignado varchar(50)
 )
 as
 begin
	insert into reservas (cliente,fecha,hora,minutos,numeromesa,mozoasignado,estado)
	values (@cliente,@fecha,@hora,@minutos,@numeromesa,@mozoasignado,1)
 end
 
 go
 
 create procedure sp_cancelar_reserva(
 @idreserva int,
 @motivo int
 )
 as
 begin
	update reservas set estado=@motivo where idreserva=@idreserva
 end
 
 --select * from pedidoxmesa
 
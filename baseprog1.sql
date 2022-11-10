create database BD_PROG
-----INSERTAR UNA O DOS FACTURAS ANTES DE EJECUTAR EN VISUAL
use BD_PROG

begin /* CREAR BASE DE DATOS */

	create table tipos_documentos
	(id_tipo_doc int identity(1,1), 
	tipo_doc varchar(50),
	constraint pk_tipo_doc primary key (id_tipo_doc) 
	)

	create table tipos_clientes
	(id_tipo_cliente int identity(1,1), 
	nombre varchar(50),
	constraint pk_tipo_cliente primary key (id_tipo_cliente) 
	)

	create table provincias
	(id_provincia int identity(1,1), 
	nombre varchar(100),
	constraint pk_provincia primary key (id_provincia) 
	)

	create table localidades
	(id_localidad int identity(1,1), 
	nombre varchar(100),
	id_provincia int
	constraint pk_localidad primary key (id_localidad),
	constraint fk_localidad_provincia foreign key (id_provincia)
	references provincias(id_provincia) 
	)

	create table barrios
	(id_barrio int identity(1,1), 
	nombre varchar(100),
	id_localidad int
	constraint pk_barrio primary key (id_barrio),
	constraint fk_barrio_localidad foreign key (id_localidad)
	references localidades(id_localidad) 
	)

	create table medios_de_pedido
	(id_medio_pedido int identity(1,1), 
	medio_pedido varchar(100)
	constraint pk_medio_de_pedido primary key (id_medio_pedido)
	)

	create table formas_de_pago
	(id_forma_pago int identity(1,1), 
	forma_pago varchar(100)
	constraint pk_forma_de_pago primary key (id_forma_pago)
	)

	create table formas_de_entrega
	(id_forma_entrega int identity(1,1), 
	forma_entrega varchar(100)
	constraint pk_forma_de_entrega primary key (id_forma_entrega)
	)

	create table productos
	(id_producto int identity(1,1), 
	descripcion varchar (100),
	precio_unitario money,
	constraint pk_producto primary key (id_producto),
	)

	create table vendedores
	(id_vendedor int identity(1,1), 
	nombre_completo varchar(100),
	calle varchar(100),
	altura int,
	telefono int,
	id_barrio int,
	id_tipo_doc int,
	nro_doc bigint
	constraint pk_vendedor primary key (id_vendedor),
	constraint fk_vendedor_barrio foreign key (id_barrio)
	references barrios(id_barrio),
	constraint fk_vendedor_tipo_doc foreign key (id_tipo_doc)
	references tipos_documentos(id_tipo_doc)
	)

	create table clientes
	(id_cliente int identity(1,1), 
	nombre_completo varchar(100),
	calle varchar(100),
	altura int,
	telefono int,
	id_tipo_cliente int,
	id_barrio int,
	id_tipo_doc int,
	nro_doc bigint
	constraint pk_cliente primary key (id_cliente),
	constraint fk_cliente_tipo_cliente foreign key (id_tipo_cliente)
	references tipos_clientes(id_tipo_cliente),
	constraint fk_cliente_barrio foreign key (id_barrio)
	references barrios(id_barrio),
	constraint fk_cliente_tipo_doc foreign key (id_tipo_doc)
	references tipos_documentos(id_tipo_doc)
	)

	create table facturas
	(nro_factura int identity(1,1), 
	fecha date,
	id_vendedor int,
	id_cliente int,
	id_forma_entrega int,
	id_medio_pedido int,
	id_forma_pago int,
	total money,
	constraint pk_factura primary key (nro_factura),
	constraint fk_factura_vendedor foreign key (id_vendedor)
	references vendedores(id_vendedor),
	constraint fk_factura_cliente foreign key (id_cliente)
	references clientes(id_cliente),
	constraint fk_factura_forma_entrega foreign key (id_forma_entrega)
	references formas_de_entrega(id_forma_entrega),
	constraint fk_factura_medio_pedido foreign key (id_medio_pedido)
	references medios_de_pedido(id_medio_pedido),
	constraint fk_factura_forma_pago foreign key (id_forma_pago)
	references formas_de_pago(id_forma_pago)
	)

	create table detalles_facturas
	(id_detalle_factura int identity(1,1), 
	cantidad smallint,
	nro_factura int, 
	id_producto int,
	constraint pk_detalle_factura primary key (id_detalle_factura),
	constraint fk_detalle_factura_factura  foreign key (nro_factura)
	references facturas(nro_factura),
	constraint fk_detalle_factura_producto foreign key (id_producto)
	references productos(id_producto)
	)
	create table Logins
	(id_login int identity,
	usuario varchar(100),
	contrasenia varchar(100)
	constraint pk_Login primary key (id_login)
	)
end

begin /* INSERTS DE DATOS */
	--PROVINCIAS
	insert into provincias(nombre)
	values
	('Buenos Aires'),
	('Córdoba'),
	('Entre Rios'),
	('Mendoza'),
	('Santa Fe')

	--LOGIN
	insert into Logins(usuario, contrasenia)
	values
	('admin', 'admin')

	-- LOCALIDADES
	insert into localidades(nombre, id_provincia)
	values
	('Ayacucho', 1),
	('La Plata', 1),
	('Bahia Blanca',1),
	('Cordoba Capital',2),
	('Rio ceballos',2),
	('Villa Carlos Paz',2),
	('Gualeguaychu',3),
	('Concordia',3),
	('Chajari',3),
	('Godoy Cruz',4),
	('Las Heras',4),
	('Mendoza Capital',4),
	('Rosario',5),
	('Sunchales',5),
	('Santa Fe Capital',5)

	-- BARRIOS
	insert into barrios(nombre,id_localidad)
	values
	('El Progreso',1),
	('La feria',1),
	('Altos de san lorenzo',2),
	('City Bell',2),
	('Barrio Universitario',3),
	('Don Ramiro',3),
	('Jardin',4),
	('Centro',4),
	('El caracol',5),
	('Nuevo Rio Ceballos',5),
	('Villa Suiza',6),
	('Villa del lago',6),
	('Urquiza',7),
	('Irazusta',7),
	('Villa adela',8),
	('Las Tejas',8),
	('Tacuabe',9),
	('Paso Chajari',9),
	('Sarmiento',10),
	('Bicentenario',10),
	('Democracia',11),
	('Soler',11),
	('Microcentro',12),
	('Civico',12),
	('Las Malvinas',13),
	('Latinoamerica',13),
	('Cooperativo',14),
	('Moreno',14),
	('Belgrano',15),
	('Siete Jefes',15)

	-- TIPOS DE CLIENTES
	insert into tipos_clientes (nombre)
	values 
	('Consumidor Final'),
	('Empresa'),
	('Concesionario'),
	('Vendedora de autopartes')

	-- TIPOS DE DOCUMENTOS
	insert into tipos_documentos (tipo_doc)
	values 
	('DNI'),
	('CUIL'),
	('CUIT'),
	('Pasaporte')

	-- CONTACTOS

	--FORMAS DE PAGO
	insert into formas_de_pago (forma_pago)
	values 
	('Efectivo'),
	('Transferencia'),
	('Debito'),
	('Credito'),
	('Cheque')

	-- MEDIOS DE PEDIDO
	insert into medios_de_pedido (medio_pedido)
	values 
	('Email'),
	('Telefono'),
	('Pagina web'),
	('Promotor'),
	('Concesionaria')

	-- FORMAS DE ENTREGA
	insert into formas_de_entrega (forma_entrega)
	values ('A domicilio'),
	('Retiro por concesionaria')

	-- VENDEDORES
	insert into vendedores (nombre_completo, calle, altura, telefono ,id_barrio, id_tipo_doc, nro_doc) 
	values 
	('Julian Gomez', 'Ituzaingó', 484, 35124884, 8, 1, 34545982),
	('Alvaro Martinez', 'Mariano Fragueiro', 1901,153214545, 8, 1, 40983146),
	('Marcelo Lopez', 'Roland Ross', 7434, 248522254, 8, 1, 26741390),
	('Alex Martins', 'Rivadavia', 467, 2644552, 8, 1, 18406719),
	('Matias Rodriguez', 'Catamarca', 50, 121288223, 8, 1, 39451768)

	-- CLIENTES
	insert into clientes (nombre_completo, calle, altura, id_tipo_cliente, telefono, id_barrio, id_tipo_doc, nro_doc)
	values 
	('Julian Gomez', 'Ituzaingó', 484, 1, 33541221, 1, 3, 345459),
	('Maipu Sa', 'Mariano Fragueiro', 1906, 3, 53332548, 5, 3, 20098),
	('Marcelo Lopez', 'Roland Ross', 7434, 1, 55992332, 3, 1, 26741390),
	('Candelaria Gonzales', 'Rivadavia', 467, 4, 6693321, 4, 3, 27184067),
	('Matias Rodriguez', 'Catamarca', 50, 1, 99833214, 4, 1, 39451768),
	('Sofia Rojas', 'Lima', 27,  1, 3512632, 4, 1, 11298746),
	('Paula Lopez', 'San Juan', 829, 1, 566321, 5, 1, 32156780),
	('Lucia Torres', 'Ruben Dario', 3548, 3, 351288,6, 3, 2726945),
	('Autoportes Mayor','San Martín', 144, 2, 33359984,3,3,3058448),
	('Pablo Martinez','Salta', 1250, 1, 5557634,1, 2, 32457811),
	('Federica Romero','La Madrid', 815, 4, 343452532,3,3,2753350),
	('Santiago Martin','27 de Abril', 3162, 2,3123214,4,3,2732781),
	('Carla Sesmilo','El Vergel', 162, 4,3124123,12,3,273545201),
	('Esteban Ramiro','Dean Funes', 1962, 2, 545242,3,3,201455),
	('Repuestos Martinez','San Rafael Funes', 581, 2,4322552,3,3,35896)


	-- VEHICULOS 
	insert into productos(descripcion, precio_unitario) 
	values 
	('Peugeot 207',2100000),
	('Peugeot 208',4000000),
	('Peugeot 3008',5800000),
	('Renault Clio',2500000),
	('Renault Sandero',3000000),
	('Renault Logan',3200000),
	('Fiat Palio',3500000),
	('Fiat Cronos',4000000),
	('Fiat Argo',3000000),
	('Ford Fiesta',3500000),
	('Ford Focus',4000000),
	('Ford Ka',2500000),
	('Chevrolet Corsa',2000000),
	('Chevrolet Onix',3500000),
	('Chevrolet Cruze',4000000)

	-- AUTOPARTES
	insert into productos(descripcion, precio_unitario) 
	values 
	('Nuematicos Peugeot',45000),
	('Carroceria Peugeot',85000),
	('Motor Peugeot',45000),
	('Tablero Peugeot',55000),
	('Asientos Peugeot',75000),
	('Radiador Peugeot',100000),
	('Puertas Peugeot',85000),
	('Suspension Peugeot',60000),
	('Baterias Peugeot',30000),
	('Opticas Peugeot',15000),

	('Nuematicos Renault',35000),
	('Carroceria Renault',95000),
	('Motor Renault',112000),
	('Tablero Renault',6000),
	('Asientos Renault',87000),
	('Radiador Renault',120000),
	('Puertas Renault',60000),
	('Suspension Renault',80000),
	('Baterias Renault',35000),
	('Opticas Renault',14000),

	('Nuematicos Fiat',55000),
	('Carroceria Fiat',75000),
	('Motor Fiat',130000),
	('Tablero Fiat',54000),
	('Asientos Fiat',78000),
	('Radiador Fiat',103000),
	('Puertas Fiat',74000),
	('Suspension Fiat',58000),
	('Baterias Fiat',28000),
	('Opticas Fiat',13000),

	('Nuematicos Ford',57000),
	('Carroceria Ford',71000),
	('Motor Ford',127000),
	('Tablero Ford',59000),
	('Asientos Ford',73000),
	('Radiador Ford',107000),
	('Puertas Ford',64000),
	('Suspension Ford',69000),
	('Baterias Ford',24000),
	('Opticas Ford',17000),

	('Nuematicos Chevrolet',51000),
	('Carroceria Chevrolet',1000),
	('Motor Chevrolet',115000),
	('Tablero Chevrolet',63000),
	('Asientos Chevrolet',53000),
	('Radiador Chevrolet',117000),
	('Puertas Chevrolet',57000),
	('Suspension Chevrolet',71000),
	('Baterias Chevrolet',29000),
	('Opticas Chevrolet',9000),

	('Nuematicos Nissan',70000),
	('Carroceria Nissan',90000),
	('Motor Nissan',179000),
	('Tablero Nissan',80000),
	('Asientos Nissan',63000),
	('Radiador Nissan',220000),
	('Puertas Nissan',60000),
	('Suspension Nissan',82000),
	('Baterias Nissan',40000),
	('Opticas Nissan',12000)

	-- FACTURAS
	set dateformat dmy
	insert into facturas (fecha, id_vendedor, id_cliente, id_forma_entrega, id_medio_pedido, id_forma_pago, total)
	values 
	('03/05/2022', 1, 1, 2, 1, 2, 6999),
	('15/12/2022', 2, 2, 1, 5, 5, 6000)
	
	--DETALLES DE FACTURAS
	insert into detalles_facturas(nro_factura, cantidad,id_producto)
	values (1,200,33),(2,100, 2)

end

----------------------------------------------------------------------------------------------------------
create procedure cargarVendedor
as
select * from vendedores

----------------------------------------------------------------------------------------------------------
create procedure cargarCliente
as
select * from clientes

----------------------------------------------------------------------------------------------------------
create procedure cargarForma_Entrega
as
select * from formas_de_entrega

----------------------------------------------------------------------------------------------------------
create procedure cargarMedio_Pedido
as
select * from medios_de_pedido

----------------------------------------------------------------------------------------------------------
create procedure cargarForma_Pago
as
select * from formas_de_pago

----------------------------------------------------------------------------------------------------------
create procedure cargarProducto
as
select * from productos

----------------------------------------------------------------------------------------------------------
create procedure cargarBarrios
as
select * from barrios

----------------------------------------------------------------------------------------------------------
create procedure tipoCliente
as
select * from tipos_clientes

----------------------------------------------------------------------------------------------------------
create procedure cargarTipoDoc
as
select * from tipos_documentos

----------------------------------------------------------------------------------------------------------
create procedure insertCliente
@nombre varchar(40),
@calle varchar(30),
@altura int,
@telefono int,
@tipocliente int,
@idbarrio int,
@tipodoc int,
@nrodoc int
as
insert into clientes (nombre_completo, calle, altura, telefono, id_tipo_cliente, id_barrio, id_tipo_doc, nro_doc)
values (@nombre, @calle, @altura, @telefono, @tipocliente, @idbarrio, @tipodoc, @nrodoc)

----------------------------------------------------------------------------------------------------------
create procedure insert_Factura
@fecha date,
@cod_vendedor int,
@cod_cliente int,
@forma_entrega int,
@forma_pedido int,
@forma_pago int,
@total money,
@id int output
as
insert into facturas (fecha, id_vendedor, id_cliente, id_forma_entrega, id_medio_pedido, id_forma_pago, total)
values (@fecha, @cod_vendedor, @cod_cliente, @forma_entrega, @forma_pedido, @forma_pago, @total);
set @id = SCOPE_IDENTITY();

----------------------------------------------------------------------------------------------------------
create procedure insert_Detalle
@cantidad int,
@cod_producto int,
@nro_factura int
as
insert into detalles_facturas (cantidad, nro_factura, id_producto)
values (@cantidad, @nro_factura, @cod_producto)

----------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ProximaFactura
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(nro_factura)+1  FROM facturas);
END

----------------------------------------------------------------------------------------------------------
create procedure insertProducto
@nombre varchar(30),
@precio money
as
insert into productos (descripcion, precio_unitario)
values (@nombre, @precio)

----------------------------------------------------------------------------------------------------------
create procedure consultaFactura
as
select nro_factura, fecha, id_vendedor, nombre_completo, id_forma_entrega, id_medio_pedido, id_forma_pago, total
from facturas f join clientes c on f.id_cliente = c.id_cliente

----------------------------------------------------------------------------------------------------------
create procedure detalleFactura
@nrofactura int
as
select d.*,c.nombre_completo,f.id_vendedor, id_forma_entrega, id_medio_pedido, id_forma_pago, fecha,
descripcion, precio_unitario  from detalles_facturas d join productos p
on d.id_producto=p.id_producto join facturas f
on f.nro_factura=d.nro_factura join clientes c on f.id_cliente=c.id_cliente join vendedores v
on v.id_vendedor=f.id_vendedor where d.nro_factura = @nrofactura

----------------------------------------------------------------------------------------------------------
create procedure facturaIndividual
@nrofactura int
as
select f.nro_factura, fecha, id_vendedor, id_cliente, id_forma_entrega, id_medio_pedido, id_forma_pago, d.id_producto, descripcion,
precio_unitario, cantidad
from facturas f join detalles_facturas d on f.nro_factura=d.nro_factura join productos p on p.id_producto=d.id_producto
where f.nro_factura = @nrofactura

----------------------------------------------------------------------------------------------------------
create procedure eliminarProducto
@idproducto int
as
delete from productos
where id_producto = @idproducto

----------------------------------------------------------------------------------------------------------
create procedure eliminarCliente
@idcliente int
as
delete from clientes
where id_cliente = @idcliente

----------------------------------------------------------------------------------------------------------
create procedure editarCliente
@idcliente int,
@telefono int,
@calle varchar(30),
@altura int
as
update clientes
set telefono = @telefono, calle=@calle, altura=@altura where id_cliente = @idcliente

----------------------------------------------------------------------------------------------------------
create procedure editarProducto
@idproducto int,
@precio money
as
update productos
set precio_unitario = @precio where id_producto = @idproducto

----------------------------------------------------------------------------------------------------------
create procedure SP_USUARIOS
as
select * from logins

----------------------------------------------------------------------------------------------------------
create procedure updateFactura
@nrofactura int,
@formaentrega int
as
update facturas
set id_forma_entrega = @formaentrega where
nro_factura = @nrofactura

----------------------------------------------------------------------------------------------------------
create procedure deleteFactura
@nrofactura int
as
begin

delete from detalles_facturas
where nro_factura = @nrofactura

delete from facturas
where nro_factura = @nrofactura

end

----------------------------------------------------------------------------------------------------------
create procedure reporteProductos
@nombre varchar (30)
as
select * from productos where descripcion like @nombre + '%'

----------------------------------------------------------------------------------------------------------
create procedure reporteFacturas
@fecha1 datetime,
@fecha2 datetime
as
select fecha, c.nombre_completo Cliente, v.nombre_completo Vendedor, forma_entrega, total from facturas f join clientes c on f.id_cliente=c.id_cliente join
vendedores v on f.id_vendedor=v.id_vendedor join formas_de_entrega e on f.id_forma_entrega=e.id_forma_entrega
where fecha between @fecha1 and @fecha2

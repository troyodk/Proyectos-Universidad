create database TiendaExamen
go
use TiendaExamen
go

create table Proveedores(
id_Proveedor int Primary Key,
nombre_prov nvarchar (50),
direccion_prov nvarchar (50),
telefono_prov nvarchar (11) 
)

create table Clientes(
id_Cliente int Primary Key,
nombre_cliente nvarchar (50),
direccion_cliente nvarchar (50),
telefono_cliente nvarchar (11)
)

create table Categorias(
id_Categoria int Primary Key,
descripcion_categoria nvarchar(100)
)

create table Facturas(
id_Factura int Primary key,
fecha nvarchar(10),
id_Cliente int

constraint fk_id_Cliente foreign Key (id_Cliente)
references Clientes (id_Cliente)
)

create table Producto(
id_Producto int primary key,
nombre_producto nvarchar(20),
descripcion nvarchar (100),
precio float,
id_Categoria int,
id_Proveedor int

constraint fk_id_Categoria foreign Key (id_Categoria)
references Categorias (id_Categoria),

constraint fk_id_Proveedor foreign Key (id_Proveedor)
references Proveedores (id_Proveedor)
)

create table Ventas(
id_Ventas int primary key,
id_Factura int,
id_Producto int,
cantidad int,

constraint fk_id_factura foreign key (id_Factura)
references Facturas (id_Factura),

constraint fk_id_Producto foreign Key (id_producto)
references Producto (id_Producto)
)

insert into Proveedores 
values(1,'Toshiba Electronics','Santa Fe-CDMX',5559638214)
insert into Proveedores 
values(2,'Microsoft','Redley Ca.-USA',9652103658)
insert into Proveedores 
values(3,'HP','Monterrey NL-Nuevo Leon',8125469674)
insert into Proveedores 
values(4,'Sony','Leon-Guanajuato',4771408520)
insert into Proveedores 
values(5,'Kingston','Guadalajara-GDL-Jalisco ',3328547896)

insert into Categorias
values (1,'Laptops')
insert into Categorias
values (2,'Dispositivo de Entrada')
insert into Categorias
values (3,'Dispositivo de Entrada')
insert into Categorias
values (4,'Monitores')
insert into Categorias
values (5,'Almacenamiento')

insert into Clientes
values (1,'Jorge Lopez','Pastor Ortiz, Mich',5584705609)
insert into Clientes
values (2,'Uriel Morales','El Cantador, Gto',5584705609)
insert into Clientes
values (3,'Erick Troyo','San Javier, Gto',5584705609)
insert into Clientes
values (4,'Juanin Garcia','Puentecillas, Gto',5584705609)
insert into Clientes
values (5,'Hector Diaz','Dos Rios, Gto',5584705609)

insert into Producto 
values (1,'Laptor Toshiba','Procesador IntelCorei9 8GbRAM',29599.99,1,1)
insert into Producto 
values (2,'Teclado Mecanico','Modelo 2019 Windows10',525.00,2,3)
insert into Producto 
values (3,'Mouse Inalambrico','Modelo 2019 White Windows10',200.00,3,2)
insert into Producto 
values (4,'Monitor Sony','15in Black AmoledDisplay',1500.00,4,5)
insert into Producto 
values (5,'Hard Drive SD','2TB',4499.99,5,4)


insert into Facturas
values(1,'04-02-2019',1)
insert into Facturas
values(2,'04-02-2019',2)
insert into Facturas
values(3,'04-02-2019',3)
insert into Facturas
values(4,'04-02-2019',4)
insert into Facturas
values(5,'04-02-2019',5)

insert into Ventas
values(1,1,2,5)
insert into Ventas
values(2,2,3,3)
insert into Ventas
values(3,5,4,7)
insert into Ventas
values(4,4,3,1)
insert into Ventas
values(5,1,5,2)


----------------------------
--Ejemplos de consultas--- Se necesita saber el diseño del leguaje huesped para las consultas
--consulta sobre proveedores y los productos que venden cada uno   
select producto.id_producto as "#",producto.nombre as "Nombre",proveedores.id_proveedor as "#",proveedores.nombre as "Nom proveedor" 
from producto inner join proveedores on proveedores.id_proveedor= producto.id_proveedores

--Productos por categoria
select producto.id_producto as "#",producto.nombre as "Nombre",categoria.id_categoria as "#",categoria.categoria as "Nom proveedor" 
from producto inner join categorias on producto.id_categoria =categoria.id_categoria

--Productos que superen $1000
select producto.id_producto as "#",producto.nombre as "Nombre" where producto.precio>1000

--------------------------------
--Procedures -- Tipo CRUD -- Para cada tabla(si, me odio)

--Tabla Producto
--Agregar
use TiendaExamen
go
create procedure SP_insertar_producto
@id_Producto integer,
@nombre_Producto nvarchar(20),
@descripcion nvarchar(100),
@precio float,
@id_Categoria int,
@id_Proveedor int
as 
insert into Producto(id_Producto,nombre_producto,descripcion,precio,id_Categoria,id_Proveedor) 
values(@id_Producto,@nombre_Producto,@descripcion,@precio,@id_Categoria,@id_Proveedor)
go
--Editar
create procedure SP_editar_producto
@id_Producto integer,
@nombre_Producto nvarchar(20),
@descripcion nvarchar(100),
@precio float,
@id_Categoria int,
@id_Proveedor int
as
update Producto set id_Producto=@id_Producto, nombre_producto=@nombre_Producto,descripcion=@descripcion,precio=@precio,id_Categoria=@id_Categoria,id_Proveedor=@id_Proveedor
where id_Producto= @id_Producto
go
--Eliminar
create procedure SP_eliminar_producto
@id_Producto integer 
as 
delete from Producto where id_Producto = @id_Producto
go

--Tabla Proveedores
--Agregar
use TiendaExamen
go
create procedure SP_insertar_proveedores
@id_Proveedor integer,
@nombre_Prov nvarchar(50),
@direccion_prov nvarchar(50),
@telefono_prov nvarchar(11)
as 
insert into Proveedores(id_Proveedor,nombre_prov,direccion_prov,telefono_prov) 
values(@id_Proveedor,@nombre_Prov,@direccion_prov,@telefono_prov)
go

--Editar
create procedure SP_editar_proveedores
@id_Proveedor integer,
@nombre_Prov nvarchar(50),
@direccion_prov nvarchar(50),
@telefono_prov nvarchar(11)
as
update Proveedores set id_Proveedor=@id_Proveedor,nombre_prov=@nombre_Prov,direccion_prov=@direccion_prov,telefono_prov=@telefono_prov
where id_Proveedor= @id_Proveedor
go
--Eliminar
create procedure SP_eliminar_proveedores
@id_Proveedor integer 
as 
delete from Proveedores where id_Proveedor = @id_Proveedor
go

--Tabla Categorias
--Agregar
use TiendaExamen
go
create procedure SP_insertar_categorias
@id_Categoria integer,
@descripcion_categoria nvarchar(100)
as 
insert into Categorias(id_Categoria,descripcion_categoria) 
values(@id_Categoria,@descripcion_categoria)
go

--Editar
create procedure SP_editar_categorias
@id_Categoria integer,
@descripcion_categoria nvarchar(100)
as
update Categorias set id_Categoria=@id_Categoria,descripcion_categoria=@descripcion_categoria
where id_Categoria= @id_Categoria
go

--Eliminar
create procedure SP_eliminar_categorias
@id_Categoria integer 
as 
delete from Categorias where id_Categoria = @id_Categoria
go


--Tabla Clientes
--Agregar
use TiendaExamen
go
create procedure SP_insertar_cliente
@id_Cliente integer,
@nombre_cliente nvarchar(50),
@direccion_cliente nvarchar(50),
@telefono_cliente nvarchar(11)
as 
insert into Clientes(id_Cliente,nombre_cliente,direccion_cliente,telefono_cliente) 
values(@id_Cliente,@nombre_cliente,@direccion_cliente,@telefono_cliente)
go

--Editar
create procedure SP_editar_cliente
@id_Cliente integer,
@nombre_cliente nvarchar(50),
@direccion_cliente nvarchar(50),
@telefono_cliente nvarchar(11)
as
update Clientes set id_Cliente=@id_Cliente,nombre_cliente=@nombre_cliente,direccion_cliente=@direccion_cliente,telefono_cliente=@telefono_cliente
where id_Cliente= @id_Cliente
go

--Eliminar
create procedure SP_eliminar_cliente
@id_Cliente integer 
as 
delete from Clientes where id_Cliente = @id_Cliente
go

--Tabla Ventas
--Agregar
use TiendaExamen
go
create procedure SP_insertar_ventas
@id_Ventas integer,
@id_Factura integer,
@id_Producto integer,
@cantidad integer
as 
insert into Ventas(id_Ventas,id_Factura,id_Producto,cantidad) 
values(@id_Ventas,@id_Factura,@id_Producto,@cantidad)
go

--Editar
create procedure SP_editar_ventas
@id_Ventas integer,
@id_Factura integer,
@id_Producto integer,
@cantidad integer
as
update Ventas set id_Ventas=@id_Ventas,id_Factura=@id_Factura,id_Producto=@id_Producto,cantidad=@cantidad
where id_Ventas= @id_Ventas
go

--Eliminar
create procedure SP_eliminar_ventas
@id_Ventas integer 
as 
delete from Ventas where id_Ventas = @id_Ventas
go

--Tabla Facturas
--Agregar
use TiendaExamen
go
create procedure SP_insertar_facturas
@id_Factura integer,
@fecha nvarchar(10),
@id_Cliente integer
as 
insert into Facturas(id_Factura,fecha,id_Cliente) 
values(@id_Factura,@fecha,@id_Cliente)
go

--Editar
create procedure SP_editar_facturas
@id_Factura integer,
@fecha nvarchar(10),
@id_Cliente integer
as
update Facturas set id_Factura=@id_Factura,fecha=@fecha,id_Cliente=@id_Cliente
where id_Factura= @id_Factura
go

--Eliminar
create procedure SP_eliminar_facturas
@id_Factura integer 
as 
delete from Facturas where id_Factura = @id_Factura
go

--clientes
select Producto.precio as 'Mas Caro' from Producto where Producto.precio>4000

select Producto.precio as 'Mas Barato' from Producto where Producto.precio>200 and Producto.precio<1000

select producto.id_producto as 'Num Producto',producto.nombre_producto as Nombre,Categorias.id_Categoria as 'Num Categoria',Producto.id_Proveedor as 'Num proveedor' 
from producto inner join categorias on producto.id_categoria = Producto.id_categoria where Categorias.id_Categoria = 1

select Producto.nombre_producto as 'Nombre Producto', Producto.descripcion as Descripcion, Producto.precio as Precio from Producto

select Producto.id_Proveedor as 'Num Proveedor', Producto.nombre_producto as 'Nombre Producto',Producto.precio as Precio,Producto.id_Proveedor as 'Num Proveedor',
Proveedores.nombre_prov from Producto inner join Proveedores on Proveedores.nombre_prov=Proveedores.nombre_prov where Producto.id_Proveedor=1


--------------------------------------------------------------
--precedures de consulta para visual

use TiendaExamen
go
create procedure consultC1
as
select nombre_producto,MAX(precio) as 'Mas Caro' from Producto group by nombre_producto, precio order by precio desc
go

create procedure consultC2
as
select Producto.nombre_producto as 'Nombre del Producto',Producto.precio as 'Precio', Proveedores.nombre_prov as 'Marca/Proveedor' from Producto inner join Proveedores on Proveedores.id_Proveedor = Producto.id_Proveedor
go

create procedure consultC3
as
select nombre_producto as 'Nombre del Producto', descripcion as 'Descripcion' from Producto
go

create procedure consultC4
as
select nombre_producto as 'Nombre del Producto', categorias.descripcion_categoria as 'Categoria' from Producto inner join categorias on Producto.id_Categoria=categorias.id_Categoria
go

create procedure consultC5
@valor integer 
as
select nombre_producto,precio from Producto where precio < @valor
go

create procedure consultA1
as
select Proveedores.id_Proveedor as 'Num Proveedor', Proveedores.nombre_prov as 'Nombre Proveedor', Proveedores.direccion_prov as 'Direccion del Proveedor',Proveedores.telefono_prov as 'Tel Proveedor' from Proveedores order by Proveedores.nombre_prov
go

create procedure consultA2
as
select Clientes.id_Cliente as 'Num Cliente', Clientes.nombre_cliente as 'Nombre Cliente', Clientes.direccion_cliente as 'Direccion Cliente', Clientes.telefono_cliente as 'Tel Cliente', Facturas.id_Factura as 'Num Factura' from Clientes inner join Facturas on Facturas.id_Factura = 1
go

create procedure consultA3
as
select Ventas.id_Ventas as 'Num Venta', Ventas.id_Producto as 'Num Producto', Ventas.cantidad as 'Productos Vendidos', Producto.nombre_producto as 'Nombre Producto' from Ventas inner join Producto on Producto.nombre_producto = Producto.nombre_producto where Ventas.cantidad > 3
go

create procedure consultA4
as
select Producto.id_Producto as 'Num Producto',Producto.nombre_producto as 'Nombre Producto',Proveedores.id_Proveedor as 'Num Proveedor',Proveedores.nombre_prov as 'Nom proveedor' from Producto inner join Proveedores on Proveedores.id_Proveedor = Producto.id_Proveedor
go

create procedure consultA5
as
select Facturas.id_Factura as 'Num Factura', Facturas.fecha as 'Fecha de Factura', Clientes.nombre_cliente as 'Nombre Cliente' from Facturas inner join Clientes on Clientes.nombre_cliente = Clientes.nombre_cliente where Facturas.id_Factura = 1
go

create procedure consultA6
as
select Clientes.nombre_cliente as 'Nombre Cliente', Clientes.direccion_cliente as 'Direccion Cliente', Clientes.telefono_cliente as 'Telefono Cliente', Producto.precio as 'Precio del Producto' from Clientes inner join Producto on Producto.precio > 5000
go

create procedure consultA7
as
select Categorias.id_Categoria as 'Num Categoria', Categorias.descripcion_categoria as 'Descripcion' from Categorias
go






create database TiendaExamen
go
use TiendaExamen
go

create table Proveedores(
id_Proveedor int identity Primary Key,
nombre_prov nvarchar (50),
direccion_prov nvarchar (50),
telefono_prov nvarchar (11) 
)

create table Clientes(
id_Cliente int identity Primary Key,
nombre_cliente nvarchar (50),
direccion_cliente nvarchar (50),
telefono_cliente nvarchar (11)
)

create table Categorias(
id_Categoria int identity Primary Key,
descripcion_categoria nvarchar(100)
)

create table Facturas(
id_Factura int identity Primary key,
fecha datetime,
id_Cliente int

constraint fk_id_Cliente foreign Key (id_Cliente)
references Clientes (id_Cliente)
)

create table Producto(
id_Producto int identity primary key,
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
id_Ventas int identity primary key,
id_Factura int,
id_Producto int,
cantidad int,

constraint fk_id_factura foreign key (id_Factura)
references Facturas (id_Factura),

constraint fk_id_Producto foreign Key (id_producto)
references Producto (id_Producto)
)

insert into Proveedores 
values('Toshiba Electronics','Santa Fe-CDMX',5559638214)
insert into Proveedores 
values('Microsoft','Redley Ca.-USA',9652103658)
insert into Proveedores 
values('HP','Monterrey NL-Nuevo Leon',8125469674)
insert into Proveedores 
values('Sony','Leon-Guanajuato',4771408520)
insert into Proveedores 
values('Kingston','Guadalajara-GDL-Jalisco ',3328547896)

insert into Categorias
values ('Laptops')
insert into Categorias
values ('Dispositivo de Entrada')
insert into Categorias
values ('Dispositivo de Entrada')
insert into Categorias
values ('Monitores')
insert into Categorias
values ('Almacenamiento')

insert into Clientes
values ('Jorge Lopez','Pastor Ortiz, Mich',5584705609)
insert into Clientes
values ('Uriel Morales','El Cantador, Gto',5584705609)
insert into Clientes
values ('Erick Troyo','San Javier, Gto',5584705609)
insert into Clientes
values ('Juanin Garcia','Puentecillas, Gto',5584705609)
insert into Clientes
values ('Hector Diaz','Dos Rios, Gto',5584705609)

insert into Producto 
values ('Laptor Toshiba','Procesador IntelCorei9 8GbRAM',29599.99,1,1)
insert into Producto 
values ('Teclado Mecanico','Modelo 2019 Windows10',525.00,2,3)
insert into Producto 
values ('Mouse Inalambrico','Modelo 2019 White Windows10',200.00,3,2)
insert into Producto 
values ('Monitor Sony','15in Black AmoledDisplay',1500.00,4,5)
insert into Producto 
values ('Hard Drive SD','2TB',4499.99,5,4)


insert into Facturas
values('04-02-2019',1)
insert into Facturas
values('04-02-2019',2)
insert into Facturas
values('04-02-2019',3)
insert into Facturas
values('04-02-2019',4)
insert into Facturas
values('04-02-2019',5)

select * from Clientes

insert into Ventas
values(1,2,5)
insert into Ventas
values(2,3,3)
insert into Ventas
values(5,4,7)
insert into Ventas
values(4,3,1)
insert into Ventas
values(1,5,2)


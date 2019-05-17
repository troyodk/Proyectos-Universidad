create database TiendaExamen
use TiendaExamen

create table Ventas(
id_Ventas int identity primary key,
id_Factura int,
id_Producto int,
cantidad int

constraint fk_id_factura foreign key (Facturas)
references id_Factura (Ventas)

constraint fk_id_Producto foreign Key (Productos)
references id_Producto (Productos)
)

create table Facturas(
id_Factura int identity Primary key,
fecha date,
id_Cliente int

constraint fk_id_Cliente foreign Key (Clientes)
references id_Cliente (Facturas)
)

create table Clientes(
id_Cliente int identity Primary Key,
nombre_cliente nvarchar (20),
direccion nvarchar (50),
telefono_cliente int
)
create table Producto(
id_Producto int identity primary key,
nombre_producto nvarchar(20),
descripcion nvarchar (100),
precio float,
id_Categoria int,
id_Proveedor int
)

create table Proveedores(
id_Proveedoes int identity Primary Key,
nombre_prov nvarchar (20),
direccion nvarchar (50),
telefono_prov int

constraint fk_id_Proveedores (Producto)
references id_Proveedores (Proveedores)
)

create table Categorias(
id_Categoria int identity Primary Key,
descripcion_categoria nvarchar(100)

constraint fk_id_Categorias (Producto)
references id_Categorias (Categoria)
)

insert into Producto 
values ('Laptor Toshiba','Procesador IntelCorei9 8GbRAM',29599.99,52410,546430)
insert into Producto 
values ('Teclado Mecanico','Modelo 2019 Windows10',525.00,25010,69603)
insert into Producto 
values ('Mouse Inalambrico','Modelo 2019 White Windows10',200.00,527880,250430)
insert into Producto 
values ('Monitor Sony','15in Black AmoledDisplay',1500.00,41410,546430)
insert into Producto 
values ('Hard Drive SD','2TB',4499.99,52410,546430)

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

insert into Facturas
values(04-02-2019)
insert into Facturas
values(04-02-2019)
insert into Facturas
values(04-02-2019)
insert into Facturas
values(04-02-2019)
insert into Facturas
values(04-02-2019)

insert into Ventas
values(5)
insert into Ventas
values(3)
insert into Ventas
values(7)
insert into Ventas
values(1)
insert into Ventas
values(2)

insert into Proveedores 
values('Toshiba Electronics Co.','Santa Fe, CDMX',5559638214)
insert into Proveedores 
values('Microsoft','Redley Ca. USA',9652103658)
insert into Proveedores 
values('HP','Monterrey NL, Nuevo Leon',8125469674)
insert into Proveedores 
values('Sony','Leon, Guanajuato',4771408520)
insert into Proveedores 
values('Kingston','Guadalajara,GDL,Jalisco ',3328547896)

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
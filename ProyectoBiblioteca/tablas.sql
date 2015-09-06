Create database Biblioteca

create table t_categoria 
(
	id int not null identity,
	nombre varchar (100) not null
)

create table t_autor
(
	id int not null identity,
	nombre varchar (100) not null
)

create table t_editorial
(
	id int not null identity,
	nombre varchar (100) not null
)

create table t_clientes
(
	id int not null identity,
	nombre varchar (100) not null,
	telefono varchar (9) not null,
	email varchar (50) not null
)

create table t_usuarios
(
	id int not null identity,
	usuario varchar (100) not null,
	contraseña varchar (100)not null
)

create table t_libros
(
	id int not null identity,
	isbn int not null,
	nombre varchar(100) not null,
	id_categoria int not null,
	id_autor int not null,
	id_editorial int not null,
)

create table t_prestamos 
(
	id_libro int not null,
	id_cliente int not null,
	fecha_prestamo datetime,
	fecha_devolucion datetime
)


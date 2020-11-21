create database PuntoVentaProyectoFinal

use PuntoVentaProyectoFinal

--Tabla usuarios
create table Usuarios(
	id_usuario int not null IDENTITY(1,1) primary key,
	usuario varchar(50) not null unique,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	pass varchar(50) not null
)

--Tabla categoria producto
create table categoriaProductos(
	idCategoria int IDENTITY(1,1) primary key,
	nombreCategoria varchar(50) not null
)


--Tabla productos
create table productos(
	idProducto int not null IDENTITY(1,1) primary key,
	nombreProducto varchar(50) not null,
	idCategoria int FOREIGN KEY REFERENCES categoriaProductos (idCategoria),
	stock int not null,
	precio DECIMAL(38, 2)
)

--Tabla clientes
create table clientes(
	idClientes int not null IDENTITY(1,1) primary key,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	direccion varchar(50),
	fechaAgregado date
)

--Tabla venta
create table ventas(
    idventa int not null primary key,
	fecha date,
	idcliente int FOREIGN KEY REFERENCES clientes (idClientes),
	idusuario int FOREIGN KEY REFERENCES Usuarios (id_usuario),    
)

CREATE TABLE detalle_ventas(
	id int not null IDENTITY(1,1) primary key,
	cantidad int,
	precio DECIMAL(38, 2),
	idProducto int FOREIGN KEY REFERENCES productos (idProducto),	
	idventa int FOREIGN KEY REFERENCES ventas(idventa)
)


create procedure agregarProductos(@nombre varchar(50),@stock int,@precioProducto float,@idCategoria int)
as
begin
	insert into productos(nombreProducto,idCategoria,stock,precio) values(@nombre,@idCategoria,@stock,@precioProducto)
end


create procedure editarProductos(@id int,@nombre varchar(50),@stock int,@precioProducto float,@idCategoria int)
as
begin
	update productos set nombreProducto = @nombre, idCategoria = @idCategoria,  stock = @stock, precio = @precioProducto
	where idProducto = @id
end

create procedure agregarVentaProducto(@idventa int, @idproducto int,@canti int,@precio float)
as
begin

		insert into detalle_ventas values(@canti,@precio,@idproducto,@idventa)

		declare @cantidadAnterior int
		declare @cantidadFinal int

		set @cantidadAnterior = (select stock from productos where idProducto = @idproducto)

		set @cantidadFinal = @cantidadAnterior - @canti
		update productos set stock = @cantidadFinal where idProducto = @idproducto

end


--Agregar clientes
create procedure agregarClientes(@nombre varchar(50),@apellido varchar(50),@direccion varchar(100))
as 
begin
	insert into clientes values(@nombre,@apellido,@direccion,convert(date,GETDATE()))
end


--Editar clientes
create procedure editarClientes(@idcliente int, @nombre varchar(50),@apellido varchar(50),@direccion varchar(100))
as 
begin
	update clientes set nombre = @nombre, apellido = @apellido, direccion = @direccion where idClientes = @idcliente
end


---
create procedure crearUsuarios(@usuario varchar(50), @nombre varchar(50),@apellido varchar(50),@pass varchar(75))
as
begin
	insert into Usuarios values(@usuario, @nombre, @apellido, @pass)
end


----
create procedure editarUsuarios(@id int, @usuario varchar(50), @nombre varchar(50),@apellido varchar(50),@pass varchar(75))
as
begin
	update Usuarios set usuario = @usuario, nombre = @nombre, apellido = @apellido, pass = @pass
	where id_usuario = @id
end

create procedure crearCategorias(@nombreCategoria varchar(100))
as
begin
	insert into categoriaProductos values(@nombreCategoria)
end

create procedure editarCategorias(@id int,@nombreCategoria varchar(100))
as
begin
	update categoriaProductos set nombreCategoria = @nombreCategoria
	where idCategoria = @id
end

create procedure sp_DetalleVenta
as
begin
	select v.idventa as 'ID',v.fecha as 'Fecha',c.nombre + ' ' + c.apellido as 'Cliente',u.nombre as 'Vendedor',
	sum(dv.cantidad * dv.precio) as 'Total' from ventas as v
	inner join detalle_ventas as dv on dv.idventa = v.idventa
	inner join clientes as c on c.idClientes = v.idcliente
	inner join Usuarios as u on u.id_usuario = v.idusuario
	group by v.idventa,v.fecha,c.nombre,u.nombre,c.apellido
end


create procedure sp_DetalleVentaFiltrada(@nombre varchar(100))
as
begin
	select v.idventa as 'ID',v.fecha as 'Fecha',c.nombre + ' ' + c.apellido as 'Cliente',u.nombre as 'Vendedor',
	sum(dv.cantidad * dv.precio) as 'Total' from ventas as v
	inner join detalle_ventas as dv on dv.idventa = v.idventa
	inner join clientes as c on c.idClientes = v.idcliente
	inner join Usuarios as u on u.id_usuario = v.idusuario
	where c.nombre + ' ' + c.apellido = @nombre or c.nombre = @nombre 
	group by v.idventa,v.fecha,c.nombre,u.nombre,c.apellido
end


select v.idventa as 'ID Venta',v.fecha as 'Fecha',c.nombre + ' ' + c.apellido as 'Cliente',u.nombre as 'Vendedor',sum(dv.cantidad * dv.precio) as 'Total' from ventas as v
inner join detalle_ventas as dv on dv.idventa = v.idventa
inner join clientes as c on c.idClientes = v.idcliente
inner join Usuarios as u on u.id_usuario = v.idusuario
group by v.idventa,v.fecha,c.nombre,u.nombre,c.apellido

create procedure imprimirFactura(@idVenta int)
as
begin 
	select c.nombre + ' ' + c.apellido as 'Cliente',
	u.nombre + ' ' + u.apellido as 'Vendedor',
		v.fecha,
		p.nombreProducto,
		dv.cantidad,
		p.precio,
		(dv.cantidad *	dv.precio) as 'Total'
		from ventas as v
		inner join detalle_ventas as dv on dv.idventa = v.idventa
		inner join clientes as c on c.idClientes = v.idcliente
		inner join productos as p on p.idProducto = dv.idProducto
		inner join Usuarios as u on u.id_usuario = v.idusuario
		where v.idventa = @idVenta
end

select c.nombre + ' ' + c.apellido as 'Cliente',
	u.nombre + ' ' + u.apellido as 'Vendedor',
		v.fecha,
		p.nombreProducto,
		dv.cantidad,
		p.precio,
		(dv.cantidad *	dv.precio) as 'Total'
		from ventas as v
		inner join detalle_ventas as dv on dv.idventa = v.idventa
		inner join clientes as c on c.idClientes = v.idcliente
		inner join productos as p on p.idProducto = dv.idProducto
		inner join Usuarios as u on u.id_usuario = v.idusuario
		where v.idventa =2


create procedure reporteProductosMasVendidos
as
begin
	select p.idProducto as 'Codigo',p.nombreProducto as 'Producto',
	c.nombreCategoria as 'Categoria', sum(dv.cantidad) as 'Ventas' from productos as p
	inner join detalle_ventas as dv on dv.idProducto = p.idProducto
	inner join productos as pr on pr.idProducto = dv.idProducto
	inner join categoriaProductos as c on c.idCategoria = pr.idCategoria
	group by p.idProducto,p.nombreProducto,c.nombreCategoria,dv.idProducto
end

create procedure reporteINventario
as
begin	
	select p.idProducto as 'Codigo',p.nombreProducto as 'Producto',c.nombreCategoria as 'Categoria',
	p.stock as 'Stock',p.precio as 'Precio',(p.stock * p.precio) as 'Total' from productos as p
	inner join categoriaProductos as c on c.idCategoria = p.idCategoria
end
exec reporteINventario

create procedure reporteInicioVenta
as
begin
	select sum(dv.cantidad * dv.precio) 'TotalVentas' from ventas as v
	inner join detalle_ventas as dv on dv.idventa = v.idventa
end

--Total clientes
select COUNT(*) from clientes

create procedure reporteInicioIventario
as
begin
	select  sum(p.stock * p.precio) as 'total' from productos as p 
end
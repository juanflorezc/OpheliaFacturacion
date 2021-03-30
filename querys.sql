--Obtener la lista de precios de todos los productos
Select * from Producto;

--Obtener la lista de productos cuya existencia en el inventario haya llegado al mínimo permitido (5 unidades)
select DISTINCT p.*,i.cantidadActual
from Producto p
inner join Inventario i on i.productoId=p.productoId
where cantidadActual<=5;

--Obtener una lista de clientes no mayores de 35 años que hayan realizado compras entre el 1 de febrero de 2000 y el 25 de mayo de 2000
Select c.* from
Cliente c
inner join factura f on f.clienteId=c.clienteId
where (f.fechaCompra>='2020-02-01' and f.fechaCompra<='2020-05-25')
and c.fechaNacimiento>'1985-03-30'

--Obtener el valor total vendido por cada producto en el año 2000

--Obtener la última fecha de compra de un cliente y según su frecuencia de compra estimar en qué fecha podría volver a comprar.
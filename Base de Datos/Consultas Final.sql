/*
=======================================CONSULTA 1=======================================
*/

-- Total de ventas, cantidad de productos vendidos y promedio de ventas por día

SELECT
    CONVERT(DATE, F.fecha) AS Fecha,
    SUM(DF.pre_unitario * DF.cantidad) AS ImporteTotalVentas,
    SUM(DF.cantidad) AS CantidadProductos,
    CONVERT(DECIMAL(20,2), AVG(DF.pre_unitario * DF.cantidad)) AS PromedioVentas
FROM FACTURAS F
JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY CONVERT(DATE, F.fecha)
ORDER BY CONVERT(DATE, F.fecha);

-- Total de ventas, cantidad de productos vendidos y promedio de ventas por semana
SELECT
	YEAR(F.fecha) AS Año,
    DATEPART(WEEK, F.fecha) AS Semana,
    SUM(DF.pre_unitario * DF.cantidad) AS ImporteTotalVentas,
    SUM(DF.cantidad) AS CantidadProductos,
    CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad)) AS PromedioVentas
FROM FACTURAS F
JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY YEAR(F.fecha), DATEPART(WEEK, F.fecha)
ORDER BY YEAR(F.fecha) DESC, DATEPART(WEEK, F.fecha);

-- Total de ventas, cantidad de productos vendidos y promedio de ventas por mes

SELECT
	YEAR(F.fecha) AS Año,
    MONTH(F.fecha) AS Mes,
    SUM(DF.pre_unitario * DF.cantidad) AS ImporteTotalVentas,
    SUM(DF.cantidad) AS CantidadProductos,
    CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad)) AS PromedioVentas
FROM FACTURAS F
JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY YEAR(F.fecha), MONTH(F.fecha)
ORDER BY YEAR(F.fecha) DESC, MONTH(F.fecha);

-- Total de ventas, cantidad de productos vendidos y promedio de ventas por cuatrimestre

SELECT
	YEAR(F.fecha) AS Año,
    DATEPART(QUARTER, F.fecha) AS Cuatrimestre,
    SUM(DF.pre_unitario * DF.cantidad) AS ImporteTotalVentas,
    SUM(DF.cantidad) AS CantidadProductos,
    CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad)) AS PromedioVentas
FROM FACTURAS F
JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY YEAR(F.fecha), DATEPART(QUARTER, F.fecha)
ORDER BY YEAR(F.fecha) DESC, DATEPART(QUARTER, F.fecha);

-- Total de ventas, cantidad de productos vendidos y promedio de ventas por año

SELECT
    YEAR(F.fecha) AS Año,
    SUM(DF.pre_unitario * DF.cantidad) AS ImporteTotalVentas,
    SUM(DF.cantidad) AS CantidadProductos,
    CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad)) AS PromedioVentas
FROM FACTURAS F
JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY YEAR(F.fecha)
ORDER BY YEAR(F.fecha);

/*
=======================================CONSULTA 2=======================================
*/

-- Venta de empleados por mes y anio, mostrando la cantidad, promedio, venta minima y maxima por mes y por empleado.

SELECT
	UPPER(E.ape_empleado) + ', ' + E.nom_empleado as NombreCompleto,
    DATEPART(YEAR, F.fecha) AS Año,
    DATENAME(MONTH, F.fecha) AS Mes,
    COUNT(F.nro_factura) AS CantidadVentas,
    CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad)) AS PromedioVentas,
    MIN(DF.pre_unitario * DF.cantidad) AS VentaMinima,
    MAX(DF.pre_unitario * DF.cantidad) AS VentaMaxima
FROM EMPLEADOS E
LEFT JOIN FACTURAS F ON E.cod_empleado = F.cod_empleado
LEFT JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY E.cod_empleado, UPPER(E.ape_empleado) + ', ' + E.nom_empleado, DATEPART(YEAR, F.fecha), DATENAME(MONTH, F.fecha), MONTH(f.fecha)
ORDER BY MONTH(F.fecha) DESC, CantidadVentas DESC;


/*
=======================================CONSULTA 3=======================================
*/

-- Ventas a los clientes mostrando sus datos, cantidad, venta minima, venta maxima, primera venta, ultima venta, ventas del mes pasado y actual, de las ventas a los clientes.

SELECT
    C.nom_cliente + ' ' + C.ape_cliente AS Nombre,
    C.nro_doc AS NumeroDocumento,
    C.nro_afiliado AS NumeroAfiliado,
    COUNT(F.nro_factura) AS CantidadVentas,
    AVG(DF.pre_unitario * DF.cantidad) AS PromedioVentas,
    MIN(DF.pre_unitario * DF.cantidad) AS VentaMinima,
    MAX(DF.pre_unitario * DF.cantidad) AS VentaMaxima,
    convert(date, min(f.fecha)) PrimerVenta,
    convert(date, max(f.fecha)) UltimaVenta,
    (
        select count(*) from facturas f2
        where f2.cod_cliente = c.cod_cliente
        and datediff(month, f2.fecha, getdate()) = 1
    ) 'Ventas el mes pasado',
    (
        select count(*) from facturas f2
        where f2.cod_cliente = c.cod_cliente
        and datediff(month, f2.fecha, getdate()) = 0
    ) 'Ventas el este mes'
FROM CLIENTES C
LEFT JOIN FACTURAS F ON C.cod_cliente = F.cod_cliente
LEFT JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY C.cod_cliente,  C.nom_cliente + ' ' + C.ape_cliente, C.nro_doc, C.nro_afiliado
ORDER BY CantidadVentas DESC;

/*
=======================================CONSULTA 4=======================================
*/

-- Mostrar los datos de los productos con su cantidad total vendida, su facturacion total, el precio promedio y el mes que mas se vendio.

SELECT P.cod_producto, p.descripcion, 

sum(df.cantidad) as CantidadTotalVendida,

'$ ' + STR(sum(df.cantidad*df.pre_unitario)) as 'Facturacion Total',

CONVERT(DECIMAL(10,2), avg(df.pre_unitario)) as 'Precio promedio',
(
    SELECT DATENAME(MONTH, F.fecha) AS Mes
    FROM PRODUCTOS P2
    LEFT JOIN DETALLE_FACTURA DF ON P2.cod_producto = DF.cod_producto
    LEFT JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    WHERE p2.cod_producto = p.cod_producto
    GROUP BY P2.cod_producto, P2.descripcion, DATENAME(MONTH, F.fecha)
    HAVING SUM(DF.cantidad) = (
        SELECT MAX(CantidadTotalVendida)
        FROM (
            SELECT P.cod_producto, MONTH(F.fecha) AS Mes, SUM(DF.cantidad) AS CantidadTotalVendida
            FROM PRODUCTOS P
            LEFT JOIN DETALLE_FACTURA DF ON P.cod_producto = DF.cod_producto
            LEFT JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
            GROUP BY P.cod_producto, MONTH(F.fecha)
        ) AS VentasPorProductoSubquery
        WHERE VentasPorProductoSubquery.cod_producto = P.cod_producto
)
) as 'Mes que mas se vendio'


from PRODUCTOS P
JOIN DETALLE_FACTURA DF ON P.cod_producto = DF.cod_producto
JOIN FACTURAS f on df.nro_factura = f.nro_factura
group by P.cod_producto, p.descripcion
order by p.cod_producto
/*
=======================================CONSULTA 5=======================================
*/

-- Muestra los productos con su respectivo stock con su estado de necesidad respecto a los stocks.

SELECT
    P.cod_producto AS CodigoProducto,
    P.descripcion AS DescripcionProducto,
    P.stock AS StockActual,
    P.stock_minimo AS StockMinimo,
    CASE
        WHEN P.stock <= P.stock_minimo THEN 'Urgente'
        ELSE 'No Urgente'
    END AS Urgencia
FROM PRODUCTOS P
ORDER BY Urgencia DESC, P.descripcion;

/*
=======================================CONSULTA 6=======================================
*/

-- Mostramos por sucursal con sus datos y el porcentaje de ganancia por producto y su ganancia neta final.

SELECT
	S.cod_sucursales AS CodigoSucursal,
	S.calle + STR(S.altura) AS DireccionSucursal,
	p.cod_producto AS CodigoProducto, 
	p.descripcion As DescripcionProducto, 
	STR(((SUM(df.cantidad * df.pre_unitario) * 100) /  SUM(l.cantidad * l.pre_unitario)) * 100) + ' %' AS PorcentajeGanancia,
	'$ ' + STR(ABS(SUM(df.cantidad * df.pre_unitario) -  SUM(l.cantidad * l.pre_unitario))) AS GananciaNetaFinal
FROM PEDIDOS PE
JOIN LOTES L ON PE.cod_pedido = L.cod_pedido
JOIN SUCURSALES S ON PE.cod_sucursal = S.cod_sucursales
JOIN FACTURAS F ON S.cod_sucursales = F.cod_sucursal
JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
JOIN PRODUCTOS P ON P.cod_producto = DF.cod_producto
GROUP BY s.cod_sucursales, S.calle + STR(S.altura), p.cod_producto, p.descripcion
ORDER BY 1, 2, 3

/*
=======================================CONSULTA 7=======================================
*/

-- La facturacion promedio y la cantidad de productos que vende cada sucursal en los distintos dias.

SELECT
    S.cod_sucursales AS Sucursal,
	CONVERT(DATE, F.fecha) AS Fecha,
    SUM(DF.pre_unitario * DF.cantidad) AS TotalVentas,
    SUM(DF.cantidad) AS CantidadProductosVendidos,
    CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad)) AS FacturacionPromedio
FROM SUCURSALES S
INNER JOIN FACTURAS F ON S.cod_sucursales = F.cod_sucursal
INNER JOIN DETALLE_FACTURA DF ON F.nro_factura = DF.nro_factura
GROUP BY S.cod_sucursales, CONVERT(DATE, F.fecha)
ORDER BY  S.cod_sucursales, Fecha

/*
=======================================CONSULTA 8=======================================
*/

-- Mostrar los datos de los proveedores con el total de pedidos que le hemos realizado, el total de importe pedidos y importe promedio de los pedidos.

SELECT
    P.cod_proveedor AS CodigoProveedor,
    P.nom_proveedores AS NombreProveedor,
    P.calle + STR(P.altura) AS CalleProveedor,
    B.barrio AS BarrioProveedor,
    C.ciudad AS CiudadProveedor,
    P.telefono AS TelefonoProveedor,
    P.email AS EmailProveedor,
    COUNT(DISTINCT L.cod_pedido) AS TotalPedidosRealizados,
     '$ ' + STR(SUM(L.cantidad * L.pre_unitario)) AS TotalImportePedidos,
	'$ ' + STR(CONVERT(DECIMAL(10,2), SUM(L.cantidad * L.pre_unitario) / COUNT(DISTINCT L.cod_pedido))) AS ImportePromedioPedidos
FROM PROVEEDORES P
LEFT JOIN LOTES L ON P.cod_proveedor = L.cod_proveedor
LEFT JOIN BARRIOS B ON P.cod_barrio = B.cod_barrio
LEFT JOIN CIUDADES C ON B.cod_ciudad = C.cod_ciudad
LEFT JOIN PEDIDOS PE ON L.cod_pedido = PE.cod_pedido
GROUP BY
    P.cod_proveedor,
    P.nom_proveedores,
    P.calle,
    P.altura,
    B.barrio,
    C.ciudad,
    P.telefono,
    P.email
ORDER BY CodigoProveedor;

/*
=======================================CONSULTA 9=======================================
*/

-- Informe de pedidos donde se muestra lo que pidio cada sucursal con sus datos, a que proveedor se lo pidio y cuantas veces le pidio.

SELECT
    P.cod_pedido AS CodigoPedido,
    CONVERT(DATE, P.fecha_pedido) AS FechaPedido,
    '$ ' + STR(SUM(L.cantidad * L.pre_unitario)) AS ImportePedido,
	COUNT(L.cod_pedido) AS CantidadLotes,
    PR.nom_proveedores AS Proveedor,
    S.calle + ' ' + STR(S.altura) AS CalleSucursal,
    B.barrio AS BarrioSucursal,
    C.ciudad AS CiudadSucursal
FROM PEDIDOS P
LEFT JOIN LOTES L ON P.cod_pedido = L.cod_pedido
LEFT JOIN PROVEEDORES PR ON L.cod_proveedor = PR.cod_proveedor
LEFT JOIN SUCURSALES S ON P.cod_sucursal = S.cod_sucursales
LEFT JOIN BARRIOS B ON S.cod_barrio = B.cod_barrio
LEFT JOIN CIUDADES C ON B.cod_ciudad = C.cod_ciudad
GROUP BY P.cod_pedido, p.fecha_pedido, pr.nom_proveedores, S.calle + ' ' + STR(S.altura), B.barrio, C.ciudad
ORDER BY CodigoPedido;

/*
=======================================CONSULTA 10=======================================
*/

-- Mostramos los reembolsos que aun quedan pendientes por cobrar a la mutual con su respectivos datos y el porcentaje de descuento.

SELECT
    D.cod_descuento AS CodigoDescuento,
    P.descripcion AS Producto,
    M.nom_mutual AS Mutual,
    D.descuento AS PorcentajeDescuento,
    Cobrado = CASE
				WHEN RD.cobrado = 0 then 'No Cobrado'
				END,
    CONVERT(DATE, RD.fecha) AS Fecha
FROM REEMBOLSOS_DESCUENTOS RD
LEFT JOIN DETALLE_FACTURA DF ON RD.cod_detalle = DF.cod_detalle
LEFT JOIN PRODUCTOS P ON DF.cod_producto = P.cod_producto
LEFT JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
LEFT JOIN CLIENTES C ON F.cod_cliente = C.cod_cliente
LEFT JOIN MUTUALES_OBRAS_SOCIALES M ON C.cod_mutual = M.cod_mutual
LEFT JOIN DESCUENTOS D ON M.cod_mutual = D.cod_mutual
WHERE RD.cobrado = 0; -- Filtrar descuentos no cobrados

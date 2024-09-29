use pepas_final

CREATE PROCEDURE SP_CONSULTAR_1
AS
BEGIN
    SELECT
    YEAR(F.fecha) AS Año,
    MONTH(F.fecha) AS Mes,
    '$' + STR(SUM(DF.pre_unitario * DF.cantidad)) AS ImporteTotalVentas,
    SUM(DF.cantidad) AS CantidadProductos,
    '$' + STR(CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad))) AS PromedioVentas
    FROM FACTURAS F
    JOIN DETALLES_FACTURA DF ON F.nro_factura = DF.nro_factura
    GROUP BY YEAR(F.fecha), MONTH(F.fecha)
    ORDER BY YEAR(F.fecha) DESC, MONTH(F.fecha);
END

CREATE PROCEDURE SP_CONSULTAR_VENTAS
@año INT = NULL,
@mes INT = NULL,
@cod_empleado INT = NULL
AS
BEGIN
IF @año IS NULL
SET @año = YEAR(GETDATE());
IF @mes IS NULL
SET @mes = MONTH(GETDATE());
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
LEFT JOIN DETALLES_FACTURA DF ON F.nro_factura = DF.nro_factura
WHERE MONTH(F.fecha) = @mes
AND YEAR(F.fecha) = @año
AND (@cod_empleado IS NULL OR E.cod_empleado = @cod_empleado)
GROUP BY E.cod_empleado, UPPER(E.ape_empleado) + ', ' + E.nom_empleado, DATEPART(YEAR, F.fecha), DATENAME(MONTH, F.fecha),
MONTH(f.fecha)
ORDER BY MONTH(F.fecha) DESC, CantidadVentas DESC;
END

CREATE PROCEDURE SP_CONSULTAR_6
AS
BEGIN
	SELECT
	S.cod_sucursales AS CodigoSucursal,
	S.calle + STR(S.altura) AS DireccionSucursal,
	p.cod_producto AS CodigoProducto,
	p.descripcion As DescripcionProducto,
	STR(((SUM(df.cantidad * df.pre_unitario) * 100) / SUM(L.cantidad * L.pre_unitario)) * 100) + ' %' AS PorcentajeGanancia,
	'$ ' + STR(ABS(SUM(df.cantidad * df.pre_unitario) - SUM(L.cantidad * L.pre_unitario))) AS GananciaNetaFinal
	FROM PEDIDOS PE
	JOIN LOTES L ON PE.cod_pedido = L.cod_pedido
	JOIN SUCURSALES S ON PE.cod_sucursal = S.cod_sucursales
	JOIN FACTURAS F ON S.cod_sucursales = F.cod_sucursal
	JOIN DETALLES_FACTURA DF ON F.nro_factura = DF.nro_factura
	JOIN PRODUCTOS P ON P.cod_producto = DF.cod_producto
	GROUP BY S.cod_sucursales, S.calle + STR(S.altura), p.cod_producto, p.descripcion
	ORDER BY 1, 2, 3
END
GO


CREATE PROCEDURE SP_CONSULTAR_7
AS
BEGIN
	SELECT
	 S.cod_sucursales AS Sucursal,
	 CONVERT(DATE, F.fecha) AS Fecha,
	 SUM(DF.pre_unitario * DF.cantidad) AS TotalVentas,
	 SUM(DF.cantidad) AS CantidadProductosVendidos,
	 CONVERT(DECIMAL(10,2), AVG(DF.pre_unitario * DF.cantidad)) AS FacturacionPromedio
	FROM SUCURSALES S
	INNER JOIN FACTURAS F ON S.cod_sucursales = F.cod_sucursal
	INNER JOIN DETALLES_FACTURA DF ON F.nro_factura = DF.nro_factura
	GROUP BY S.cod_sucursales, CONVERT(DATE, F.fecha)
	ORDER BY S.cod_sucursales, Fecha
END
GO

CREATE PROCEDURE SP_CONSULTAR_8
AS
BEGIN
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
    GROUP BY P.cod_proveedor, P.nom_proveedores, P.calle, P.altura, B.barrio, C.ciudad, P.telefono, P.email
    ORDER BY CodigoProveedor
END


CREATE PROCEDURE SP_CONSULTAR_9
AS
BEGIN
	SELECT
	 S.calle + ' ' + STR(S.altura) AS CalleSucursal,
	 B.barrio AS BarrioSucursal,
	 C.ciudad AS CiudadSucursal,
	 PR.nom_proveedores AS Proveedor,
	 CONVERT(DATE, P.fecha_pedido) AS FechaPedido,
	 '$ ' + STR(SUM(L.cantidad * L.pre_unitario)) AS ImportePedido,
	COUNT(L.cod_pedido) AS CantidadLotes
	FROM PEDIDOS P
	LEFT JOIN LOTES L ON P.cod_pedido = L.cod_pedido
	LEFT JOIN PROVEEDORES PR ON L.cod_proveedor = PR.cod_proveedor
	LEFT JOIN SUCURSALES S ON P.cod_sucursal = S.cod_sucursales
	LEFT JOIN BARRIOS B ON S.cod_barrio = B.cod_barrio
	LEFT JOIN CIUDADES C ON B.cod_ciudad = C.cod_ciudad
	GROUP BY S.cod_sucursales,
	 p.fecha_pedido,
	 pr.nom_proveedores,
	 S.calle + ' ' + STR(S.altura),
	 B.barrio,
	 C.ciudad
	ORDER BY S.cod_sucursales, FechaPedido DESC;
END
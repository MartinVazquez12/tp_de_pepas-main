-- INSERTS

CREATE PROCEDURE SP_INSERTAR_CIUDADES
@ciudad VARCHAR(50)
AS
BEGIN
	INSERT INTO CIUDADES(ciudad) VALUES (@ciudad);
END
GO

CREATE PROCEDURE SP_INSERTAR_BARRIOS
@barrio VARCHAR(50),
@cod_ciudad INT
AS
BEGIN
	INSERT INTO BARRIOS(barrio, cod_ciudad) VALUES (@barrio, @cod_ciudad);
END
GO

CREATE PROCEDURE SP_INSERTAR_CLIENTES
@nombre VARCHAR(80),
@apellido VARCHAR(80),
@calle VARCHAR(80),
@altura INT,
@nro_afiliado INT,
@nro_doc INT,
@cod_tipo_doc INT,
@cod_barrio INT,
@cod_mutual INT
AS
BEGIN
	INSERT INTO CLIENTES(nom_cliente, ape_cliente, calle, altura, nro_afiliado, nro_doc, cod_tipo_doc, cod_barrio, cod_mutual)
	VALUES (@nombre, @apellido, @calle, @altura, @nro_afiliado, @nro_doc, @cod_tipo_doc, @cod_barrio, @cod_mutual);
END
GO

CREATE PROCEDURE SP_INSERTAR_RECETAS
@cantidad INT,
@cod_tipo_receta INT,
@matricula INT,
@cod_producto INT,
@cod_receta INT OUTPUT
AS
BEGIN
	INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto) 
	VALUES (@cantidad, @cod_tipo_receta, @matricula, @cod_producto);

	SET @cod_receta = SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE SP_INSERTAR_MEDICOS
@nombre VARCHAR(80),
@apellido VARCHAR(80),
@calle VARCHAR(80),
@altura INT,
@nro_asociado INT,
@nro_doc INT,
@cod_tipo_doc INT,
@cod_barrio INT
AS
BEGIN
	INSERT INTO MEDICOS(nom_medico, ape_medico, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
	VALUES (@nombre, @apellido, @calle, @altura, @cod_barrio, @nro_doc, @cod_tipo_doc);
END
GO

CREATE PROCEDURE SP_INSERTAR_PRODUCTOS
@descripcion VARCHAR(50),
@pre_unitario DECIMAL(10,2),
@stock_minimo INT,
@venta_libre BIT,
@cod_tipo_prod INT,
@cod_tipo_presentacion INT,
@cod_laboratorio INT
AS
BEGIN
	INSERT INTO PRODUCTOS(descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod, cod_tipo_presentacion, cod_laboratorio, activo)
	VALUES (@descripcion, @pre_unitario, @stock_minimo, @venta_libre, @cod_tipo_prod, @cod_tipo_presentacion, @cod_laboratorio, 1);

	DECLARE @cod_producto INT = SCOPE_IDENTITY()

	INSERT INTO STOCK_SUCURSALES(cod_sucursal, cod_producto, stock) VALUES(1, @cod_producto, 0)
	INSERT INTO STOCK_SUCURSALES(cod_sucursal, cod_producto, stock) VALUES(2, @cod_producto, 0)
	INSERT INTO STOCK_SUCURSALES(cod_sucursal, cod_producto, stock) VALUES(3, @cod_producto, 0)
END
GO

CREATE PROCEDURE SP_INSERTAR_REEMBOLSOS_DESCUESTOS
@importe DECIMAL(10,2),
@cobrado BIT,
@cod_detalle INT
AS
BEGIN
	INSERT INTO REEMBOLSOS_DESCUENTOS(importe, cobrado, fecha, cod_detalle)
	VALUES (@importe, @cobrado, GETDATE(), @cod_detalle)
END
GO

CREATE PROCEDURE SP_INSERTAR_RECETAS_AUDITORIAS
@descripcion VARCHAR(80),
@aprobado BIT,
@cod_detalle INT
AS
BEGIN
	INSERT INTO RECETA_AUDITORIAS(descripcion, aprobado, cod_detalle)
	VALUES (@descripcion, @aprobado, @cod_detalle);
END
GO

CREATE PROCEDURE SP_INSERTAR_FACTURAS
@cod_empleado INT,
@cod_cliente INT,
@cod_sucursal INT,
@cod_tipo_pago INT,
@nro_factura INT OUTPUT
AS
BEGIN
	INSERT INTO FACTURAS(fecha, cod_empleado, cod_cliente, cod_sucursal, cod_tipo_pago)
	VALUES (GETDATE(), @cod_empleado, @cod_cliente, @cod_sucursal, @cod_tipo_pago);

	SET @nro_factura = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE SP_INSERTAR_DETALLES_FACTURA
@nro_factura INT,
@cod_producto INT,
@cantidad INT,
@pre_unitario INT,
@cod_receta INT = NULL,
@descuento DECIMAL(5,2)
AS
BEGIN
	INSERT INTO DETALLES_FACTURA(nro_factura, cod_producto, cantidad, pre_unitario, cod_receta, descuento)
	VALUES (@nro_factura, @cod_producto, @cantidad, @pre_unitario, @cod_receta, @descuento);
END
GO

CREATE PROCEDURE SP_INSERTAR_PEDIDOS
@cod_tipo_pago INT,
@cod_sucursal INT,
@cod_pedido INT OUTPUT
AS
BEGIN
	INSERT INTO PEDIDOS(fecha_pedido, cod_sucursal, cod_tipo_pago) 
	VALUES (GETDATE(), @cod_sucursal, @cod_tipo_pago);

	SET @cod_pedido = SCOPE_IDENTITY();
END
GO


CREATE PROCEDURE SP_INSERTAR_LOTES
@cod_pedido INT,
@cantidad INT,
@pre_unitario DECIMAL(5,2),
@fecha_vencimiento DATETIME,
@cod_producto INT,
@cod_proveedor INT
AS
BEGIN
	INSERT INTO LOTES(cod_pedido, cantidad, pre_unitario, fecha_vencimiento, cod_producto, cod_proveedor)
	VALUES (@cod_pedido, @cantidad, @pre_unitario, @fecha_vencimiento, @cod_producto, @cod_proveedor);
END
GO

	
CREATE PROCEDURE SP_INSERTAR_PROVEEDORES
@nombre VARCHAR(80),
@calle VARCHAR(100),
@altura INT,
@telefono VARCHAR(100),
@email VARCHAR(100),
@cod_barrio INT
AS
BEGIN
	INSERT INTO PROVEEDORES(nom_proveedores, calle, altura, telefono, email, cod_barrio)
	VALUES (@nombre, @calle, @altura, @telefono, @email, @cod_barrio);
END
GO

-- CONSULTAR


CREATE PROCEDURE SP_CONSULTAR_CIUDADES
AS
BEGIN
	SELECT * FROM CIUDADES
END
GO

CREATE PROCEDURE SP_CONSULTAR_BARRIOS
@cod_ciudad INT
AS
BEGIN
	SELECT * FROM BARRIOS
	WHERE cod_ciudad = @cod_ciudad
END

GO

CREATE PROCEDURE SP_CONSULTAR_MUTUALES
AS
BEGIN
	SELECT * FROM MUTUALES_OBRAS_SOCIALES
END
GO

CREATE PROCEDURE SP_CONSULTAR_TIPOS_DOCUMENTOS
AS
BEGIN
	SELECT * FROM TIPOS_DOCUMENTOS
END
GO

CREATE PROCEDURE SP_CONSULTAR_TIPOS_FORMAS_DE_PAGO
AS
BEGIN
	SELECT * FROM TIPOS_FORMAS_DE_PAGO
END
GO

CREATE PROCEDURE SP_CONSULTAR_TIPOS_RECETAS
AS
BEGIN
	SELECT * FROM TIPOS_RECETAS
END
GO

CREATE PROCEDURE SP_CONSULTAR_CLIENTES
AS
BEGIN
	SELECT * FROM CLIENTES
END
GO

CREATE PROCEDURE SP_CONSULTAR_FACTURAS
AS
BEGIN
	SELECT * FROM FACTURAS
END
GO

CREATE PROCEDURE SP_CONSULTAR_FACTURAS_FILTROS
@fecha_desde DATETIME,
@fecha_hasta DATETIME,
@cliente VARCHAR(80),
@nro_factura INT = NULL
AS
BEGIN
	SELECT * 
	FROM FACTURAS f
	WHERE ((@nro_factura IS NULL) OR (f.nro_factura = @nro_factura))
	AND f.fecha BETWEEN @fecha_desde AND @fecha_hasta
	AND f.cod_cliente IN (SELECT cod_cliente 
			      FROM CLIENTES c
			      WHERE c.nom_cliente LIKE '%'  + @cliente + '%'
			      OR c.ape_cliente LIKE '%'  + @cliente + '%')
END
GO

CREATE PROCEDURE SP_CONSULTAR_DETALLES_FACTURA
@nro_factura INT
AS
BEGIN
	SELECT * FROM DETALLES_FACTURA
	WHERE nro_factura = @nro_factura
END
GO

CREATE PROCEDURE SP_CONSULTAR_MEDICOS
AS
BEGIN
	SELECT * FROM MEDICOS
END
GO

CREATE PROCEDURE SP_CONSULTAR_LABORATORIOS
AS
BEGIN
	SELECT * FROM LABORATORIOS
END
GO

CREATE PROCEDURE SP_CONSULTAR_PROVEEDORES
AS
BEGIN
	SELECT * FROM PROVEEDORES
END
GO

CREATE PROCEDURE SP_CONSULTAR_PRODUCTOS
AS
BEGIN
	SELECT * FROM PRODUCTOS
	WHERE activo = 1
END
GO

CREATE PROCEDURE SP_CONSULTAR_TIPOS_PRESENTACIONES
AS
BEGIN
	SELECT * FROM TIPOS_PRESENTACIONES
END
GO

CREATE PROCEDURE SP_CONSULTAR_EMPLEADOS
AS
BEGIN
	SELECT * FROM EMPLEADOS
END
GO

CREATE PROCEDURE SP_CONSULTAR_SUCURSALES
AS
BEGIN
	SELECT * FROM SUCURSALES
END
GO

CREATE PROCEDURE SP_CONSULTAR_DESCUENTOS
@cod_mutual INT,
@cod_producto INT,
@descuento DECIMAL(5,2) OUTPUT
AS
BEGIN
	IF EXISTS (SELECT descuento FROM DESCUENTOS
					WHERE cod_mutual = @cod_mutual
					AND cod_producto = @cod_producto)
	BEGIN 
		SET @descuento = (SELECT descuento FROM DESCUENTOS
					WHERE cod_mutual = @cod_mutual
					AND cod_producto = @cod_producto)
	END
	ELSE
	BEGIN
		SET @descuento = 0
	END
END
GO

CREATE PROCEDURE SP_CONSULTAR_TIPOS_PRODUCTOS
AS
BEGIN
	SELECT * FROM TIPOS_PRODUCTOS
END
GO

CREATE PROCEDURE SP_CONSULTAR_PEDIDOS
AS
BEGIN
	SELECT * FROM PEDIDOS;
END
GO

CREATE PROCEDURE SP_CONSULTAR_LOTES
@cod_pedido INT
AS
BEGIN
	SELECT * FROM LOTES
	WHERE cod_pedido = @cod_pedido
END
GO
	
-- Otros
	
CREATE PROCEDURE SP_CONSULTAR_CLIENTES_FILTROS
@cliente varchar(80),
@nro_doc int = NULL
AS
BEGIN
	SELECT * FROM CLIENTES c
	WHERE (nom_cliente LIKE @cliente + '%'
	OR ape_cliente LIKE @cliente + '%')
	AND ((@nro_doc IS NULL) OR (c.nro_doc = @nro_doc))
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PRODUCTOS_FILTROS]
@cod_tipo_producto INT = NULL,
@descripcion VARCHAR(100)
AS
BEGIN
	SELECT * FROM PRODUCTOS
	WHERE (@cod_tipo_producto = NULL OR cod_tipo_prod = @cod_tipo_producto)
	AND descripcion LIKE '%' + @descripcion + '%'

END
GO

CREATE PROCEDURE SP_CONSULTAR_PRODUCTOS_TIPOPROD
@cod_tipo_producto INT
AS
BEGIN
	SELECT * FROM PRODUCTOS
	WHERE cod_tipo_prod = @cod_tipo_producto
END
GO

CREATE PROCEDURE SP_CONSULTAR_TIPOS_PRODUCTOS_FILTROS
@id_tipo_prod INT,
@tipo_prod VARCHAR(100) OUTPUT
AS
BEGIN
	SET @tipo_prod = (SELECT tipo_prod FROM TIPOS_PRODUCTOS
			  WHERE cod_tipo_prod = @id_tipo_prod)
END
GO

CREATE PROCEDURE SP_CONSULTAR_LABORATORIOS_FILTROS
@cod_laboratorio INT,
@laboratorio VARCHAR(100) OUTPUT
AS
BEGIN
	SET @laboratorio = (SELECT nom_laboratorio FROM LABORATORIOS
						WHERE cod_laboratorio = @cod_laboratorio)
END
GO

CREATE PROCEDURE SP_CONSULTAR_PROVEEDORES_FILTRO
@nom_prov varchar(80)
AS
BEGIN
	SELECT * FROM PROVEEDORES
	WHERE nom_proveedores LIKE @nom_prov + '%'
END
GO


CREATE PROCEDURE SP_DESHABILITAR_PRODUCTO
@id INT
AS
BEGIN
	UPDATE PRODUCTOS
	SET activo = 0
	WHERE cod_producto = @id
END
GO

CREATE PROCEDURE SP_CONSULTAR_CLIENTE_MUTUAL
@cod_cliente INT,
@mutual VARCHAR(100) OUTPUT
AS
BEGIN
	SET @mutual = (SELECT nom_mutual
				   FROM MUTUALES_OBRAS_SOCIALES
				   WHERE cod_mutual = (SELECT c.cod_mutual
						       FROM CLIENTES c
						       WHERE c.cod_cliente = @cod_cliente)
		      )
END
GO

CREATE PROCEDURE SP_CONSULTAR_EMPLEADO_FILTRO
@cod_empleado INT,
@empleado VARCHAR(100) OUTPUT
AS
BEGIN
	SET @empleado = (SELECT UPPER(ape_empleado) + ', ' + nom_empleado FROM EMPLEADOS
			  WHERE cod_empleado = @cod_empleado)
END
GO

CREATE PROCEDURE SP_CONSULTAR_CLIENTE_FILTRO
@cod_cliente INT,
@cliente VARCHAR(100) OUTPUT
AS
BEGIN
	SET @cliente = (SELECT UPPER(ape_cliente) + ', ' + nom_cliente FROM CLIENTES
			  WHERE cod_cliente = @cod_cliente)
END
GO

CREATE PROCEDURE SP_CONSULTAR_SUCURSAL_FILTRO
@cod_sucursal INT,
@sucursal VARCHAR(100) OUTPUT
AS
BEGIN
	SET @sucursal = (SELECT calle + ' ' + STR(altura) FROM SUCURSALES
			  WHERE cod_sucursales = @cod_sucursal)
END
GO

CREATE PROCEDURE SP_CONSULTAR_SUCURSAL
@cod_sucursal INT
AS
BEGIN
	SELECT * from SUCURSALES
	WHERE cod_sucursales = @cod_sucursal
END
GO

CREATE PROCEDURE SP_CONSULTAR_FORMA_PAGO_FILTRO
@cod_forma_pago INT,
@forma_pago VARCHAR(100) OUTPUT
AS
BEGIN
	SET @forma_pago = (SELECT forma_pago FROM TIPOS_FORMAS_DE_PAGO
			  WHERE cod_forma_pago = @cod_forma_pago)
END
GO

CREATE PROCEDURE SP_BAJAR_FACTURA
@nro_factura INT
AS
BEGIN
	UPDATE FACTURAS
	SET fecha_baja = GETDATE()
	WHERE nro_factura = @nro_factura
END
GO

CREATE PROCEDURE SP_CONSULTAR_PRODUCTO_FILTRO
@cod_producto INT,
@producto VARCHAR(100) OUTPUT
AS
BEGIN
	SET @producto = (SELECT descripcion FROM PRODUCTOS
			 WHERE cod_producto = @cod_producto)
END
GO


CREATE PROCEDURE SP_MODIFICAR_CLIENTES
@id int,
@nombre VARCHAR(80),
@apellido VARCHAR(80),
@calle VARCHAR(80),
@altura INT,
@nro_afiliado INT,
@nro_doc INT,
@cod_tipo_doc INT,
@cod_barrio INT,
@cod_mutual INT
AS
BEGIN
	UPDATE CLIENTES
		SET nom_cliente = @nombre, ape_cliente = @apellido, calle = @calle, altura = @altura, nro_afiliado = @nro_afiliado,
		nro_doc = @nro_doc, cod_tipo_doc = @cod_tipo_doc, cod_barrio = @cod_barrio, cod_mutual = @cod_mutual
		WHERE cod_cliente = @id
END
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_BARRIOS_FILTROS]
@cod_barrio INT,
@ciudad INT OUTPUT
AS
BEGIN
    SET @ciudad = (SELECT cod_ciudad FROM CIUDADES
                   WHERE cod_ciudad = (SELECT cod_ciudad
                                       FROM BARRIOS
                                       WHERE cod_barrio = @cod_barrio))
END
GO 



CREATE PROCEDURE SP_CONSULTAR_PEDIDOS_FILTROS
@fecha_desde DATETIME,
@fecha_hasta DATETIME,
@sucursal int,
@nro_pedido int
AS
BEGIN
	SELECT * FROM PEDIDOS
	WHERE fecha_pedido BETWEEN @fecha_desde and @fecha_hasta
	AND ((@sucursal IS NULL) OR (cod_pedido = @sucursal))
	AND ((@nro_pedido IS NULL) OR (cod_pedido = @nro_pedido))
END
GO

CREATE PROCEDURE SP_CONSULTAR_PROVEEDOR_FILTROS
@cod_proveedor INT,
@proveedor VARCHAR(100) OUTPUT
AS
BEGIN
	SET @proveedor = (SELECT nom_proveedores FROM PROVEEDORES
			  WHERE cod_proveedor = @cod_proveedor)
END
GO

CREATE PROCEDURE SP_MODIFICAR_STOCK
@cod_sucursal INT,
@cod_producto INT,
@cantidad INT
AS
BEGIN
	UPDATE STOCK_SUCURSALES
	SET stock = stock + @cantidad
	WHERE cod_sucursal = @cod_sucursal
		AND cod_producto = @cod_producto
END
GO

CREATE PROCEDURE SP_CONSULTAR_STOCK
@cod_sucursal INT,
@cod_producto INT,
@stock INT OUTPUT
AS
BEGIN
	SET @stock = (SELECT stock FROM STOCK_SUCURSALES
			      WHERE cod_sucursal = @cod_sucursal
					AND cod_producto = @cod_producto)
END
GO

--CREATE PROCEDURE [dbo].[SP_CONSULTAR_PRODUCTOS_FILTROS]
--@cod_tipo_producto INT = NULL,
--@descripcion VARCHAR(100)
--AS
--BEGIN
--	SELECT * FROM PRODUCTOS
--	WHERE (@cod_tipo_producto = NULL OR cod_tipo_prod = @cod_tipo_producto)
--	AND descripcion LIKE '%' + @descripcion + '%'

--END
--GO

CREATE PROCEDURE SP_STOCK_FECHA_VENCIMIENTO
@cod_producto INT,
@cod_sucursal INT
AS
BEGIN
	UPDATE STOCK_SUCURSALES
	SET stock = (SELECT SUM(l.cantidad) FROM LOTES l
				JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido
				WHERE l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())
				AND l.cod_producto = @cod_producto
				AND p.cod_sucursal = @cod_sucursal)
	WHERE cod_producto = @cod_producto AND cod_sucursal = @cod_sucursal
END
GO
-- para este SP habria que agregar los campos usuario y contraseña de cada sucursal
CREATE PROCEDURE SP_LOGIN
@usuario varchar(100),
@contra varchar(100),
@cod_sucursal INT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM SUCURSALES
			WHERE usuario LIKE @usuario AND contra = @contra)
		BEGIN
			SET @cod_sucursal = (SELECT cod_sucursales FROM SUCURSALES WHERE usuario LIKE @usuario AND contra = @contra)
		END
	ELSE
		set @cod_sucursal = 0
END
GO
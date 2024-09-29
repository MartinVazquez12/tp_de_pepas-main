
-- Tabla TIPOS_PRODUCTOS
CREATE TABLE TIPOS_PRODUCTOS (
    cod_tipo_prod INT PRIMARY KEY IDENTITY(1,1),
    tipo_prod VARCHAR(50)
);

-- Tabla TIPOS_CONTACTOS
CREATE TABLE TIPOS_CONTACTOS (
    cod_tipo_contacto INT PRIMARY KEY IDENTITY(1,1),
    tipo_contacto VARCHAR(50)
);

-- Tabla TIPOS_DOCUMENTOS
CREATE TABLE TIPOS_DOCUMENTOS (
    cod_tipo_doc INT PRIMARY KEY IDENTITY(1,1),
    tipo_doc VARCHAR(50)
);

-- Tabla TIPOS_FORMAS_DE_PAGO
CREATE TABLE TIPOS_FORMAS_DE_PAGO (
    cod_forma_pago INT PRIMARY KEY IDENTITY(1,1),
    forma_pago VARCHAR(50)
);

-- Tabla TIPOS_RECETAS
CREATE TABLE TIPOS_RECETAS (
    cod_tipo_receta INT PRIMARY KEY IDENTITY(1,1),
    tipo_receta VARCHAR(50)
);

-- Tabla TIPOS_PRESENTACIONES
CREATE TABLE TIPOS_PRESENTACIONES (
    cod_tipo_presentacion INT PRIMARY KEY IDENTITY(1,1),
    tipo_presentacion VARCHAR(50)
);

-- Tabla CIUDADES
CREATE TABLE CIUDADES (
    cod_ciudad INT PRIMARY KEY IDENTITY(1,1),
    ciudad VARCHAR(50)
);

-- Tabla BARRIOS
CREATE TABLE BARRIOS (
    cod_barrio INT PRIMARY KEY IDENTITY(1,1),
    barrio VARCHAR(50),
    cod_ciudad INT FOREIGN KEY REFERENCES CIUDADES(cod_ciudad)
);

-- Tabla PROVEEDORES
CREATE TABLE PROVEEDORES (
    cod_proveedor INT PRIMARY KEY IDENTITY(1,1),
    nom_proveedores VARCHAR(80),
    calle VARCHAR(80),
    altura INT,
    telefono VARCHAR(100),
    email VARCHAR(100),
    cod_barrio INT FOREIGN KEY REFERENCES BARRIOS(cod_barrio)
);

-- Tabla EMPLEADOS
CREATE TABLE EMPLEADOS (
    cod_empleado INT PRIMARY KEY IDENTITY(1,1),
    nom_empleado VARCHAR(80),
    ape_empleado VARCHAR(80),
    calle VARCHAR(80),
    altura INT,
    cod_barrio INT,
    nro_doc INT,
    cod_tipo_doc INT,
    FOREIGN KEY (cod_barrio) REFERENCES BARRIOS(cod_barrio),
    FOREIGN KEY (cod_tipo_doc) REFERENCES TIPOS_DOCUMENTOS(cod_tipo_doc)
);

-- Tabla SUCURSALES
create TABLE SUCURSALES (
    cod_sucursales INT PRIMARY KEY IDENTITY(1,1),
    calle VARCHAR(80),
    altura INT,
    cod_barrio INT,
	usuario VARCHAR(80),
	contra VARCHAR(80),
    FOREIGN KEY (cod_barrio) REFERENCES BARRIOS(cod_barrio)
);

-- Tabla MUTUALES_OBRAS_SOCIALES
CREATE TABLE MUTUALES_OBRAS_SOCIALES (
    cod_mutual INT PRIMARY KEY IDENTITY(1,1),
    nom_mutual VARCHAR(50)
);

-- Tabla CLIENTES
CREATE TABLE CLIENTES (
    cod_cliente INT PRIMARY KEY IDENTITY(1,1),
    nom_cliente VARCHAR(80),
    ape_cliente VARCHAR(80),
    calle VARCHAR(80),
    altura INT,
    cod_barrio INT,
    nro_doc INT,
    cod_tipo_doc INT,
    cod_mutual INT,
    nro_afiliado INT,
    FOREIGN KEY (cod_barrio) REFERENCES BARRIOS(cod_barrio),
    FOREIGN KEY (cod_tipo_doc) REFERENCES TIPOS_DOCUMENTOS(cod_tipo_doc),
    FOREIGN KEY (cod_mutual) REFERENCES MUTUALES_OBRAS_SOCIALES(cod_mutual)
);

-- Tabla LABORATORIO
CREATE TABLE LABORATORIOS (
    cod_laboratorio INT PRIMARY KEY IDENTITY(1,1),
    nom_laboratorio VARCHAR(80),
    telefono VARCHAR(80),
    email VARCHAR(80)
);

-- Tabla PRODUCTOS
CREATE TABLE PRODUCTOS (
    cod_producto INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(200),
    pre_unitario DECIMAL(10,2),
    stock_minimo INT,
    venta_libre BIT,
    activo BIT,
    cod_tipo_prod INT,
    cod_tipo_presentacion INT,
    cod_laboratorio INT,
    FOREIGN KEY (cod_tipo_presentacion) REFERENCES TIPOS_PRESENTACIONES (cod_tipo_presentacion),
    FOREIGN KEY (cod_tipo_prod) REFERENCES TIPOS_PRODUCTOS(cod_tipo_prod),
    FOREIGN KEY (cod_laboratorio) REFERENCES LABORATORIOS (cod_laboratorio)
);

-- Tabla MEDICOS
CREATE TABLE MEDICOS (
    matricula INT PRIMARY KEY,
    nom_medico VARCHAR(80),
    ape_medico VARCHAR(80),
    calle VARCHAR(80),
    altura INT,
    cod_barrio INT,
    nro_doc INT,
    cod_tipo_doc INT,
    FOREIGN KEY (cod_barrio) REFERENCES BARRIOS (cod_barrio),
    FOREIGN KEY (cod_tipo_doc) REFERENCES TIPOS_DOCUMENTOS (cod_tipo_doc)
);

-- Tabla RECETAS
CREATE TABLE RECETAS (
    cod_receta INT PRIMARY KEY IDENTITY(1,1),
    cantidad INT,
    cod_tipo_receta INT,
    matricula INT,
    cod_producto INT,
    FOREIGN KEY (cod_tipo_receta) REFERENCES TIPOS_RECETAS(cod_tipo_receta),
    FOREIGN KEY (matricula) REFERENCES MEDICOS(matricula),
    FOREIGN KEY (cod_producto) REFERENCES PRODUCTOS (cod_producto)
);

-- Tabla FACTURAS
CREATE TABLE FACTURAS (
    nro_factura INT PRIMARY KEY IDENTITY(1,1),
    fecha DATETIME,
    cod_empleado INT,
    cod_cliente INT,
    cod_sucursal INT,
    cod_tipo_pago INT,
    fecha_baja DATETIME,
    FOREIGN KEY (cod_empleado) REFERENCES EMPLEADOS(cod_empleado),
    FOREIGN KEY (cod_cliente) REFERENCES CLIENTES(cod_cliente),
    FOREIGN KEY (cod_sucursal) REFERENCES SUCURSALES(cod_sucursales),
    FOREIGN KEY (cod_tipo_pago) REFERENCES TIPOS_FORMAS_DE_PAGO(cod_forma_pago)
);

-- Tabla DETALLE_FACTURA
CREATE TABLE DETALLES_FACTURA (
    cod_detalle INT PRIMARY KEY IDENTITY(1,1),
    nro_factura INT,
    cod_producto INT,
    cantidad INT,
    pre_unitario DECIMAL(10,2),
    cod_receta INT,
    descuento DECIMAL(5,2),
    FOREIGN KEY (nro_factura) REFERENCES FACTURAS (nro_factura),
    FOREIGN KEY (cod_receta) REFERENCES RECETAS (cod_receta),
    FOREIGN KEY (cod_producto) REFERENCES PRODUCTOS (cod_producto)
);

-- Tabla REEMBOLSOS_DESCUENTOS
CREATE TABLE REEMBOLSOS_DESCUENTOS (
    cod_reembolso INT PRIMARY KEY IDENTITY(1,1),
    importe DECIMAL,
    cobrado BIT,
    fecha DATETIME,
    cod_detalle INT,
    FOREIGN KEY (cod_detalle) REFERENCES DETALLES_FACTURA(cod_detalle)
);

-- Tabla DESCUENTOS
CREATE TABLE DESCUENTOS (
    cod_descuento INT PRIMARY KEY IDENTITY(1,1),
    cod_producto INT,
    cod_mutual INT,
    descuento DECIMAL(5,2),
    FOREIGN KEY (cod_producto) REFERENCES PRODUCTOS(cod_producto),
    FOREIGN KEY (cod_mutual) REFERENCES MUTUALES_OBRAS_SOCIALES(cod_mutual)
);

-- Tabla CONTACTOS
CREATE TABLE CONTACTOS (
    cod_contacto INT PRIMARY KEY IDENTITY(1,1),
    cod_empleado INT,
    cod_tipo_contacto INT,
    contacto VARCHAR(80),
    FOREIGN KEY (cod_empleado) REFERENCES EMPLEADOS(cod_empleado),
    FOREIGN KEY (cod_tipo_contacto) REFERENCES TIPOS_CONTACTOS(cod_tipo_contacto)
);

-- Tabla PEDIDOS
CREATE TABLE PEDIDOS (
    cod_pedido INT PRIMARY KEY IDENTITY(1,1),
    fecha_pedido DATETIME,
    cod_sucursal INT,
    cod_tipo_pago INT,
    FOREIGN KEY (cod_tipo_pago) REFERENCES TIPOS_FORMAS_DE_PAGO(cod_forma_pago),
    FOREIGN KEY (cod_sucursal) REFERENCES SUCURSALES(cod_sucursales)
);

CREATE TABLE LOTES (
    cod_lote INT PRIMARY KEY IDENTITY(1,1),
    fecha_vencimiento DATETIME,
    cantidad INT,
    pre_unitario DECIMAL(10,2),
    cod_pedido INT,
    cod_producto INT,
    cod_proveedor INT,
    FOREIGN KEY (cod_pedido) REFERENCES PEDIDOS(cod_pedido),
    FOREIGN KEY (cod_producto) REFERENCES PRODUCTOS(cod_producto),
    FOREIGN KEY (cod_proveedor) REFERENCES PROVEEDORES(cod_proveedor)
);

-- Tabla RECETAS AUDITORIAS
CREATE TABLE RECETA_AUDITORIAS (
    cod_receta INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(80),
    aprobado BIT,
    cod_detalle INT,
    FOREIGN KEY (cod_detalle) REFERENCES DETALLES_FACTURA (cod_detalle) 
);

-- Tabla STOCK POR SUCURSAL
CREATE TABLE STOCK_SUCURSALES (
    cod_stock_sucursal INT PRIMARY KEY IDENTITY(1,1),
    cod_sucursal INT,
    cod_producto INT,
    stock INT,
    FOREIGN KEY (cod_sucursal) REFERENCES SUCURSALES(cod_sucursales),
    FOREIGN KEY (cod_producto) REFERENCES PRODUCTOS(cod_producto)
);


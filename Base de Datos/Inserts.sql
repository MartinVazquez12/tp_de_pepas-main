--obras sociales

-- Insert 1
INSERT INTO MUTUALES_OBRAS_SOCIALES (nom_mutual)
VALUES ('OSDE');

-- Insert 2
INSERT INTO MUTUALES_OBRAS_SOCIALES (nom_mutual)
VALUES ('PAMI');

-- Insert 3
INSERT INTO MUTUALES_OBRAS_SOCIALES (nom_mutual)
VALUES ('IOSE');

-- Insert 4
INSERT INTO MUTUALES_OBRAS_SOCIALES (nom_mutual)
VALUES ('Swiss Medical');

-- Insert 5
INSERT INTO MUTUALES_OBRAS_SOCIALES (nom_mutual)
VALUES ('Galeno');


--ciudad

-- Insertar la ciudad de Córdoba
INSERT INTO CIUDADES (ciudad)
VALUES ('Córdoba');


--barrios

-- Insert 1
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Nueva Córdoba', 1);

-- Insert 2
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Alberdi', 1);

-- Insert 3
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Güemes', 1);

-- Insert 4
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Centro', 1);

-- Insert 5
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('General Paz', 1);

-- Insert 6
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('San Vicente', 1);

-- Insert 7
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Alta Córdoba', 1);

-- Insert 8
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Argüello', 1);

-- Insert 9
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Villa Belgrano', 1);

-- Insert 10
INSERT INTO BARRIOS (barrio, cod_ciudad)
VALUES ('Cerro de las Rosas', 1);






--tipo presentacion

-- Insert 1
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Pomada');

-- Insert 2
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Comprimido');

-- Insert 3
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Spray');

-- Insert 4
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Jarabe');

-- Insert 5
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Cápsula');

-- Insert 6
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Crema');

-- Insert 7
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Gotas');

-- Insert 8
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Inyectable');

-- Insert 9
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Tableta');

-- Insert 10
INSERT INTO TIPOS_PRESENTACIONES (tipo_presentacion)
VALUES ('Suspensión');



--tipo de recetas

-- Insert 1
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Certificada');

-- Insert 2
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Doble Certificada');

-- Insert 3
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Venta Libre');

-- Insert 4
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Receta Médica');

-- Insert 5
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Receta Electrónica');

-- Insert 6
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Receta en Blanco');

-- Insert 7
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Receta de Urgencia');

-- Insert 8
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Receta Especial');

-- Insert 9
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Receta Manipulada');

-- Insert 10
INSERT INTO TIPOS_RECETAS (tipo_receta)
VALUES ('Receta Magistral');


--tipo de pago

-- Insert 1
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Efectivo');

-- Insert 2
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Tarjeta de Crédito');

-- Insert 3
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Tarjeta de Débito');

-- Insert 4
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Transferencia Bancaria');

-- Insert 5
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Cheque');

-- Insert 6
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Pago Móvil');

-- Insert 7
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('PayPal');

-- Insert 8
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Criptomonedas');

-- Insert 9
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Vale de Comida');

-- Insert 10
INSERT INTO TIPOS_FORMAS_DE_PAGO (forma_pago)
VALUES ('Financiamiento Interno');


--tipo doc
INSERT INTO TIPOS_DOCUMENTOS VALUES ('Cedula de Identidad')
INSERT INTO TIPOS_DOCUMENTOS VALUES ('Pasaporte')
INSERT INTO TIPOS_DOCUMENTOS VALUES ('DNI')


--tipo contacto

INSERT INTO TIPOS_CONTACTOS VALUES ('E-Mail')
INSERT INTO TIPOS_CONTACTOS VALUES ('Teléfono')



--tipo de productos

-- Insert 1
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Analgésicos');

-- Insert 2
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Antibióticos');

-- Insert 3
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Antiinflamatorios');

-- Insert 4
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Antipiréticos');

-- Insert 5
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Antihistamínicos');

-- Insert 6
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Antisépticos');

-- Insert 7
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Antitusivos');

-- Insert 8
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Broncodilatadores');

-- Insert 9
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Calmantes');

-- Insert 10
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Descongestionantes Nasales');

-- Insert 11
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Digestivos');

-- Insert 12
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Expectorantes');

-- Insert 13
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Laxantes');

-- Insert 14
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Multivitamínicos');

-- Insert 15
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Protectores Solares');

-- Insert 16
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Repelentes');

-- Insert 17
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Suplementos Dietéticos');

-- Insert 18
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Productos para el Cuidado de la Piel');

-- Insert 19
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Productos para el Cuidado del Cabello');

-- Insert 20
INSERT INTO TIPOS_PRODUCTOS (tipo_prod)
VALUES ('Antimicóticos');


--laboratoriosss

-- Laboratorio 1
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio A', '123-456-7890', 'lab_a@example.com');

-- Laboratorio 2
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio B', '234-567-8901', 'lab_b@example.com');

-- Laboratorio 3
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio C', '345-678-9012', 'lab_c@example.com');

-- Laboratorio 4
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio D', '456-789-0123', 'lab_d@example.com');

-- Laboratorio 5
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio E', '567-890-1234', 'lab_e@example.com');

-- Laboratorio 6
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio F', '678-901-2345', 'lab_f@example.com');

-- Laboratorio 7
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio G', '789-012-3456', 'lab_g@example.com');

-- Laboratorio 8
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio H', '890-123-4567', 'lab_h@example.com');

-- Laboratorio 9
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio I', '901-234-5678', 'lab_i@example.com');

-- Laboratorio 10
INSERT INTO LABORATORIOS (nom_laboratorio, telefono, email)
VALUES ('Laboratorio J', '012-345-6789', 'lab_j@example.com');





--provedores

-- Proveedor 1
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Farmacia ABC', 'Calle 1', 123, '123-456-7890', 'farmaciaabc@email.com', 1);

-- Proveedor 2
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Droguería XYZ', 'Calle 2', 456, '987-654-3210', 'drogueriaxyz@email.com', 2);

-- Proveedor 3
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Farmacia Salud', 'Calle 3', 789, '234-567-8901', 'farmaciasalud@email.com', 3);

-- Proveedor 4
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Droguería Bienestar', 'Calle 4', 101, '543-210-9876', 'drogueriabienestar@email.com', 4);

-- Proveedor 5
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Farmacia Vital', 'Calle 5', 222, '321-654-0987', 'farmaciavital@email.com', 5);

-- Proveedor 6
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Droguería Vida', 'Calle 6', 333, '876-543-2109', 'drogueriavida@email.com', 6);

-- Proveedor 7
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Farmacia Esperanza', 'Calle 7', 444, '234-789-0123', 'farmaciaesperanza@email.com', 7);

-- Proveedor 8
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Droguería Confianza', 'Calle 8', 555, '654-321-9870', 'drogueriaconfianza@email.com', 8);

-- Proveedor 9
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Farmacia UniDrogas', 'Calle 9', 666, '987-123-4567', 'farmaciaunidrogas@email.com', 9);

-- Proveedor 10
INSERT INTO PROVEEDORES (nom_proveedores, calle, altura, telefono, email, cod_barrio)
VALUES ('Droguería SaludTotal', 'Calle 10', 777, '123-987-6543', 'drogueriasaludtotal@email.com', 1);



--empleados 
-- Empleado 1
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Juan', 'Pérez', 'Calle 1', 123, 1, 12345678, 1);

-- Empleado 2
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('María', 'Gómez', 'Calle 2', 456, 2, 98765432, 2);

-- Empleado 3
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Carlos', 'López', 'Calle 3', 789, 3, 34567890, 1);

-- Empleado 4
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Laura', 'Martínez', 'Calle 4', 101, 4, 23456789, 2);

-- Empleado 5
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Roberto', 'Fernández', 'Calle 5', 222, 5, 87654321, 2);

-- Empleado 6
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Ana', 'Díaz', 'Calle 6', 333, 6, 54321098, 1);

-- Empleado 7
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Pedro', 'Rodríguez', 'Calle 7', 444, 7, 43210987, 2);

-- Empleado 8
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Sofía', 'López', 'Calle 8', 555, 8, 32109876, 2);

-- Empleado 9
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Luis', 'Pérez', 'Calle 9', 666, 9, 21098765, 1);

-- Empleado 10
INSERT INTO EMPLEADOS (nom_empleado, ape_empleado, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES ('Marta', 'García', 'Calle 10', 777, 10, 10987654, 2);




--contactos de mepleados 
-- Contacto 1
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (1, 1, 'correo1@example.com');

-- Contacto 2
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (2, 1, 'correo2@example.com');

-- Contacto 3
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (3, 1, 'correo3@example.com');

-- Contacto 4
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (4, 1, 'correo4@example.com');

-- Contacto 5
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (5, 1, 'correo5@example.com');

-- Contacto 6
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (6, 2, '123-456-7890');

-- Contacto 7
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (7, 2, '987-654-3210');

-- Contacto 8
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (8, 2, '555-555-5555');

-- Contacto 9
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (9, 2, '111-222-3333');

-- Contacto 10
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (10, 2, '999-888-7777');

-- Contacto 11
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (1, 2, '777-888-9999');

-- Contacto 12
INSERT INTO CONTACTOS (cod_empleado, cod_tipo_contacto, contacto)
VALUES (2, 2, '444-333-2222');



--sucursales

-- Sucursal 1
INSERT INTO SUCURSALES (calle, altura, cod_barrio, usuario, contra)
VALUES ('Calle A', 123, 1, 'sucursal1', '1234');

-- Sucursal 2
INSERT INTO SUCURSALES (calle, altura, cod_barrio, usuario, contra)
VALUES ('Calle B', 456, 2, 'sucursal2', '1234');

-- Sucursal 3
INSERT INTO SUCURSALES (calle, altura, cod_barrio, usuario, contra)
VALUES ('Calle C', 789, 3, 'sucursal3', '1234');



--productos
-- Producto 1
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Aspirina 500mg', 5.99, 20, 1, 1, 1, 7, 1);

-- Producto 2
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Omeprazol 20mg', 7.50, 10, 1, 1, 2, 6, 1);

-- Producto 3
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Paracetamol 1000mg', 6.25, 25, 1, 1, 1, 9, 1);

-- Producto 4
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Ibuprofeno 600mg', 8.99, 15, 1, 1, 2, 4, 1);

-- Producto 5
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Amoxicilina 500mg', 10.75, 10, 0, 2, 1, 1, 1);

-- Producto 6
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Loratadina 10mg', 9.50, 12, 1, 1, 3, 5, 0);

-- Producto 7
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Vitamina C 1000mg', 12.99, 8, 1, 3, 2, 2, 1);

-- Producto 8
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Diazepam 5mg', 15.25, 5, 0, 4, 1, 8, 1);

-- Producto 9
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Ranitidina 150mg', 6.99, 20, 1, 1, 3, 6, 1);

-- Producto 10
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Salbutamol Inhalador', 18.75, 5, 1, 2, 4, 4, 1);

-- Producto 11
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Tafil 2mg', 20.50, 8, 0, 4, 1, 7, 1);

-- Producto 12
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Vitamina D3 1000 UI', 11.99, 10, 1, 3, 2, 5, 1);

-- Producto 13
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Naproxeno 500mg', 9.25, 12, 1, 1, 1, 4, 1);

-- Producto 14
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Dextrometorfano Jarabe', 8.75, 10, 1, 1, 5, 6, 1);

-- Producto 15
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Clorhexidina Enjuague Bucal', 12.99, 15, 1, 5, 3, 5, 1);

-- Producto 16
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Fenilefrina Gotas Nasales', 6.50, 10, 1, 2, 4, 3, 1);

-- Producto 17
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Lansoprazol 30mg', 10.99, 8, 1, 1, 2, 2, 1);

-- Producto 18
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Dipirona 500mg', 7.25, 18, 1, 1, 1, 2, 1);

-- Producto 19
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Cetirizina 10mg', 9.99, 15, 1, 1, 3, 7, 1);

-- Producto 20
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Metamizol 500mg', 8.75, 10, 1, 1, 1, 6, 1);

-- Producto 21
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Clonazepam 2mg', 21.99, 5, 0, 4, 1, 4, 1);

-- Producto 22
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Vitamina B12 1000mcg', 10.50, 10, 1, 3, 2, 9, 1);

-- Producto 23
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Ibuprofeno 400mg', 7.99, 10, 1, 1, 2, 10, 1);

-- Producto 24
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Lorazepam 1mg', 18.25, 5, 0, 4, 1, 10, 1);

-- Producto 25
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Vitamina E 400 UI', 13.99, 10, 1, 3, 2, 10, 0);

-- Producto 26
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Pantoprazol 40mg', 9.75, 15, 1, 1, 2, 5, 1);

-- Producto 27
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Furosemida 40mg', 6.50, 12, 1, 1, 1, 5, 1);

-- Producto 28
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Cefalexina 500mg', 10.99, 8, 0, 2, 1, 7, 1);

-- Producto 29
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Mebendazol 100mg', 8.25, 18, 1, 2, 1, 8, 1);

-- Producto 30
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Prednisona 5mg', 11.99, 15, 1, 1, 2, 9, 1);

-- Producto 31
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Metronidazol 500mg', 9.25, 12, 1, 2, 1, 4, 1);

-- Producto 32
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Loperamida 2mg', 8.75, 10, 1, 1, 1, 3, 1);

-- Producto 33
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Sulfato de Zinc Jarabe', 12.99, 15, 1, 5, 3, 2, 1);

-- Producto 34
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Pseudoefedrina 60mg', 6.50, 10, 1, 2, 4, 6, 1);

-- Producto 35
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Captopril 25mg', 10.99, 8, 1, 1, 2, 8, 1);

-- Producto 36
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Paroxetina 20mg', 7.25, 18, 1, 4, 1, 7, 0);

-- Producto 37
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Fexofenadina 120mg', 9.99, 15, 1, 1, 3, 2, 1);

-- Producto 38
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Ondansetrón 4mg', 8.75, 10, 1, 2, 1, 2, 1);

-- Producto 39
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Piroxicam 20mg', 11.50, 7, 1, 1, 2, 3, 1);

-- Producto 40
INSERT INTO PRODUCTOS (descripcion, pre_unitario, stock_minimo, venta_libre, cod_tipo_prod,  cod_tipo_presentacion, cod_laboratorio, activo)
VALUES ('Metformina 850mg', 12.75, 8, 1, 1, 1, 5, 1);



--descuentos

-- Descuento 1
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (1, 1, 10.00);

-- Descuento 2
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (2, 2, 15.00);

-- Descuento 3
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (3, 3, 20.00);

-- Descuento 4
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (4, 4, 12.50);

-- Descuento 5
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (5, 5, 8.00);

-- Descuento 6
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (6, 1, 17.00);

-- Descuento 7
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (7, 2, 14.00);

-- Descuento 8
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (8, 3, 10.00);

-- Descuento 9
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (9, 4, 15.00);

-- Descuento 10
INSERT INTO DESCUENTOS (cod_producto, cod_mutual, descuento)
VALUES (10, 3, 12.00);

--clienteS
-- Inserción 1
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Juan', 'Pérez', 'Calle A', 123, 1, 1234567, 1, 1, 1001);

-- Inserción 2
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('María', 'Gómez', 'Calle B', 456, 2, 2345678, 2, 2, 1002);

-- Inserción 3
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Carlos', 'López', 'Calle C', 789, 3, 3456789, 1, 3, 1003);

-- Inserción 4
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Laura', 'Fernández', 'Calle D', 101, 3, 4567890,2, 3, 1004);

-- Inserción 5
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Pedro', 'Rodríguez', 'Calle E', 222, 2, 5678901,1, 3, 1005);

-- Inserción 6
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Sofía', 'Sánchez', 'Calle F', 333, 1, 1234567, 1, 1, 1006);

-- Inserción 7
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Ana', 'Pérez', 'Calle G', 444, 2, 2345678, 2, 2, 1007);

-- Inserción 8
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Eduardo', 'García', 'Calle H', 555, 3, 3456789, 2, 3, 1008);

-- Inserción 9
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Luisa', 'Hernández', 'Calle I', 666, 2, 4567890, 2, 3, 1009);

-- Inserción 10
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Fernando', 'Torres', 'Calle J', 777, 1, 5678901, 1, 2, 1010);

-- Inserción 11
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Carla', 'Díaz', 'Calle K', 888, 1, 1234567, 1, 1, 1011);

-- Inserción 12
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Roberto', 'Fuentes', 'Calle L', 999, 2, 2345678, 2, 2, 1012);

-- Inserción 13
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Mariana', 'Paz', 'Calle M', 111, 3, 3456789,2, 3, 1013);

-- Inserción 14
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Gustavo', 'Gutiérrez', 'Calle N', 222, 2, 4567890, 2, 3, 1014);

-- Inserción 15
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Lorena', 'Ortega', 'Calle O', 333, 1, 5678901, 2, 1 , 1015);

-- Inserción 16
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Javier', 'Herrera', 'Calle P', 444, 1, 1234567, 1, 1, 1016);

-- Inserción 17
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Silvia', 'Luna', 'Calle Q', 555, 2, 2345678, 2, 2, 1017);

-- Inserción 18
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Pedro', 'Vargas', 'Calle R', 666, 3, 3456789,1, 3, 1018);

-- Inserción 19
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('María', 'Pérez', 'Calle S', 777, 3, 4567890, 1, 3, 1019);

-- Inserción 20
INSERT INTO CLIENTES (nom_cliente, ape_cliente, calle, altura, cod_barrio, nro_doc, cod_tipo_doc, cod_mutual, nro_afiliado)
VALUES ('Carlos', 'González', 'Calle T', 888, 1, 5678901, 2, 1, 1020);


-- Medicos

-- Inserción de datos ficticios en la tabla MEDICOS
INSERT INTO MEDICOS (matricula, nom_medico, ape_medico, calle, altura, cod_barrio, nro_doc, cod_tipo_doc)
VALUES
    (1001, 'Juan', 'González', 'Calle A', 123, 1, 12345678, 1),
    (1002, 'Ana', 'López', 'Calle B', 234, 2, 23456789, 2),
    (1003, 'Carlos', 'Martínez', 'Calle C', 345, 3, 34567890, 1),
    (1004, 'María', 'Rodríguez', 'Calle D', 456, 4, 45678901, 2),
    (1005, 'Luis', 'Fernández', 'Calle E', 567, 5, 56789012, 1),
    (1006, 'Laura', 'Pérez', 'Calle F', 678, 6, 67890123, 2),
    (1007, 'Diego', 'Sánchez', 'Calle G', 789, 7, 78901234, 1),
    (1008, 'Sofía', 'Gómez', 'Calle H', 890, 8, 89012345, 2),
    (1009, 'Pablo', 'Torres', 'Calle I', 901, 9, 90123456, 1),
    (1010, 'Elena', 'Díaz', 'Calle J', 1234, 10, 12345678, 2);


-- Pedidos
INSERT INTO PEDIDOS (fecha_pedido, cod_sucursal, cod_tipo_pago)
 VALUES ('2023-8-6', 3, 4);
INSERT INTO PEDIDOS (fecha_pedido, cod_sucursal, cod_tipo_pago)
 VALUES ('2023-10-3', 1, 2);
INSERT INTO PEDIDOS (fecha_pedido, cod_sucursal, cod_tipo_pago)
 VALUES ('2023-5-28', 3, 10);
INSERT INTO PEDIDOS (fecha_pedido, cod_sucursal, cod_tipo_pago)
 VALUES ('2023-6-26', 2, 2);
INSERT INTO PEDIDOS (fecha_pedido, cod_sucursal, cod_tipo_pago)
 VALUES ('2023-6-25', 1, 4);


-- Lotes
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 10 - 23', 10, 1498.72, 5, 39, 6);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 1 - 26', 37, 2316.7, 1, 29, 9);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 2 - 12', 10, 1903.31, 2, 16, 5);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 4 - 11', 15, 6752.18, 5, 32, 9);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 8 - 27', 37, 5490.53, 1, 26, 1);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 5 - 21', 26, 5596.13, 2, 14, 9);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 6 - 19', 15, 5825.26, 5, 7, 8);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 9 - 2', 21, 1680.69, 3, 3, 3);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 12 - 28', 26, 2549.37, 2, 7, 3);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 10 - 26', 13, 6612.49, 2, 22, 3);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 4 - 26', 40, 5361.06, 2, 39, 7);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 3 - 20', 24, 6323.5, 2, 5, 1);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 8 - 19', 37, 5864.91, 2, 4, 4);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 2 - 2', 30, 6560.73, 2, 38, 10);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 7 - 13', 33, 2684.7, 3, 2, 5);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 10 - 27', 15, 6875.41, 3, 20, 1);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 9 - 19', 21, 6792.67, 4, 13, 4);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 3 - 16', 21, 4071.56, 5, 38, 2);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 8 - 10', 11, 1223.18, 5, 31, 3);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 1 - 8', 16, 4047.38, 4, 35, 9);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 2 - 18', 18, 5406.04, 5, 26, 6);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 6 - 5', 35, 5322.7, 2, 18, 5);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 3 - 5', 32, 6039.46, 1, 12, 9);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 12 - 16', 15, 4449.63, 1, 26, 2);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 1 - 4', 20, 5978.2, 3, 7, 1);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 1 - 15', 35, 1744.26, 5, 15, 1);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 5 - 13', 18, 5286.67, 1, 31, 9);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 5 - 8', 13, 4566.29, 3, 34, 4);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 2 - 23', 37, 5574.37, 2, 3, 4);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 6 - 10', 33, 6770.49, 3, 26, 6);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 10 - 16', 21, 4719.53, 3, 34, 8);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 2 - 8', 32, 4829.44, 1, 26, 6);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 1 - 23', 35, 2533.57, 2, 39, 8);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 3 - 12', 30, 3168.03, 3, 27, 2);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 8 - 10', 31, 6366.72, 4, 14, 3);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 3 - 17', 31, 2252.27, 5, 8, 2);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 3 - 2', 23, 4417.01, 1, 10, 7);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 8 - 21', 33, 1482.02, 3, 11, 9);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 8 - 3', 20, 3993.9, 1, 18, 4);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 12 - 4', 18, 4577.45, 5, 20, 2);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 4 - 3', 32, 1848.19, 4, 2, 7);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 6 - 9', 13, 1633.24, 4, 18, 7);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 1 - 20', 15, 6400.95, 2, 31, 4);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 2 - 3', 29, 6649.18, 2, 16, 10);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 2 - 20', 33, 3831.26, 5, 7, 5);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 1 - 5', 35, 3337.98, 2, 8, 1);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 1 - 19', 13, 4621.85, 5, 13, 7);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2024 - 4 - 27', 23, 6238.96, 4, 8, 7);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 2 - 2', 14, 6239.25, 2, 30, 10);
INSERT INTO LOTES(fecha_vencimiento, cantidad, pre_unitario, cod_pedido, cod_producto, cod_proveedor)
VALUES('2025 - 2 - 2', 16, 1444.54, 3, 29, 3);


-- Recetas

INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (14, 4, 1004, 35);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (8, 2, 1009, 19);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (15, 2, 1004, 4);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (8, 6, 1006, 40);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (9, 9, 1008, 33);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (15, 4, 1002, 39);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (3, 9, 1006, 4);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (13, 9, 1007, 18);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (15, 7, 1002, 25);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (17, 5, 1003, 5);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (13, 7, 1005, 14);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (20, 9, 1007, 2);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (12, 10, 1001, 6);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (15, 6, 1007, 36);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (15, 10, 1009, 17);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (20, 3, 1009, 9);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (18, 5, 1007, 27);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (10, 9, 1004, 22);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (13, 3, 1005, 32);
INSERT INTO RECETAS(cantidad, cod_tipo_receta, matricula, cod_producto)
VALUES (14, 8, 1009, 33);


-- FACTURAS

INSERT INTO FACTURAS VALUES ('2023-01-06',9,2,1,6, null) 
INSERT INTO FACTURAS VALUES ('2023-08-22',4,10,2,1, null) 
INSERT INTO FACTURAS VALUES ('2023-05-12',6,9,3,4, null) 
INSERT INTO FACTURAS VALUES ('2023-10-23',2,4,3,5, null) 
INSERT INTO FACTURAS VALUES ('2023-03-01',5,10,1,8, null) 
INSERT INTO FACTURAS VALUES ('2023-02-28',10,2,2,7, null) 
INSERT INTO FACTURAS VALUES ('2023-06-25',5,9,2,10, null) 
INSERT INTO FACTURAS VALUES ('2023-11-17',9,5,1,4, null) 
INSERT INTO FACTURAS VALUES ('2023-12-30',5,10,2,4, null) 
INSERT INTO FACTURAS VALUES ('2023-08-03',9,6,1,4, null) 
INSERT INTO FACTURAS VALUES ('2023-08-01',6,6,1,3, null) 
INSERT INTO FACTURAS VALUES ('2023-02-05',5,1,1,4, null) 
INSERT INTO FACTURAS VALUES ('2023-06-19',9,6,3,9, null) 
INSERT INTO FACTURAS VALUES ('2023-09-30',2,1,2,9, null) 
INSERT INTO FACTURAS VALUES ('2023-08-01',10,6,3,5, null) 
INSERT INTO FACTURAS VALUES ('2023-06-22',2,6,1,9, null) 
INSERT INTO FACTURAS VALUES ('2023-12-26',6,10,2,8, null) 
INSERT INTO FACTURAS VALUES ('2023-01-27',4,2,2,9, null) 
INSERT INTO FACTURAS VALUES ('2023-06-22',2,6,3,10, null) 
INSERT INTO FACTURAS VALUES ('2023-10-26',3,8,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-08-13',6,1,2,7, null) 
INSERT INTO FACTURAS VALUES ('2023-07-06',9,1,2,1, null) 
INSERT INTO FACTURAS VALUES ('2023-03-31',1,2,2,9, null) 
INSERT INTO FACTURAS VALUES ('2023-02-25',2,5,1,7, null) 
INSERT INTO FACTURAS VALUES ('2023-06-02',8,9,1,5, null) 
INSERT INTO FACTURAS VALUES ('2023-07-15',4,5,2,6, null) 
INSERT INTO FACTURAS VALUES ('2023-11-10',2,1,2,7, null) 
INSERT INTO FACTURAS VALUES ('2023-04-13',6,4,2,2, null) 
INSERT INTO FACTURAS VALUES ('2023-11-19',5,6,3,5, null) 
INSERT INTO FACTURAS VALUES ('2023-09-23',4,9,1,4, null) 
INSERT INTO FACTURAS VALUES ('2023-01-25',4,3,2,9, null) 
INSERT INTO FACTURAS VALUES ('2023-05-01',6,3,2,9, null) 
INSERT INTO FACTURAS VALUES ('2023-12-06',2,2,2,4, null) 
INSERT INTO FACTURAS VALUES ('2023-04-17',10,4,3,10, null) 
INSERT INTO FACTURAS VALUES ('2023-10-01',9,7,2,4, null) 
INSERT INTO FACTURAS VALUES ('2023-01-30',3,4,2,1, null) 
INSERT INTO FACTURAS VALUES ('2023-05-12',7,6,2,1, null) 
INSERT INTO FACTURAS VALUES ('2023-12-08',3,4,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-08-09',8,9,1,9, null) 
INSERT INTO FACTURAS VALUES ('2023-11-26',9,9,2,5, null) 
INSERT INTO FACTURAS VALUES ('2023-03-02',7,4,1,9, null) 
INSERT INTO FACTURAS VALUES ('2023-11-14',10,10,3,9, null) 
INSERT INTO FACTURAS VALUES ('2023-03-14',10,1,2,5, null) 
INSERT INTO FACTURAS VALUES ('2023-09-01',6,5,2,4, null) 
INSERT INTO FACTURAS VALUES ('2023-08-07',8,2,3,6, null) 
INSERT INTO FACTURAS VALUES ('2023-12-22',2,9,2,6, null) 
INSERT INTO FACTURAS VALUES ('2023-02-28',10,5,2,9, null) 
INSERT INTO FACTURAS VALUES ('2023-07-23',8,7,3,4, null) 
INSERT INTO FACTURAS VALUES ('2023-05-28',8,5,3,6, null) 
INSERT INTO FACTURAS VALUES ('2023-04-07',2,3,3,2, null) 
INSERT INTO FACTURAS VALUES ('2023-03-15',9,17,3,3, null) 
INSERT INTO FACTURAS VALUES ('2023-06-23',5,18,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-12-29',1,4,2,8, null) 
INSERT INTO FACTURAS VALUES ('2023-03-22',5,14,2,5, null) 
INSERT INTO FACTURAS VALUES ('2023-11-24',7,16,2,2, null) 
INSERT INTO FACTURAS VALUES ('2023-03-24',9,19,3,9, null) 
INSERT INTO FACTURAS VALUES ('2023-11-08',7,9,1,4, null) 
INSERT INTO FACTURAS VALUES ('2023-02-01',3,1,1,10, null) 
INSERT INTO FACTURAS VALUES ('2023-12-09',9,9,2,5, null) 
INSERT INTO FACTURAS VALUES ('2023-11-28',10,9,3,5, null) 
INSERT INTO FACTURAS VALUES ('2023-01-06',1,1,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-03-16',10,3,1,7, null) 
INSERT INTO FACTURAS VALUES ('2023-01-26',9,19,3,3, null) 
INSERT INTO FACTURAS VALUES ('2023-07-18',4,3,3,9, null) 
INSERT INTO FACTURAS VALUES ('2023-03-08',5,6,2,6, null) 
INSERT INTO FACTURAS VALUES ('2023-03-22',2,7,1,10, null) 
INSERT INTO FACTURAS VALUES ('2023-12-27',1,11,2,3, null) 
INSERT INTO FACTURAS VALUES ('2023-11-16',3,15,2,2, null) 
INSERT INTO FACTURAS VALUES ('2023-10-05',3,17,1,8, null) 
INSERT INTO FACTURAS VALUES ('2023-12-30',6,1,2,10, null) 
INSERT INTO FACTURAS VALUES ('2023-11-30',7,4,1,1, null) 
INSERT INTO FACTURAS VALUES ('2023-11-02',4,8,3,6, null) 
INSERT INTO FACTURAS VALUES ('2023-01-28',8,1,3,1, null) 
INSERT INTO FACTURAS VALUES ('2023-07-04',4,18,3,2, null) 
INSERT INTO FACTURAS VALUES ('2023-07-05',9,6,2,5, null) 
INSERT INTO FACTURAS VALUES ('2023-03-18',1,4,1,8, null) 
INSERT INTO FACTURAS VALUES ('2023-06-21',6,10,3,5, null) 
INSERT INTO FACTURAS VALUES ('2023-05-11',4,16,2,6, null) 
INSERT INTO FACTURAS VALUES ('2023-12-05',8,4,3,10, null) 
INSERT INTO FACTURAS VALUES ('2023-07-14',10,4,2,8, null) 
INSERT INTO FACTURAS VALUES ('2023-12-04',9,19,2,6, null) 
INSERT INTO FACTURAS VALUES ('2023-02-26',2,10,1,8, null) 
INSERT INTO FACTURAS VALUES ('2023-08-24',6,4,2,2, null) 
INSERT INTO FACTURAS VALUES ('2023-10-15',9,6,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-02-21',8,8,3,7, null) 
INSERT INTO FACTURAS VALUES ('2023-06-16',1,11,2,6, null) 
INSERT INTO FACTURAS VALUES ('2023-07-12',8,5,1,6, null) 
INSERT INTO FACTURAS VALUES ('2023-02-11',8,13,3,6, null) 
INSERT INTO FACTURAS VALUES ('2023-02-20',4,5,2,2, null) 
INSERT INTO FACTURAS VALUES ('2023-08-09',1,2,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-06-03',6,9,1,4, null) 
INSERT INTO FACTURAS VALUES ('2023-01-03',5,14,2,3, null) 
INSERT INTO FACTURAS VALUES ('2023-03-25',6,7,2,4, null) 
INSERT INTO FACTURAS VALUES ('2023-12-22',10,7,2,7, null) 
INSERT INTO FACTURAS VALUES ('2023-01-31',10,9,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-07-10',6,12,1,2, null) 
INSERT INTO FACTURAS VALUES ('2023-06-23',9,20,1,4, null) 
INSERT INTO FACTURAS VALUES ('2023-12-03',4,18,1,6, null) 
INSERT INTO FACTURAS VALUES ('2023-05-23',4,16,2,4, null) 
INSERT INTO FACTURAS VALUES ('2023-03-02',3,17,2,7, null) 

-- Detalles

INSERT INTO DETALLES_FACTURA VALUES (23,20,58,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (16,14,54,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),1, 0) 
INSERT INTO DETALLES_FACTURA VALUES (18,9,61,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (1,8,10,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),2, 0) 
INSERT INTO DETALLES_FACTURA VALUES (9,1,77,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (2,20,87,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (18,16,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (4,4,70,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),3, 0) 
INSERT INTO DETALLES_FACTURA VALUES (9,17,46,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (4,9,7,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (20,7,25,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (2,13,93,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (27,13,49,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),4, 0) 
INSERT INTO DETALLES_FACTURA VALUES (23,11,100,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),5, 0) 
INSERT INTO DETALLES_FACTURA VALUES (20,15,89,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),6, 0) 
INSERT INTO DETALLES_FACTURA VALUES (11,13,95,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),7, 0) 
INSERT INTO DETALLES_FACTURA VALUES (24,9,4,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (30,15,15,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),8, 0) 
INSERT INTO DETALLES_FACTURA VALUES (17,16,55,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),9, 0) 
INSERT INTO DETALLES_FACTURA VALUES (1,20,80,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),10, 0) 
INSERT INTO DETALLES_FACTURA VALUES (4,1,26,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),11, 0) 
INSERT INTO DETALLES_FACTURA VALUES (19,8,50,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),12, 0) 
INSERT INTO DETALLES_FACTURA VALUES (9,4,87,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),13, 0) 
INSERT INTO DETALLES_FACTURA VALUES (12,5,74,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),14, 0) 
INSERT INTO DETALLES_FACTURA VALUES (19,17,88,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (24,6,34,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),15, 0) 
INSERT INTO DETALLES_FACTURA VALUES (6,15,14,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),16, 0) 
INSERT INTO DETALLES_FACTURA VALUES (14,11,37,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),17, 0) 
INSERT INTO DETALLES_FACTURA VALUES (30,5,14,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),18, 0) 
INSERT INTO DETALLES_FACTURA VALUES (28,19,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),19, 0) 
INSERT INTO DETALLES_FACTURA VALUES (2,6,4,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),20, 0) 
INSERT INTO DETALLES_FACTURA VALUES (5,18,83,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (14,18,80,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (4,4,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (11,11,99,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (13,19,70,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (14,12,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (1,18,45,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (7,10,89,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (30,14,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (13,20,1,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (5,3,61,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (19,14,48,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (4,19,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (27,14,31,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (6,6,52,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (16,14,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (2,11,85,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (7,10,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (19,15,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 0) 
INSERT INTO DETALLES_FACTURA VALUES (7,14,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),1, 92.25) 
INSERT INTO DETALLES_FACTURA VALUES (8,19,27,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 83.7) 
INSERT INTO DETALLES_FACTURA VALUES (10,7,19,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 45.09) 
INSERT INTO DETALLES_FACTURA VALUES (21,4,100,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),2, 79.15) 
INSERT INTO DETALLES_FACTURA VALUES (2,8,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 1.59) 
INSERT INTO DETALLES_FACTURA VALUES (2,12,44,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 93.28) 
INSERT INTO DETALLES_FACTURA VALUES (9,13,88,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),3, 97.05) 
INSERT INTO DETALLES_FACTURA VALUES (30,11,94,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 6.23) 
INSERT INTO DETALLES_FACTURA VALUES (22,18,26,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 61.51) 
INSERT INTO DETALLES_FACTURA VALUES (2,5,66,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 9.47) 
INSERT INTO DETALLES_FACTURA VALUES (15,8,35,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),4, 38.38) 
INSERT INTO DETALLES_FACTURA VALUES (30,17,8,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),5, 53.73) 
INSERT INTO DETALLES_FACTURA VALUES (13,17,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),6, 64.02) 
INSERT INTO DETALLES_FACTURA VALUES (2,9,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 14.41) 
INSERT INTO DETALLES_FACTURA VALUES (24,19,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 21.09) 
INSERT INTO DETALLES_FACTURA VALUES (2,2,44,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),7, 36.49) 
INSERT INTO DETALLES_FACTURA VALUES (25,9,89,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 77.98) 
INSERT INTO DETALLES_FACTURA VALUES (20,16,22,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 6.06) 
INSERT INTO DETALLES_FACTURA VALUES (28,13,61,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),8, 12.61) 
INSERT INTO DETALLES_FACTURA VALUES (26,1,64,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 18.53) 
INSERT INTO DETALLES_FACTURA VALUES (1,11,19,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 75.43) 
INSERT INTO DETALLES_FACTURA VALUES (25,7,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 32.31) 
INSERT INTO DETALLES_FACTURA VALUES (11,5,93,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 83.51) 
INSERT INTO DETALLES_FACTURA VALUES (3,10,32,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 68.65) 
INSERT INTO DETALLES_FACTURA VALUES (17,20,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),9, 57.28) 
INSERT INTO DETALLES_FACTURA VALUES (18,17,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 13.95) 
INSERT INTO DETALLES_FACTURA VALUES (23,15,16,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 54.28) 
INSERT INTO DETALLES_FACTURA VALUES (9,1,73,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),10, 24.81) 
INSERT INTO DETALLES_FACTURA VALUES (13,2,67,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),11, 67.04) 
INSERT INTO DETALLES_FACTURA VALUES (24,5,63,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),12, 73.92) 
INSERT INTO DETALLES_FACTURA VALUES (5,5,45,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),13, 32.07) 
INSERT INTO DETALLES_FACTURA VALUES (9,18,8,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),14, 76.9) 
INSERT INTO DETALLES_FACTURA VALUES (2,16,2,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 80.11) 
INSERT INTO DETALLES_FACTURA VALUES (9,4,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 6.91) 
INSERT INTO DETALLES_FACTURA VALUES (9,17,81,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),15, 3.24) 
INSERT INTO DETALLES_FACTURA VALUES (13,6,25,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 29.9) 
INSERT INTO DETALLES_FACTURA VALUES (25,10,95,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 18.85) 
INSERT INTO DETALLES_FACTURA VALUES (28,16,44,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),16, 18.9) 
INSERT INTO DETALLES_FACTURA VALUES (20,12,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 64.08) 
INSERT INTO DETALLES_FACTURA VALUES (27,18,97,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 96.92) 
INSERT INTO DETALLES_FACTURA VALUES (4,14,55,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 5.23) 
INSERT INTO DETALLES_FACTURA VALUES (18,2,1,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 17.7) 
INSERT INTO DETALLES_FACTURA VALUES (21,18,22,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 67.76) 
INSERT INTO DETALLES_FACTURA VALUES (2,13,66,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 11.59) 
INSERT INTO DETALLES_FACTURA VALUES (28,17,7,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),17, 9.54) 
INSERT INTO DETALLES_FACTURA VALUES (9,18,92,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 45.77) 
INSERT INTO DETALLES_FACTURA VALUES (19,20,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 52.74) 
INSERT INTO DETALLES_FACTURA VALUES (25,17,39,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 69.45) 
INSERT INTO DETALLES_FACTURA VALUES (5,9,47,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),18, 8.47) 
INSERT INTO DETALLES_FACTURA VALUES (8,11,51,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),19, 48.82) 
INSERT INTO DETALLES_FACTURA VALUES (26,12,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 3.74) 
INSERT INTO DETALLES_FACTURA VALUES (2,7,71,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 90.21) 
INSERT INTO DETALLES_FACTURA VALUES (27,10,1,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 42.73) 
INSERT INTO DETALLES_FACTURA VALUES (30,13,76,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 82.4) 
INSERT INTO DETALLES_FACTURA VALUES (27,15,47,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),20, 72.75) 
INSERT INTO DETALLES_FACTURA VALUES (3,19,75,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 59.83) 
INSERT INTO DETALLES_FACTURA VALUES (15,5,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 81.7) 
INSERT INTO DETALLES_FACTURA VALUES (3,9,20,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 18.26) 
INSERT INTO DETALLES_FACTURA VALUES (3,4,25,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 71.48) 
INSERT INTO DETALLES_FACTURA VALUES (30,8,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 55.8) 
INSERT INTO DETALLES_FACTURA VALUES (26,9,97,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 40.13) 
INSERT INTO DETALLES_FACTURA VALUES (3,1,54,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 33.75) 
INSERT INTO DETALLES_FACTURA VALUES (2,15,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 2.66) 
INSERT INTO DETALLES_FACTURA VALUES (27,13,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 15.18) 
INSERT INTO DETALLES_FACTURA VALUES (11,10,14,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 53.3) 
INSERT INTO DETALLES_FACTURA VALUES (27,18,72,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 13.63) 
INSERT INTO DETALLES_FACTURA VALUES (27,14,47,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 28.14) 
INSERT INTO DETALLES_FACTURA VALUES (14,5,23,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 28.87) 
INSERT INTO DETALLES_FACTURA VALUES (28,1,77,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 64.54) 
INSERT INTO DETALLES_FACTURA VALUES (28,8,83,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 34.11) 
INSERT INTO DETALLES_FACTURA VALUES (4,6,44,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 91.47) 
INSERT INTO DETALLES_FACTURA VALUES (3,1,4,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 60.15) 
INSERT INTO DETALLES_FACTURA VALUES (17,5,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 58.05) 
INSERT INTO DETALLES_FACTURA VALUES (17,2,79,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 56.14) 
INSERT INTO DETALLES_FACTURA VALUES (16,3,37,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 10.24) 
INSERT INTO DETALLES_FACTURA VALUES (25,4,99,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 76.55) 
INSERT INTO DETALLES_FACTURA VALUES (4,7,46,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 89.56) 
INSERT INTO DETALLES_FACTURA VALUES (16,19,26,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 51.53) 
INSERT INTO DETALLES_FACTURA VALUES (16,19,38,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 93.93) 
INSERT INTO DETALLES_FACTURA VALUES (21,5,4,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 23.75) 
INSERT INTO DETALLES_FACTURA VALUES (19,18,89,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 5.2) 
INSERT INTO DETALLES_FACTURA VALUES (21,17,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 54.59) 
INSERT INTO DETALLES_FACTURA VALUES (24,6,5,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 68.98) 
INSERT INTO DETALLES_FACTURA VALUES (26,18,50,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 11.4) 
INSERT INTO DETALLES_FACTURA VALUES (20,7,8,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 44.02) 
INSERT INTO DETALLES_FACTURA VALUES (24,18,17,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 74.82) 
INSERT INTO DETALLES_FACTURA VALUES (29,17,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 94.25) 
INSERT INTO DETALLES_FACTURA VALUES (19,1,11,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 48.24) 
INSERT INTO DETALLES_FACTURA VALUES (28,6,74,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 59.24) 
INSERT INTO DETALLES_FACTURA VALUES (1,4,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 42.02) 
INSERT INTO DETALLES_FACTURA VALUES (27,16,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 13.3) 
INSERT INTO DETALLES_FACTURA VALUES (27,1,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 36.23) 
INSERT INTO DETALLES_FACTURA VALUES (7,2,90,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 58.31) 
INSERT INTO DETALLES_FACTURA VALUES (17,7,48,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 62.96) 
INSERT INTO DETALLES_FACTURA VALUES (25,5,42,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 90.46) 
INSERT INTO DETALLES_FACTURA VALUES (3,12,65,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 26.57) 
INSERT INTO DETALLES_FACTURA VALUES (17,11,53,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 81.94) 
INSERT INTO DETALLES_FACTURA VALUES (23,5,2,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 17.15) 
INSERT INTO DETALLES_FACTURA VALUES (20,8,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 62.39) 
INSERT INTO DETALLES_FACTURA VALUES (23,2,50,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 68.97) 
INSERT INTO DETALLES_FACTURA VALUES (2,14,41,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 32.23) 
INSERT INTO DETALLES_FACTURA VALUES (17,17,35,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 66.92) 
INSERT INTO DETALLES_FACTURA VALUES (16,17,60,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 5.51) 
INSERT INTO DETALLES_FACTURA VALUES (12,11,97,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 67.96) 
INSERT INTO DETALLES_FACTURA VALUES (18,11,19,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 57.09) 
INSERT INTO DETALLES_FACTURA VALUES (6,9,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 64.75) 
INSERT INTO DETALLES_FACTURA VALUES (6,4,37,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 6.34) 
INSERT INTO DETALLES_FACTURA VALUES (2,12,36,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 92.66) 
INSERT INTO DETALLES_FACTURA VALUES (8,20,76,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 54.13) 
INSERT INTO DETALLES_FACTURA VALUES (30,14,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 91.26) 
INSERT INTO DETALLES_FACTURA VALUES (19,14,52,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 53.5) 
INSERT INTO DETALLES_FACTURA VALUES (28,16,19,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 79.43) 
INSERT INTO DETALLES_FACTURA VALUES (10,9,23,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 25.56) 
INSERT INTO DETALLES_FACTURA VALUES (6,7,2,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 94.19) 
INSERT INTO DETALLES_FACTURA VALUES (4,14,7,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 62.05) 
INSERT INTO DETALLES_FACTURA VALUES (8,9,25,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 59.46) 
INSERT INTO DETALLES_FACTURA VALUES (4,8,54,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 91.02) 
INSERT INTO DETALLES_FACTURA VALUES (17,6,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 27.61) 
INSERT INTO DETALLES_FACTURA VALUES (1,2,11,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 90.01) 
INSERT INTO DETALLES_FACTURA VALUES (11,8,60,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 4.2) 
INSERT INTO DETALLES_FACTURA VALUES (17,20,99,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 34.95) 
INSERT INTO DETALLES_FACTURA VALUES (30,19,60,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 61.27) 
INSERT INTO DETALLES_FACTURA VALUES (10,11,2,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 97.09) 
INSERT INTO DETALLES_FACTURA VALUES (10,7,20,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 27.59) 
INSERT INTO DETALLES_FACTURA VALUES (2,20,70,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 13.8) 
INSERT INTO DETALLES_FACTURA VALUES (9,16,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 52.25) 
INSERT INTO DETALLES_FACTURA VALUES (27,8,81,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 56.29) 
INSERT INTO DETALLES_FACTURA VALUES (21,11,41,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 80.76) 
INSERT INTO DETALLES_FACTURA VALUES (14,4,39,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 86.28) 
INSERT INTO DETALLES_FACTURA VALUES (23,3,73,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 40.98) 
INSERT INTO DETALLES_FACTURA VALUES (1,2,42,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 80.42) 
INSERT INTO DETALLES_FACTURA VALUES (20,14,15,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 75.19) 
INSERT INTO DETALLES_FACTURA VALUES (24,7,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 35.66) 
INSERT INTO DETALLES_FACTURA VALUES (1,4,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 12.79) 
INSERT INTO DETALLES_FACTURA VALUES (23,12,61,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 25.75) 
INSERT INTO DETALLES_FACTURA VALUES (27,15,22,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 65.07) 
INSERT INTO DETALLES_FACTURA VALUES (23,18,99,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 19.04) 
INSERT INTO DETALLES_FACTURA VALUES (14,5,41,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 71.48) 
INSERT INTO DETALLES_FACTURA VALUES (14,12,70,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 53.9) 
INSERT INTO DETALLES_FACTURA VALUES (29,8,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 58.41) 
INSERT INTO DETALLES_FACTURA VALUES (12,5,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 73.66) 
INSERT INTO DETALLES_FACTURA VALUES (15,11,41,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 59.11) 
INSERT INTO DETALLES_FACTURA VALUES (30,10,48,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 24.02) 
INSERT INTO DETALLES_FACTURA VALUES (4,19,49,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 78.84) 
INSERT INTO DETALLES_FACTURA VALUES (29,10,12,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 91.59) 
INSERT INTO DETALLES_FACTURA VALUES (17,4,86,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 84.15) 
INSERT INTO DETALLES_FACTURA VALUES (27,13,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 95.11) 
INSERT INTO DETALLES_FACTURA VALUES (12,15,26,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 4.66) 
INSERT INTO DETALLES_FACTURA VALUES (15,1,7,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 5.93) 
INSERT INTO DETALLES_FACTURA VALUES (7,19,85,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 93.05) 
INSERT INTO DETALLES_FACTURA VALUES (5,17,37,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 12.95) 
INSERT INTO DETALLES_FACTURA VALUES (4,5,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 8.0) 
INSERT INTO DETALLES_FACTURA VALUES (9,18,81,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 75.71) 
INSERT INTO DETALLES_FACTURA VALUES (3,15,22,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 23.14) 
INSERT INTO DETALLES_FACTURA VALUES (24,12,12,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 10.33) 
INSERT INTO DETALLES_FACTURA VALUES (2,14,46,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 40.24) 
INSERT INTO DETALLES_FACTURA VALUES (7,7,23,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 17.8) 
INSERT INTO DETALLES_FACTURA VALUES (4,17,14,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 20.07) 
INSERT INTO DETALLES_FACTURA VALUES (22,11,99,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 65.06) 
INSERT INTO DETALLES_FACTURA VALUES (20,6,32,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 11.05) 
INSERT INTO DETALLES_FACTURA VALUES (7,13,73,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 49.15) 
INSERT INTO DETALLES_FACTURA VALUES (8,5,80,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 11.96) 
INSERT INTO DETALLES_FACTURA VALUES (12,1,37,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 70.16) 
INSERT INTO DETALLES_FACTURA VALUES (30,10,59,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 1.22) 
INSERT INTO DETALLES_FACTURA VALUES (11,13,68,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 58.91) 
INSERT INTO DETALLES_FACTURA VALUES (8,6,81,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 2.65) 
INSERT INTO DETALLES_FACTURA VALUES (4,16,28,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 85.83) 
INSERT INTO DETALLES_FACTURA VALUES (14,14,80,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 11.1) 
INSERT INTO DETALLES_FACTURA VALUES (10,16,42,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 94.78) 
INSERT INTO DETALLES_FACTURA VALUES (28,9,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 46.79) 
INSERT INTO DETALLES_FACTURA VALUES (12,17,8,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 57.98) 
INSERT INTO DETALLES_FACTURA VALUES (30,19,61,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 23.1) 
INSERT INTO DETALLES_FACTURA VALUES (5,11,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 15.22) 
INSERT INTO DETALLES_FACTURA VALUES (30,6,57,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 31.44) 
INSERT INTO DETALLES_FACTURA VALUES (17,14,97,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 49.92) 
INSERT INTO DETALLES_FACTURA VALUES (17,14,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 2.67) 
INSERT INTO DETALLES_FACTURA VALUES (10,10,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 54.93) 
INSERT INTO DETALLES_FACTURA VALUES (26,19,56,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 92.31) 
INSERT INTO DETALLES_FACTURA VALUES (11,3,68,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 22.48) 
INSERT INTO DETALLES_FACTURA VALUES (5,12,94,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 67.4) 
INSERT INTO DETALLES_FACTURA VALUES (2,3,24,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 92.97) 
INSERT INTO DETALLES_FACTURA VALUES (22,7,5,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 52.82) 
INSERT INTO DETALLES_FACTURA VALUES (16,11,23,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 72.04) 
INSERT INTO DETALLES_FACTURA VALUES (2,1,63,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 24.5) 
INSERT INTO DETALLES_FACTURA VALUES (3,7,9,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 70.06) 
INSERT INTO DETALLES_FACTURA VALUES (26,9,7,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 97.3) 
INSERT INTO DETALLES_FACTURA VALUES (18,14,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 59.0) 
INSERT INTO DETALLES_FACTURA VALUES (16,10,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 26.85) 
INSERT INTO DETALLES_FACTURA VALUES (14,14,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 89.08) 
INSERT INTO DETALLES_FACTURA VALUES (17,15,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 91.56) 
INSERT INTO DETALLES_FACTURA VALUES (24,19,93,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 3.87) 
INSERT INTO DETALLES_FACTURA VALUES (25,8,25,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 26.67) 
INSERT INTO DETALLES_FACTURA VALUES (30,17,64,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 60.09) 
INSERT INTO DETALLES_FACTURA VALUES (30,11,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 29.88) 
INSERT INTO DETALLES_FACTURA VALUES (25,6,41,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 76.07) 
INSERT INTO DETALLES_FACTURA VALUES (29,9,6,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 54.61) 
INSERT INTO DETALLES_FACTURA VALUES (19,19,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 67.24) 
INSERT INTO DETALLES_FACTURA VALUES (26,14,22,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 53.95) 
INSERT INTO DETALLES_FACTURA VALUES (9,3,88,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 49.18) 
INSERT INTO DETALLES_FACTURA VALUES (29,13,79,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 23.42) 
INSERT INTO DETALLES_FACTURA VALUES (50,2,86,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 88.99) 
INSERT INTO DETALLES_FACTURA VALUES (40,8,79,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),1, 56.25) 
INSERT INTO DETALLES_FACTURA VALUES (47,15,77,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 79.6) 
INSERT INTO DETALLES_FACTURA VALUES (49,20,5,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 37.97) 
INSERT INTO DETALLES_FACTURA VALUES (39,4,58,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 6.44) 
INSERT INTO DETALLES_FACTURA VALUES (36,7,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),2, 66.36) 
INSERT INTO DETALLES_FACTURA VALUES (37,11,20,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),3, 50.53) 
INSERT INTO DETALLES_FACTURA VALUES (49,18,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),4, 56.59) 
INSERT INTO DETALLES_FACTURA VALUES (43,4,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 8.75) 
INSERT INTO DETALLES_FACTURA VALUES (42,6,94,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 86.52) 
INSERT INTO DETALLES_FACTURA VALUES (30,3,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),5, 55.36) 
INSERT INTO DETALLES_FACTURA VALUES (39,2,33,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 11.89) 
INSERT INTO DETALLES_FACTURA VALUES (45,8,1,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 53.97) 
INSERT INTO DETALLES_FACTURA VALUES (33,19,70,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),6, 43.78) 
INSERT INTO DETALLES_FACTURA VALUES (43,5,15,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 75.79) 
INSERT INTO DETALLES_FACTURA VALUES (37,3,75,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),7, 63.41) 
INSERT INTO DETALLES_FACTURA VALUES (45,7,80,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),8, 17.96) 
INSERT INTO DETALLES_FACTURA VALUES (49,20,99,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 26.41) 
INSERT INTO DETALLES_FACTURA VALUES (31,2,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 37.94) 
INSERT INTO DETALLES_FACTURA VALUES (41,8,74,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 92.28) 
INSERT INTO DETALLES_FACTURA VALUES (32,13,17,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),9, 43.85) 
INSERT INTO DETALLES_FACTURA VALUES (45,3,60,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),10, 75.26) 
INSERT INTO DETALLES_FACTURA VALUES (45,19,46,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 16.02) 
INSERT INTO DETALLES_FACTURA VALUES (46,10,6,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 89.46) 
INSERT INTO DETALLES_FACTURA VALUES (30,12,92,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),11, 76.4) 
INSERT INTO DETALLES_FACTURA VALUES (30,18,86,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 58.47) 
INSERT INTO DETALLES_FACTURA VALUES (38,12,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),12, 1.7) 
INSERT INTO DETALLES_FACTURA VALUES (49,10,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 7.72) 
INSERT INTO DETALLES_FACTURA VALUES (45,7,46,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 67.86) 
INSERT INTO DETALLES_FACTURA VALUES (49,19,58,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),13, 10.65) 
INSERT INTO DETALLES_FACTURA VALUES (30,9,59,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 98.32) 
INSERT INTO DETALLES_FACTURA VALUES (45,11,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 42.65) 
INSERT INTO DETALLES_FACTURA VALUES (32,10,71,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),14, 9.55) 
INSERT INTO DETALLES_FACTURA VALUES (46,16,83,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),15, 87.67) 
INSERT INTO DETALLES_FACTURA VALUES (32,2,15,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),16, 78.51) 
INSERT INTO DETALLES_FACTURA VALUES (36,20,12,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),17, 73.66) 
INSERT INTO DETALLES_FACTURA VALUES (42,19,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),18, 65.87) 
INSERT INTO DETALLES_FACTURA VALUES (37,20,75,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),19, 93.98) 
INSERT INTO DETALLES_FACTURA VALUES (45,15,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),20, 16.94) 
INSERT INTO DETALLES_FACTURA VALUES (49,17,54,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 20.97) 
INSERT INTO DETALLES_FACTURA VALUES (49,18,86,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 25.65) 
INSERT INTO DETALLES_FACTURA VALUES (41,20,5,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 31.33) 
INSERT INTO DETALLES_FACTURA VALUES (47,6,11,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 21.94) 
INSERT INTO DETALLES_FACTURA VALUES (45,12,23,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 39.84) 
INSERT INTO DETALLES_FACTURA VALUES (39,2,50,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 31.16) 
INSERT INTO DETALLES_FACTURA VALUES (50,19,66,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 82.75) 
INSERT INTO DETALLES_FACTURA VALUES (43,20,48,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 86.11) 
INSERT INTO DETALLES_FACTURA VALUES (40,5,66,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 75.09) 
INSERT INTO DETALLES_FACTURA VALUES (32,16,11,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 85.85) 
INSERT INTO DETALLES_FACTURA VALUES (48,2,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 16.27) 
INSERT INTO DETALLES_FACTURA VALUES (44,5,85,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 10.12) 
INSERT INTO DETALLES_FACTURA VALUES (40,5,48,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 63.57) 
INSERT INTO DETALLES_FACTURA VALUES (45,12,83,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 37.92) 
INSERT INTO DETALLES_FACTURA VALUES (49,19,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 67.51) 
INSERT INTO DETALLES_FACTURA VALUES (40,6,95,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 63.48) 
INSERT INTO DETALLES_FACTURA VALUES (47,20,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 55.94) 
INSERT INTO DETALLES_FACTURA VALUES (31,3,61,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 98.37) 
INSERT INTO DETALLES_FACTURA VALUES (41,13,99,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 35.85) 
INSERT INTO DETALLES_FACTURA VALUES (40,4,45,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 46.69) 
INSERT INTO DETALLES_FACTURA VALUES (34,12,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 48.95) 
INSERT INTO DETALLES_FACTURA VALUES (46,3,31,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 73.19) 
INSERT INTO DETALLES_FACTURA VALUES (31,20,52,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 4.92) 
INSERT INTO DETALLES_FACTURA VALUES (33,8,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 86.38) 
INSERT INTO DETALLES_FACTURA VALUES (33,13,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 54.52) 
INSERT INTO DETALLES_FACTURA VALUES (30,7,28,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 17.71) 
INSERT INTO DETALLES_FACTURA VALUES (47,15,100,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 77.34) 
INSERT INTO DETALLES_FACTURA VALUES (43,15,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 98.28) 
INSERT INTO DETALLES_FACTURA VALUES (34,8,4,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 75.85) 
INSERT INTO DETALLES_FACTURA VALUES (39,11,18,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 20.75) 
INSERT INTO DETALLES_FACTURA VALUES (36,3,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 68.57) 
INSERT INTO DETALLES_FACTURA VALUES (47,17,12,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 96.52) 
INSERT INTO DETALLES_FACTURA VALUES (41,17,7,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 55.7) 
INSERT INTO DETALLES_FACTURA VALUES (48,4,75,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 72.23) 
INSERT INTO DETALLES_FACTURA VALUES (34,2,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 73.43) 
INSERT INTO DETALLES_FACTURA VALUES (37,12,60,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 14.8) 
INSERT INTO DETALLES_FACTURA VALUES (42,13,56,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 53.2) 
INSERT INTO DETALLES_FACTURA VALUES (41,8,56,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 47.9) 
INSERT INTO DETALLES_FACTURA VALUES (36,9,25,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 42.5) 
INSERT INTO DETALLES_FACTURA VALUES (30,15,8,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 45.27) 
INSERT INTO DETALLES_FACTURA VALUES (32,4,26,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 52.46) 
INSERT INTO DETALLES_FACTURA VALUES (49,16,57,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 93.3) 
INSERT INTO DETALLES_FACTURA VALUES (31,6,17,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 96.29) 
INSERT INTO DETALLES_FACTURA VALUES (30,16,47,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 73.38) 
INSERT INTO DETALLES_FACTURA VALUES (37,10,83,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 86.94) 
INSERT INTO DETALLES_FACTURA VALUES (46,5,60,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 11.95) 
INSERT INTO DETALLES_FACTURA VALUES (31,8,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 7.35) 
INSERT INTO DETALLES_FACTURA VALUES (35,1,59,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 3.98) 
INSERT INTO DETALLES_FACTURA VALUES (50,18,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 4.81) 
INSERT INTO DETALLES_FACTURA VALUES (35,9,36,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 91.23) 
INSERT INTO DETALLES_FACTURA VALUES (48,15,28,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 3.16) 
INSERT INTO DETALLES_FACTURA VALUES (31,3,51,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 24.49) 
INSERT INTO DETALLES_FACTURA VALUES (49,5,69,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 6.58) 
INSERT INTO DETALLES_FACTURA VALUES (38,16,85,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 44.55) 
INSERT INTO DETALLES_FACTURA VALUES (35,13,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 26.71) 
INSERT INTO DETALLES_FACTURA VALUES (49,9,96,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 27.02) 
INSERT INTO DETALLES_FACTURA VALUES (36,10,6,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 26.02) 
INSERT INTO DETALLES_FACTURA VALUES (40,17,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 18.6) 
INSERT INTO DETALLES_FACTURA VALUES (41,13,2,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 58.3) 
INSERT INTO DETALLES_FACTURA VALUES (35,6,57,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 59.79) 
INSERT INTO DETALLES_FACTURA VALUES (41,3,71,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 10.08) 
INSERT INTO DETALLES_FACTURA VALUES (67,5,54,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 93.54) 
INSERT INTO DETALLES_FACTURA VALUES (52,14,64,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 55.63) 
INSERT INTO DETALLES_FACTURA VALUES (94,14,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 87.99) 
INSERT INTO DETALLES_FACTURA VALUES (76,29,41,(SELECT pre_unitario FROM productos WHERE cod_producto = 29),null, 63.94) 
INSERT INTO DETALLES_FACTURA VALUES (57,29,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 29),null, 78.02) 
INSERT INTO DETALLES_FACTURA VALUES (57,29,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 29),null, 24.39) 
INSERT INTO DETALLES_FACTURA VALUES (77,36,74,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 8.2) 
INSERT INTO DETALLES_FACTURA VALUES (81,24,85,(SELECT pre_unitario FROM productos WHERE cod_producto = 24),null, 70.11) 
INSERT INTO DETALLES_FACTURA VALUES (79,33,16,(SELECT pre_unitario FROM productos WHERE cod_producto = 33),null, 30.65) 
INSERT INTO DETALLES_FACTURA VALUES (74,30,19,(SELECT pre_unitario FROM productos WHERE cod_producto = 30),null, 33.04) 
INSERT INTO DETALLES_FACTURA VALUES (57,3,16,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 8.54) 
INSERT INTO DETALLES_FACTURA VALUES (100,40,8,(SELECT pre_unitario FROM productos WHERE cod_producto = 40),null, 22.66) 
INSERT INTO DETALLES_FACTURA VALUES (73,23,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 23),null, 78.17) 
INSERT INTO DETALLES_FACTURA VALUES (80,28,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 28),null, 35.9) 
INSERT INTO DETALLES_FACTURA VALUES (60,13,6,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 71.83) 
INSERT INTO DETALLES_FACTURA VALUES (69,21,39,(SELECT pre_unitario FROM productos WHERE cod_producto = 21),null, 24.0) 
INSERT INTO DETALLES_FACTURA VALUES (67,3,92,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 61.1) 
INSERT INTO DETALLES_FACTURA VALUES (53,6,83,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 82.75) 
INSERT INTO DETALLES_FACTURA VALUES (92,36,87,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 39.16) 
INSERT INTO DETALLES_FACTURA VALUES (66,19,85,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 93.22) 
INSERT INTO DETALLES_FACTURA VALUES (99,34,88,(SELECT pre_unitario FROM productos WHERE cod_producto = 34),null, 35.24) 
INSERT INTO DETALLES_FACTURA VALUES (70,35,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 35),null, 74.89) 
INSERT INTO DETALLES_FACTURA VALUES (66,30,38,(SELECT pre_unitario FROM productos WHERE cod_producto = 30),null, 15.34) 
INSERT INTO DETALLES_FACTURA VALUES (79,21,11,(SELECT pre_unitario FROM productos WHERE cod_producto = 21),null, 22.08) 
INSERT INTO DETALLES_FACTURA VALUES (77,22,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 22),null, 92.41) 
INSERT INTO DETALLES_FACTURA VALUES (55,1,11,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 93.13) 
INSERT INTO DETALLES_FACTURA VALUES (83,31,45,(SELECT pre_unitario FROM productos WHERE cod_producto = 31),null, 35.82) 
INSERT INTO DETALLES_FACTURA VALUES (73,10,87,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 52.48) 
INSERT INTO DETALLES_FACTURA VALUES (70,18,93,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 24.28) 
INSERT INTO DETALLES_FACTURA VALUES (74,9,64,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 87.46) 
INSERT INTO DETALLES_FACTURA VALUES (73,14,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 31.27) 
INSERT INTO DETALLES_FACTURA VALUES (76,14,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 84.64) 
INSERT INTO DETALLES_FACTURA VALUES (96,15,61,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 86.84) 
INSERT INTO DETALLES_FACTURA VALUES (90,16,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 96.93) 
INSERT INTO DETALLES_FACTURA VALUES (69,38,33,(SELECT pre_unitario FROM productos WHERE cod_producto = 38),null, 63.46) 
INSERT INTO DETALLES_FACTURA VALUES (75,2,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 61.32) 
INSERT INTO DETALLES_FACTURA VALUES (96,12,12,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 82.87) 
INSERT INTO DETALLES_FACTURA VALUES (94,20,77,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 25.39) 
INSERT INTO DETALLES_FACTURA VALUES (52,23,20,(SELECT pre_unitario FROM productos WHERE cod_producto = 23),null, 29.91) 
INSERT INTO DETALLES_FACTURA VALUES (70,2,97,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 57.34) 
INSERT INTO DETALLES_FACTURA VALUES (51,23,16,(SELECT pre_unitario FROM productos WHERE cod_producto = 23),null, 68.04) 
INSERT INTO DETALLES_FACTURA VALUES (82,20,27,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 5.39) 
INSERT INTO DETALLES_FACTURA VALUES (75,33,57,(SELECT pre_unitario FROM productos WHERE cod_producto = 33),null, 58.32) 
INSERT INTO DETALLES_FACTURA VALUES (69,5,59,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 77.88) 
INSERT INTO DETALLES_FACTURA VALUES (65,34,59,(SELECT pre_unitario FROM productos WHERE cod_producto = 34),null, 81.93) 
INSERT INTO DETALLES_FACTURA VALUES (66,24,69,(SELECT pre_unitario FROM productos WHERE cod_producto = 24),null, 85.09) 
INSERT INTO DETALLES_FACTURA VALUES (97,11,63,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 31.76) 
INSERT INTO DETALLES_FACTURA VALUES (92,34,76,(SELECT pre_unitario FROM productos WHERE cod_producto = 34),null, 38.18) 
INSERT INTO DETALLES_FACTURA VALUES (71,12,34,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 95.79) 
INSERT INTO DETALLES_FACTURA VALUES (85,11,97,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 88.78) 
INSERT INTO DETALLES_FACTURA VALUES (70,36,11,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 93.9) 
INSERT INTO DETALLES_FACTURA VALUES (64,40,36,(SELECT pre_unitario FROM productos WHERE cod_producto = 40),null, 16.06) 
INSERT INTO DETALLES_FACTURA VALUES (68,16,96,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 32.51) 
INSERT INTO DETALLES_FACTURA VALUES (83,26,100,(SELECT pre_unitario FROM productos WHERE cod_producto = 26),null, 67.45) 
INSERT INTO DETALLES_FACTURA VALUES (100,3,58,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 32.5) 
INSERT INTO DETALLES_FACTURA VALUES (91,40,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 40),null, 14.84) 
INSERT INTO DETALLES_FACTURA VALUES (89,20,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 74.44) 
INSERT INTO DETALLES_FACTURA VALUES (58,1,49,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 73.86) 
INSERT INTO DETALLES_FACTURA VALUES (54,39,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 39),null, 14.54) 
INSERT INTO DETALLES_FACTURA VALUES (62,17,6,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 82.14) 
INSERT INTO DETALLES_FACTURA VALUES (55,38,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 38),null, 94.23) 
INSERT INTO DETALLES_FACTURA VALUES (95,39,9,(SELECT pre_unitario FROM productos WHERE cod_producto = 39),null, 40.05) 
INSERT INTO DETALLES_FACTURA VALUES (71,9,96,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 61.15) 
INSERT INTO DETALLES_FACTURA VALUES (61,3,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 71.06) 
INSERT INTO DETALLES_FACTURA VALUES (62,39,36,(SELECT pre_unitario FROM productos WHERE cod_producto = 39),null, 63.46) 
INSERT INTO DETALLES_FACTURA VALUES (52,3,69,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 54.78) 
INSERT INTO DETALLES_FACTURA VALUES (99,30,90,(SELECT pre_unitario FROM productos WHERE cod_producto = 30),null, 66.2) 
INSERT INTO DETALLES_FACTURA VALUES (72,21,66,(SELECT pre_unitario FROM productos WHERE cod_producto = 21),null, 23.81) 
INSERT INTO DETALLES_FACTURA VALUES (99,12,58,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 45.96) 
INSERT INTO DETALLES_FACTURA VALUES (93,30,76,(SELECT pre_unitario FROM productos WHERE cod_producto = 30),null, 72.35) 
INSERT INTO DETALLES_FACTURA VALUES (55,12,28,(SELECT pre_unitario FROM productos WHERE cod_producto = 12),null, 11.59) 
INSERT INTO DETALLES_FACTURA VALUES (74,28,39,(SELECT pre_unitario FROM productos WHERE cod_producto = 28),null, 77.31) 
INSERT INTO DETALLES_FACTURA VALUES (71,25,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 25),null, 51.99) 
INSERT INTO DETALLES_FACTURA VALUES (69,25,10,(SELECT pre_unitario FROM productos WHERE cod_producto = 25),null, 92.43) 
INSERT INTO DETALLES_FACTURA VALUES (79,34,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 34),null, 86.32) 
INSERT INTO DETALLES_FACTURA VALUES (55,37,38,(SELECT pre_unitario FROM productos WHERE cod_producto = 37),null, 17.42) 
INSERT INTO DETALLES_FACTURA VALUES (52,19,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 57.97) 
INSERT INTO DETALLES_FACTURA VALUES (67,31,23,(SELECT pre_unitario FROM productos WHERE cod_producto = 31),null, 46.02) 
INSERT INTO DETALLES_FACTURA VALUES (54,40,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 40),null, 96.94) 
INSERT INTO DETALLES_FACTURA VALUES (57,2,34,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 78.33) 
INSERT INTO DETALLES_FACTURA VALUES (65,36,50,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 56.93) 
INSERT INTO DETALLES_FACTURA VALUES (99,30,93,(SELECT pre_unitario FROM productos WHERE cod_producto = 30),null, 88.48) 
INSERT INTO DETALLES_FACTURA VALUES (59,3,37,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 78.99) 
INSERT INTO DETALLES_FACTURA VALUES (98,19,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 45.38) 
INSERT INTO DETALLES_FACTURA VALUES (61,19,79,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 20.92) 
INSERT INTO DETALLES_FACTURA VALUES (90,2,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 30.74) 
INSERT INTO DETALLES_FACTURA VALUES (59,4,5,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 29.43) 
INSERT INTO DETALLES_FACTURA VALUES (57,13,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 31.77) 
INSERT INTO DETALLES_FACTURA VALUES (98,36,94,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 46.91) 
INSERT INTO DETALLES_FACTURA VALUES (75,8,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 41.34) 
INSERT INTO DETALLES_FACTURA VALUES (100,13,67,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 8.9) 
INSERT INTO DETALLES_FACTURA VALUES (82,15,23,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 21.49) 
INSERT INTO DETALLES_FACTURA VALUES (65,35,68,(SELECT pre_unitario FROM productos WHERE cod_producto = 35),null, 91.67) 
INSERT INTO DETALLES_FACTURA VALUES (51,10,43,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 5.38) 
INSERT INTO DETALLES_FACTURA VALUES (73,4,77,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 4.61) 
INSERT INTO DETALLES_FACTURA VALUES (68,8,35,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 95.06) 
INSERT INTO DETALLES_FACTURA VALUES (97,22,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 22),null, 66.93) 
INSERT INTO DETALLES_FACTURA VALUES (90,10,44,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 33.18) 
INSERT INTO DETALLES_FACTURA VALUES (80,9,44,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 45.37) 
INSERT INTO DETALLES_FACTURA VALUES (76,36,88,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 22.2) 
INSERT INTO DETALLES_FACTURA VALUES (56,22,16,(SELECT pre_unitario FROM productos WHERE cod_producto = 22),null, 58.71) 
INSERT INTO DETALLES_FACTURA VALUES (93,25,49,(SELECT pre_unitario FROM productos WHERE cod_producto = 25),null, 42.43) 
INSERT INTO DETALLES_FACTURA VALUES (77,32,95,(SELECT pre_unitario FROM productos WHERE cod_producto = 32),null, 90.09) 
INSERT INTO DETALLES_FACTURA VALUES (64,18,5,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 78.48) 
INSERT INTO DETALLES_FACTURA VALUES (78,18,95,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 55.36) 
INSERT INTO DETALLES_FACTURA VALUES (97,2,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 30.66) 
INSERT INTO DETALLES_FACTURA VALUES (92,38,51,(SELECT pre_unitario FROM productos WHERE cod_producto = 38),null, 25.39) 
INSERT INTO DETALLES_FACTURA VALUES (59,34,13,(SELECT pre_unitario FROM productos WHERE cod_producto = 34),null, 74.08) 
INSERT INTO DETALLES_FACTURA VALUES (62,14,93,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 59.49) 
INSERT INTO DETALLES_FACTURA VALUES (84,9,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 9),null, 73.65) 
INSERT INTO DETALLES_FACTURA VALUES (100,39,17,(SELECT pre_unitario FROM productos WHERE cod_producto = 39),null, 64.7) 
INSERT INTO DETALLES_FACTURA VALUES (73,15,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 81.81) 
INSERT INTO DETALLES_FACTURA VALUES (99,14,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 46.4) 
INSERT INTO DETALLES_FACTURA VALUES (58,25,50,(SELECT pre_unitario FROM productos WHERE cod_producto = 25),null, 24.08) 
INSERT INTO DETALLES_FACTURA VALUES (78,34,31,(SELECT pre_unitario FROM productos WHERE cod_producto = 34),null, 73.87) 
INSERT INTO DETALLES_FACTURA VALUES (53,14,55,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 15.01) 
INSERT INTO DETALLES_FACTURA VALUES (58,16,88,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 93.26) 
INSERT INTO DETALLES_FACTURA VALUES (68,23,6,(SELECT pre_unitario FROM productos WHERE cod_producto = 23),null, 20.32) 
INSERT INTO DETALLES_FACTURA VALUES (63,37,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 37),null, 96.7) 
INSERT INTO DETALLES_FACTURA VALUES (59,4,42,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 92.51) 
INSERT INTO DETALLES_FACTURA VALUES (76,29,16,(SELECT pre_unitario FROM productos WHERE cod_producto = 29),null, 57.04) 
INSERT INTO DETALLES_FACTURA VALUES (94,38,41,(SELECT pre_unitario FROM productos WHERE cod_producto = 38),null, 17.98) 
INSERT INTO DETALLES_FACTURA VALUES (94,38,39,(SELECT pre_unitario FROM productos WHERE cod_producto = 38),null, 32.84) 
INSERT INTO DETALLES_FACTURA VALUES (74,11,86,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 34.36) 
INSERT INTO DETALLES_FACTURA VALUES (97,10,83,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 24.53) 
INSERT INTO DETALLES_FACTURA VALUES (87,26,63,(SELECT pre_unitario FROM productos WHERE cod_producto = 26),null, 79.52) 
INSERT INTO DETALLES_FACTURA VALUES (85,25,73,(SELECT pre_unitario FROM productos WHERE cod_producto = 25),null, 49.07) 
INSERT INTO DETALLES_FACTURA VALUES (89,28,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 28),null, 1.69) 
INSERT INTO DETALLES_FACTURA VALUES (89,17,30,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 15.21) 
INSERT INTO DETALLES_FACTURA VALUES (70,39,72,(SELECT pre_unitario FROM productos WHERE cod_producto = 39),null, 34.11) 
INSERT INTO DETALLES_FACTURA VALUES (69,13,71,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 10.89) 
INSERT INTO DETALLES_FACTURA VALUES (87,28,90,(SELECT pre_unitario FROM productos WHERE cod_producto = 28),null, 25.89) 
INSERT INTO DETALLES_FACTURA VALUES (71,39,12,(SELECT pre_unitario FROM productos WHERE cod_producto = 39),null, 26.66) 
INSERT INTO DETALLES_FACTURA VALUES (66,17,89,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 8.6) 
INSERT INTO DETALLES_FACTURA VALUES (96,21,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 21),null, 95.68) 
INSERT INTO DETALLES_FACTURA VALUES (77,10,87,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 72.7) 
INSERT INTO DETALLES_FACTURA VALUES (90,18,100,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 17.75) 
INSERT INTO DETALLES_FACTURA VALUES (75,22,40,(SELECT pre_unitario FROM productos WHERE cod_producto = 22),null, 45.75) 
INSERT INTO DETALLES_FACTURA VALUES (67,14,28,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 39.31) 
INSERT INTO DETALLES_FACTURA VALUES (71,36,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 23.19) 
INSERT INTO DETALLES_FACTURA VALUES (65,14,93,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 46.93) 
INSERT INTO DETALLES_FACTURA VALUES (61,6,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 6),null, 34.98) 
INSERT INTO DETALLES_FACTURA VALUES (82,14,67,(SELECT pre_unitario FROM productos WHERE cod_producto = 14),null, 7.7) 
INSERT INTO DETALLES_FACTURA VALUES (96,22,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 22),null, 94.62) 
INSERT INTO DETALLES_FACTURA VALUES (90,3,67,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 42.47) 
INSERT INTO DETALLES_FACTURA VALUES (70,13,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 25.39) 
INSERT INTO DETALLES_FACTURA VALUES (52,31,75,(SELECT pre_unitario FROM productos WHERE cod_producto = 31),null, 86.91) 
INSERT INTO DETALLES_FACTURA VALUES (97,19,85,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 96.83) 
INSERT INTO DETALLES_FACTURA VALUES (97,36,91,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 81.6) 
INSERT INTO DETALLES_FACTURA VALUES (55,17,44,(SELECT pre_unitario FROM productos WHERE cod_producto = 17),null, 58.31) 
INSERT INTO DETALLES_FACTURA VALUES (63,16,20,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 68.09) 
INSERT INTO DETALLES_FACTURA VALUES (97,34,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 34),null, 13.88) 
INSERT INTO DETALLES_FACTURA VALUES (52,3,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 38.57) 
INSERT INTO DETALLES_FACTURA VALUES (56,24,100,(SELECT pre_unitario FROM productos WHERE cod_producto = 24),null, 92.83) 
INSERT INTO DETALLES_FACTURA VALUES (97,30,70,(SELECT pre_unitario FROM productos WHERE cod_producto = 30),null, 15.3) 
INSERT INTO DETALLES_FACTURA VALUES (77,19,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 19),null, 69.08) 
INSERT INTO DETALLES_FACTURA VALUES (52,31,97,(SELECT pre_unitario FROM productos WHERE cod_producto = 31),null, 86.68) 
INSERT INTO DETALLES_FACTURA VALUES (63,40,37,(SELECT pre_unitario FROM productos WHERE cod_producto = 40),null, 33.05) 
INSERT INTO DETALLES_FACTURA VALUES (85,16,62,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 45.88) 
INSERT INTO DETALLES_FACTURA VALUES (79,36,49,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 50.62) 
INSERT INTO DETALLES_FACTURA VALUES (63,10,72,(SELECT pre_unitario FROM productos WHERE cod_producto = 10),null, 96.21) 
INSERT INTO DETALLES_FACTURA VALUES (67,36,42,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 57.44) 
INSERT INTO DETALLES_FACTURA VALUES (91,4,29,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 94.34) 
INSERT INTO DETALLES_FACTURA VALUES (69,33,31,(SELECT pre_unitario FROM productos WHERE cod_producto = 33),null, 80.3) 
INSERT INTO DETALLES_FACTURA VALUES (70,1,5,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 28.58) 
INSERT INTO DETALLES_FACTURA VALUES (90,28,65,(SELECT pre_unitario FROM productos WHERE cod_producto = 28),null, 75.14) 
INSERT INTO DETALLES_FACTURA VALUES (59,37,89,(SELECT pre_unitario FROM productos WHERE cod_producto = 37),null, 58.31) 
INSERT INTO DETALLES_FACTURA VALUES (54,8,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 48.99) 
INSERT INTO DETALLES_FACTURA VALUES (95,3,53,(SELECT pre_unitario FROM productos WHERE cod_producto = 3),null, 87.42) 
INSERT INTO DETALLES_FACTURA VALUES (78,31,55,(SELECT pre_unitario FROM productos WHERE cod_producto = 31),null, 42.57) 
INSERT INTO DETALLES_FACTURA VALUES (67,1,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 33.46) 
INSERT INTO DETALLES_FACTURA VALUES (75,24,66,(SELECT pre_unitario FROM productos WHERE cod_producto = 24),null, 65.88) 
INSERT INTO DETALLES_FACTURA VALUES (73,16,36,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 14.33) 
INSERT INTO DETALLES_FACTURA VALUES (68,20,38,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 41.59) 
INSERT INTO DETALLES_FACTURA VALUES (82,15,98,(SELECT pre_unitario FROM productos WHERE cod_producto = 15),null, 65.36) 
INSERT INTO DETALLES_FACTURA VALUES (95,8,100,(SELECT pre_unitario FROM productos WHERE cod_producto = 8),null, 85.11) 
INSERT INTO DETALLES_FACTURA VALUES (56,32,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 32),null, 47.7) 
INSERT INTO DETALLES_FACTURA VALUES (91,7,78,(SELECT pre_unitario FROM productos WHERE cod_producto = 7),null, 4.94) 
INSERT INTO DETALLES_FACTURA VALUES (73,37,3,(SELECT pre_unitario FROM productos WHERE cod_producto = 37),null, 35.03) 
INSERT INTO DETALLES_FACTURA VALUES (87,11,95,(SELECT pre_unitario FROM productos WHERE cod_producto = 11),null, 5.86) 
INSERT INTO DETALLES_FACTURA VALUES (100,25,14,(SELECT pre_unitario FROM productos WHERE cod_producto = 25),null, 11.97) 
INSERT INTO DETALLES_FACTURA VALUES (77,31,82,(SELECT pre_unitario FROM productos WHERE cod_producto = 31),null, 8.47) 
INSERT INTO DETALLES_FACTURA VALUES (61,20,94,(SELECT pre_unitario FROM productos WHERE cod_producto = 20),null, 33.46) 
INSERT INTO DETALLES_FACTURA VALUES (93,1,9,(SELECT pre_unitario FROM productos WHERE cod_producto = 1),null, 79.78) 
INSERT INTO DETALLES_FACTURA VALUES (61,16,74,(SELECT pre_unitario FROM productos WHERE cod_producto = 16),null, 32.01) 
INSERT INTO DETALLES_FACTURA VALUES (70,24,84,(SELECT pre_unitario FROM productos WHERE cod_producto = 24),null, 36.28) 
INSERT INTO DETALLES_FACTURA VALUES (93,22,58,(SELECT pre_unitario FROM productos WHERE cod_producto = 22),null, 14.63) 
INSERT INTO DETALLES_FACTURA VALUES (65,24,19,(SELECT pre_unitario FROM productos WHERE cod_producto = 24),null, 30.38) 
INSERT INTO DETALLES_FACTURA VALUES (66,36,87,(SELECT pre_unitario FROM productos WHERE cod_producto = 36),null, 66.29) 
INSERT INTO DETALLES_FACTURA VALUES (61,27,47,(SELECT pre_unitario FROM productos WHERE cod_producto = 27),null, 59.51) 
INSERT INTO DETALLES_FACTURA VALUES (74,2,94,(SELECT pre_unitario FROM productos WHERE cod_producto = 2),null, 7.81) 
INSERT INTO DETALLES_FACTURA VALUES (85,5,8,(SELECT pre_unitario FROM productos WHERE cod_producto = 5),null, 79.44) 
INSERT INTO DETALLES_FACTURA VALUES (51,4,71,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 77.87) 
INSERT INTO DETALLES_FACTURA VALUES (65,13,55,(SELECT pre_unitario FROM productos WHERE cod_producto = 13),null, 54.79) 
INSERT INTO DETALLES_FACTURA VALUES (64,4,21,(SELECT pre_unitario FROM productos WHERE cod_producto = 4),null, 88.08) 
INSERT INTO DETALLES_FACTURA VALUES (86,18,67,(SELECT pre_unitario FROM productos WHERE cod_producto = 18),null, 24.0) 

-- STOCK_SUCURSAL


INSERT INTO STOCK_SUCURSALES
VALUES (1, 1, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 1 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 1, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 1 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 1, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 1 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 2, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 2 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 2, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 2 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 2, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 2 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 3, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 3 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 3, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 3 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 3, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 3 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 4, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 4 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 4, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 4 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 4, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 4 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 5, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 5 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 5, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 5 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 5, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 5 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 6, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 6 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 6, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 6 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 6, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 6 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 7, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 7 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 7, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 7 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 7, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 7 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 8, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 8 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 8, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 8 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 8, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 8 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 9, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 9 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 9, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 9 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 9, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 9 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 10, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 10 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 10, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 10 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 10, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 10 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 11, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 11 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 11, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 11 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 11, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 11 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 12, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 12 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 12, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 12 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 12, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 12 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 13, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 13 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 13, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 13 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 13, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 13 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 14, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 14 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 14, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 14 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 14, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 14 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 15, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 15 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 15, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 15 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 15, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 15 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 16, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 16 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 16, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 16 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 16, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 16 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 17, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 17 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 17, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 17 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 17, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 17 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 18, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 18 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 18, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 18 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 18, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 18 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 19, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 19 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 19, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 19 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 19, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 19 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 20, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 20 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 20, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 20 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 20, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 20 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 21, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 21 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 21, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 21 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 21, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 21 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 22, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 22 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 22, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 22 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 22, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 22 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 23, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 23 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 23, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 23 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 23, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 23 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 24, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 24 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 24, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 24 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 24, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 24 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 25, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 25 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 25, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 25 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 25, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 25 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 26, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 26 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 26, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 26 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 26, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 26 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 27, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 27 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 27, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 27 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 27, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 27 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 28, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 28 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 28, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 28 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 28, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 28 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 29, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 29 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 29, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 29 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 29, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 29 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 30, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 30 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 30, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 30 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 30, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 30 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 31, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 31 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 31, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 31 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 31, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 31 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 32, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 32 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 32, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 32 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 32, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 32 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 33, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 33 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 33, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 33 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 33, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 33 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 34, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 34 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 34, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 34 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 34, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 34 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 35, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 35 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 35, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 35 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 35, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 35 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 36, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 36 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 36, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 36 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 36, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 36 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 37, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 37 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 37, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 37 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 37, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 37 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 38, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 38 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 38, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 38 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 38, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 38 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 39, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 39 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 39, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 39 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 39, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 39 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (1, 40, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 40 AND p.cod_sucursal = 1 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (2, 40, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 40 AND p.cod_sucursal = 2 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))
INSERT INTO STOCK_SUCURSALES
VALUES (3, 40, (SELECT COALESCE(SUM(l.cantidad), 0) FROM LOTES l JOIN PEDIDOS p ON p.cod_pedido = l.cod_pedido WHERE l.cod_producto = 40 AND p.cod_sucursal = 3 AND l.fecha_vencimiento > DATEADD(DAY, 60, GETDATE())))

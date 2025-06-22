create database Grupo21_final
GO

use Grupo21_final
GO

set dateformat dmy; 
set language spanish;

create table paises
(
id_pais int primary key identity(1,1), 
pais varchar(50) not null
)

create table provincias
(
id_provincia int primary key identity (1,1),
provincia varchar(50) not null
)

create table ciudades
(
id_ciudad int primary key identity(1,1), 
ciudad varchar(50) not null
)

create table ubicaciones 
( 
id_ubicacion int primary key identity(1,1), 
id_pais int, 
id_provincia int, 
id_ciudad int,

constraint fk_paises_ubicacion foreign key (id_pais) references paises(id_pais),
constraint fk_provincias_ubicacion foreign key (id_provincia) references provincias(id_provincia),
constraint fk_ciudades_ubicacion foreign key (id_ciudad) references ciudades(id_ciudad)
) 

create table tipos_clientes 
( 
id_tipo_cliente int primary key identity(1,1), 
tipo_cliente varchar(32) not null, 
apellido varchar(50), -- Introducir si es particular 
cuit varchar(20), -- Introducir si es entidad p blica o empresa 
razonSocial varchar(100) -- Introducir si es empresa
) 

create table barrios
(
id_barrio int primary key identity(1,1),
barrio varchar(50) not null
)

create table localizaciones 
( 
id_localizacion int primary key identity(1,1), 
id_ubicacion int not null, 
id_barrio int, 
calle varchar(50) not null, 
altura varchar (10) not null, 
piso varchar (2) null, 
departamento varchar (2) null, 

constraint fk_localizacion_barrio foreign key (id_barrio) references barrios(id_barrio),
constraint fk_ubicacion foreign key (id_ubicacion) references ubicaciones(id_ubicacion) 
) 

create table clientes 
( 
id_cliente int primary key identity(1,1), 
id_tipo_cliente int not null, 
id_localizacion int not null, 
nombre varchar(50) not null, 
mail varchar(35) not null, 
telefono varchar(15), 

constraint fk_tipo_cliente_clientes foreign key (id_tipo_cliente) references tipos_clientes(id_tipo_cliente), 
constraint fk_localizacion_clientes foreign key (id_localizacion) references localizaciones(id_localizacion) 
) 

create table tipo_proyectos 
( 
id_tipo_proyecto int primary key identity(1,1), 
tipo_proyecto varchar(30) 
) 

create table especialidad_socios
(
id_especialidad_socio int primary key identity (1,1), 
especialidad_socio varchar(50)
)


create table socios 
( 
id_socio int primary key identity (1,1), 
nombre varchar(50), 
telefono varchar(25), 
mail varchar (50) not null, 
id_especialidad_socio int not null,
id_localizacion int not null,

constraint fk_especialidad_socio foreign key (id_especialidad_socio) references especialidad_socios(id_especialidad_socio),
constraint fk_localizacion_socios foreign key (id_localizacion) references localizaciones(id_localizacion) 
)

create table unidades_medidas
( 
id_unidad_medida int primary key identity (1,1), 
medida varchar (10) 
) 

create table estados_proyectos 
( 
id_estado_proyecto int primary key identity (1,1), 
estado varchar (20) 
)

create table etapas_proyectos
(
id_etapa_proyecto int primary key identity(1,1),
etapa_proyecto varchar(50)
)

create table proyectos 
( 
id_proyecto int primary key identity(1,1), 
id_localizacion int not null, 
id_tipo_proyecto int not null, 
nro_catastral int, 
superficie_terreno decimal(10,2), 
fecha_inicio datetime not null, 
fecha_final datetime not null,
fecha_estimada datetime not null,
superficie_proyecto decimal(10,2), 
precio_m_cuadrado decimal(10,2) not null, 

id_cliente int not null, 
id_unidad_medida int not null, 
id_estado_proyecto int not null,
id_etapa_proyecto int not null,

constraint fk_localizacion_proyectos foreign key (id_localizacion) references localizaciones(id_localizacion), 
constraint fk_tipo_proyecto foreign key (id_tipo_proyecto) references tipo_proyectos(id_tipo_proyecto), 
 
constraint fk_id_cliente foreign key (id_cliente) references clientes(id_cliente), 
constraint fk_unidad_medida_proyectos foreign key (id_unidad_medida) references unidades_medidas(id_unidad_medida), 
constraint fk_estado_Proyectos foreign key (id_estado_proyecto) references estados_proyectos(id_estado_proyecto),
constraint fk_etapa_proyecto foreign key (id_etapa_proyecto) references etapas_proyectos(id_etapa_proyecto) 
)

create table participaciones_socios
(
id_participacion_socio int primary key identity (1,1), 
id_proyecto int,
id_socio int,

constraint fk_participacion_proyecto foreign key (id_proyecto) references proyectos(id_proyecto),
constraint fk_participacion_socio foreign key (id_socio) references socios(id_socio)
)

create table datos_pago_extra
(
id_dato_pago_extra int primary key identity (1,1), 
cbu varchar(50),
nro_tarjeta varchar(20),
nombre_titular varchar (50),
banco varchar(50),
nro_cheque varchar(50),
fecha_emision DATE,
fecha_vencimiento DATE
)

create table divisa_pagos
(
id_divisa_pago int primary key identity (1,1), 
divisa_pago varchar(3)
)

create table metodos_pagos
( 
id_metodo_pago int primary key identity (1,1),
id_divisa_pago int,
metodo varchar(50),
id_dato_pago_extra int,
constraint fk_metodo_pago_divisa foreign key (id_divisa_pago) references divisa_pagos(id_divisa_pago) ,
constraint fk_metodo_pago_extra foreign key (id_dato_pago_extra) references datos_pago_extra(id_dato_pago_extra)
)

create table estados_pago
(
id_estado_pago int primary key identity (1,1), 
estado_pago varchar(50) 
)

create table facturas 
( 
id_factura int primary key identity (1,1), 
id_cliente int not null, 
id_metodo_pago int not null,
id_estado_pago int not null,
fecha datetime not null, 
total decimal(20,2) not null, 

constraint fk_cliente_factura foreign key (id_cliente) references clientes(id_cliente), 
constraint fk_metodo_pago_factura foreign key (id_metodo_pago) references metodos_pagos(id_metodo_pago),
constraint fk_estado_pago foreign key (id_estado_pago) references estados_pago(id_estado_pago)
) 

create table detalles_facturados
( 
id_detalle_factura int primary key identity(1,1), 
id_proyecto int not null, 
id_factura int not null, 
precio decimal(10,2) not null, 

constraint fk_detalle_proyecto foreign key (id_proyecto) references proyectos(id_proyecto), 
constraint fk_factura foreign key (id_factura) references facturas(id_factura) 
) 

GO

insert into paises (pais) values
('Argentina'),
('Brasil'),
('Chile'),
('Colombia'),
('Ecuador'),
('Per '),
('Uruguay'),
('Paraguay'),
('Bolivia'),
('Venezuela');

insert into provincias (provincia) values
('Buenos Aires'),
('C rdoba'),
('Santa Fe'),
('S o Paulo'),
('Rio de Janeiro'),
('Santiago'),
('Antioquia'),
('Pichincha'),
('Lima'),
('Montevideo'),
('Asunci n');

insert into ciudades (ciudad) values
('Buenos Aires'),
('C rdoba'),
('Rosario'),
('S o Paulo'),
('Rio de Janeiro'),
('Santiago de Chile'),
('Medell n'),
('Quito'),
('Lima'),
('Montevideo'),
('Asunci n'),
('La Paz'),
('Caracas');

insert into barrios (barrio) values
('Palermo'),
('Recoleta'),
('Belgrano'),
('Copacabana'),
('Ipanema'),
('Providencia'),
('El Poblado'),
('La Floresta'),
('Miraflores'),
('Carrasco'),
('Villa Morra'),
('Obrajes');

insert into ubicaciones (id_pais, id_provincia, id_ciudad) values
(1, 1, 1), -- Buenos Aires, Argentina
(1, 2, 2), -- C rdoba, Argentina
(2, 4, 4), -- S o Paulo, Brasil
(3, 6, 6), -- Santiago, Chile
(4, 7, 7), -- Antioquia, Colombia
(5, 8, 8), -- Pichincha, Ecuador
(6, 9, 9), -- Lima, Per 
(7, 10, 10), -- Montevideo, Uruguay
(8, 11, 11); -- Asunci n, Paraguay

insert into tipos_clientes (tipo_cliente, apellido, cuit, razonSocial) values
('Particular', 'Gonz lez', null, null),
('Particular', 'Rodr guez', null, null),
('Empresa', null, '30-12345678-9', 'Constructora SA'),
('Empresa', null, '20-87654321-0', 'Inmobiliaria SRL'),
('Entidad P blica', null, '33-11223344-5', 'Municipalidad'),
('Particular', 'Ram rez', null, null),
('Particular', 'Morales', null, null),
('Empresa', null, '30-71012345-2', 'Grupo Andino SA'),
('Empresa', null, '30-72054321-9', 'Constructora El C ndor'),
('Entidad P blica', null, '30-12345678-9', 'Gobierno de C rdoba'),
('Particular', 'M ndez', null, null),
('Particular', 'Ortega', null, null),
('Empresa', null, '30-78945612-7', 'Planificaci n Urbana SRL'),
('Empresa', null, '30-45678912-3', 'Desarrollos Patag nicos SA'),
('Entidad P blica', null, '30-11223344-1', 'Municipio de Salta'),
('Particular', 'Paredes', null, null),
('Particular', 'Ben tez', null, null),
('Empresa', null, '30-99887766-0', 'Innovar Constructora SRL'),
('Empresa', null, '30-88776655-1', 'Viviendas del Sur SA'),
('Entidad P blica', null, '30-77665544-2', 'Gobierno de Tucum n'),
('Particular', 'Gallardo', null, null),
('Particular', 'Z  iga', null, null),
('Empresa', null, '30-66554433-3', 'EcoDesarrollos SRL'),
('Empresa', null, '30-55443322-4', 'Terracota Group SA'),
('Entidad P blica', null, '30-44332211-5', 'Ministerio de Infraestructura Mendoza'),
('Particular', 'Salcedo', null, null),
('Empresa', null, '30-33221100-6', 'Obras Civiles del Litoral SA'),
('Particular', 'Ferreyra', null, null),
('Entidad P blica', null, '30-22110099-7', 'Municipalidad de La Paz'),
('Empresa', null, '30-11009988-8', 'Construir Futuro SRL');

insert into tipo_proyectos (tipo_proyecto) values
('Residencial'),
('Comercial'),
('Industrial'),
('Educativo'),
('Salud');

insert into especialidad_socios (especialidad_socio) values
('Arquitecto'),
('Ingeniero Civil'),
('Top grafo'),
('Administrador de Proyectos');

insert into unidades_medidas (medida) values
('m2'),
('ft2');

insert into estados_proyectos (estado) values
('En planificaci n'),
('En ejecuci n'),
('Finalizado'),
('Suspendido');

insert into etapas_proyectos (etapa_proyecto) values
('Inicio'),
('Desarrollo'),
('Finalizaci n'),
('Post-venta');

insert into estados_pago (estado_pago) values
('Pendiente'),
('Pagado'),
('Cancelado'),
('En disputa');

insert into divisa_pagos (divisa_pago) values
('ARS'),
('BRL'),
('CLP'),
('COP'),
('USD'),
('PEN'),
('UYU'),
('PYG'),
('BOB'),
('VES');

insert into localizaciones (id_ubicacion, id_barrio, calle, altura, piso, departamento) values
(1, 1, 'Av. Santa Fe', '1234', '3', 'B'),
(1, 2, 'Calle Corrientes', '456', NULL, NULL),
(2, 3, 'Calle C rdoba', '789', '5', 'A'),
(3, 4, 'Rua Paulista', '1000', '10', 'C'),
(4, 5, 'Rua das Laranjeiras', '250', NULL, NULL),
(5, 6, 'Av. Providencia', '789', '2', 'D'),
(6, 7, 'Calle 10', '101', NULL, NULL),
(7, 8, 'Av. Larco', '234', '1', 'B'),
(8, 9, 'Rambla Rep blica', '567', '4', 'A'),
(9, 10, 'Calle Palma', '890', NULL, NULL);

insert into clientes (id_tipo_cliente, id_localizacion, nombre, mail, telefono) values
(1, 1, 'Juan', 'juan.gonzalez@email.com', '1145678901'),
(2, 2, 'Mar a', 'maria.rodriguez@email.com', '1145678902'),
(3, 3, 'Constructora SA', 'contacto@constructora.com', '1156789012'),
(4, 4, 'Inmobiliaria SRL', 'info@inmobiliaria.com', '1167890123'),
(5, 5, 'Municipalidad', 'atencion@municipalidad.gob', '1178901234'),
(6, 6, 'Carlos', 'carlos.perez@email.com', '1123456789'),
(7, 7, 'Ana', 'ana.lopez@email.com', '1123456790'),
(8, 8, 'Servicios Globales', 'contacto@serviciosglobales.com', '1134567890'),
(9, 9, 'Inversiones SA', 'info@inversiones.com', '1145678903'),
(10, 3, 'Esteban Lopez', 'esteban.lopez@email.com', '1122334455'),
(11, 4, 'Valeria G mez', 'valeria.gomez@email.com', '1133445566'),
(12, 5, 'Arquitectura Moderna SRL', 'contacto@arquimoderna.com', '1144556677'),
(13, 6, 'Constructores Unidos SA', 'info@constructoresunidos.com', '1155667788'),
(14, 7, 'Gobierno Regional', 'atencion@gobregional.gob', '1166778899'),
(15, 8, 'Juan', 'lucas.fernandez@email.com', '1177889900'),
(16, 9, 'Marina Herrera', 'marina.herrera@email.com', '1188990011'),
(17, 10, 'Servicios Integrales SRL', 'contacto@servintegrales.com', '1199001122'),
(18, 1, 'Inversiones Globales SA', 'info@inversionesglobales.com', '1100112233'),
(19, 2, 'Municipalidad Central', 'municipalidad@central.gob', '1111223344'),
(20, 10, 'Gobierno Local', 'gobierno@local.gob', '1156789011'),
(21, 3, 'Camila Ram rez', 'camila.ramirez@email.com', '1165432109'),
(22, 4, 'Diego Morales', 'diego.morales@email.com', '1167893210'),
(23, 5, 'Grupo Andino SA', 'contacto@grupoandino.com', '1144455566'),
(24, 6, 'Constructora El C ndor', 'info@elcondor.com', '1177788899'),
(25, 7, 'Gobierno de C rdoba', 'contacto@gobcordoba.gob', '1133332211'),
(26, 8, 'Sof a M ndez', 'sofia.mendez@email.com', '1144556699'),
(27, 9, 'Mat as Ortega', 'matias.ortega@email.com', '1177990011'),
(28, 10, 'Planificaci n Urbana SRL', 'contacto@urbana.com', '1133442299'),
(29, 2, 'Desarrollos Patag nicos SA', 'contacto12@patagonicos.com', '1122233344'),
(30, 1, 'Tecnologias SA', 'tecnol@salta.com', '1155667788');

insert into socios (nombre, telefono, mail, id_especialidad_socio, id_localizacion) values
('Luis Fern ndez', '1145678910', 'luis.fernandez@email.com', 1, 1),
('Sof a Mart nez', '1145678911', 'sofia.martinez@email.com', 2, 2),
('Juan G mez', '1145678912', 'pedro.gomez@email.com', 3, 3),
('Luc a Ram rez', '1145678913', 'lucia.ramirez@email.com', 4, 4),
('Diego Torres', '1145678914', 'diego.torres@email.com', 1, 5),
('Marta Silva', '1145678915', 'marta.silva@email.com', 2, 6),
('Jorge D az', '1145678916', 'jorge.diaz@email.com', 3, 7),
('Elena P rez', '1145678917', 'elena.perez@email.com', 4, 8),
('Alberto Moreno', '1145678918', 'alberto.moreno@email.com', 1, 9),
('Claudia Ruiz', '1145678919', 'claudia.ruiz@email.com', 2, 10),
('Carlos Herrera', '541122334455', 'cherrera@gmail.com', 1, 1),
('Mar a G mez', '541133445566', 'mgomez@hotmail.com', 2, 2),
('Juan P rez', '541144556677', 'jperez@yahoo.com', 3, 3),
('Luc a Fern ndez', '541155667788', 'lfernandez@gmail.com', 1, 4),
('Diego Mart nez', '541166778899', 'dmartinez@hotmail.com', 2, 5),
('Ana L pez', '541177889900', 'alopez@yahoo.com', 3, 1),
('Jos  Ram rez', '541188990011', 'jramirez@gmail.com', 1, 2),
('Sof a D az', '541199001122', 'sdiaz@hotmail.com', 2, 3),
('Miguel Torres', '541100112233', 'mtorres@yahoo.com', 3, 4),
('Paula Castro', '541111223344', 'pcastro@gmail.com', 1, 5),
('Fernando Ruiz', '541122334455', 'fruiz@hotmail.com', 2, 1),
('Carolina M ndez', '541133445566', 'cmendez@yahoo.com', 3, 2),
('Andr s Soto', '541144556677', 'asoto@gmail.com', 1, 3),
('Gabriela Ortiz', '541155667788', 'gortiz@hotmail.com', 2, 4),
('Ricardo Vargas', '541166778899', 'rvargas@yahoo.com', 3, 5),
('Ver nica Morales', '541177889900', 'vmorales@gmail.com', 1, 1),
('H ctor Silva', '541188990011', 'hsilva@hotmail.com', 2, 2),
('Natalia Jim nez', '541199001122', 'njimenez@yahoo.com', 3, 3),
('Oscar Fern ndez', '541100112233', 'ofernandez@gmail.com', 1, 4),
('Lorena Pe a', '541111223344', 'lpena@hotmail.com', 2, 5);

insert into datos_pago_extra (cbu, nro_tarjeta, nombre_titular, banco, nro_cheque, fecha_emision, fecha_vencimiento) values
('12389012', '41111', 'Juan Gonz lez', 'Banco Naci n', NULL, '15-01-2019', '15-01-2024'),
('9876543098', '5500000004', 'Mar a Rodr guez', 'Banco Santander', NULL, '20-05-2020', '20-05-2025'),
(NULL, NULL, 'Constructora SA', 'Banco BBVA', '1001', '10-03-2018', '10-03-2019'),
('55555555555', '34000009', 'Inmobiliaria SRL', 'Banco Ita ', NULL, '01-07-2021', '01-07-2026'),
('2222222222', NULL, 'Municipalidad', 'Banco de la Provincia', '2002', '30-09-2017', '30-09-2022');

insert into metodos_pagos (id_divisa_pago, metodo, id_dato_pago_extra) values
(1, 'Tarjeta de cr dito', 1),
(2, 'Tarjeta de d bito', 2),
(3, 'Cheque', 3),
(4, 'Transferencia bancaria', 4),
(1, 'Cheque', 5);

insert into proyectos (id_localizacion, id_tipo_proyecto, nro_catastral, superficie_terreno, fecha_inicio, fecha_final, fecha_estimada, superficie_proyecto, precio_m_cuadrado, id_cliente, id_unidad_medida, id_estado_proyecto, id_etapa_proyecto) values
(1, 1, 101, 500.50, '10-03-2015', '20-12-2016', '01-12-2016', 450.00, 1500.00, 1, 1, 3, 3),
(2, 2, 102, 1000.00, '15-06-2014', '30-11-2024', '15-12-2024', 950.00, 2000.00, 2, 1, 4, 3),
(3, 3, 103, 750.75, '05-01-2018', '25-07-2019', '10-08-2019', 700.00, 1800.00, 3, 1, 2, 2),
(4, 4, 104, 1200.00, '01-10-2019', '15-03-2021', '01-04-2021', 1150.00, 2200.00, 4, 1, 2, 2),
(5, 5, 105, 900.00, '20-05-2020', '10-01-2022', '30-01-2022', 870.00, 2100.00, 5, 1, 1, 1),
(6, 1, 201, 600.00, '12-04-2016', '20-12-2013', '01-12-2013', 580.00, 1600.00, 11, 1, 3, 3),
(7, 2, 202, 850.00, '18-05-2025', '15-10-2015', '01-11-2015', 830.00, 1700.00, 12, 1, 2, 2),
(8, 3, 203, 700.00, '20-07-2016', '30-11-2017', '15-12-2017', 690.00, 1650.00, 13, 1, 2, 2),
(9, 4, 204, 950.00, '25-03-2018', '10-08-2019', '01-09-2019', 920.00, 1800.00, 14, 1, 1, 1),
(10, 5, 205, 1100.00, '10-09-2020', '05-12-2021', '10-01-2022', 1080.00, 1750.00, 15, 1, 1, 1),
(1, 1, 206, 520.00, '15-02-2021', '20-06-2022', '01-07-2022', 510.00, 1550.00, 16, 1, 3, 3),
(2, 2, 207, 750.00, '10-04-2022', '25-09-2023', '15-10-2023', 730.00, 1680.00, 17, 1, 2, 2),
(3, 3, 208, 680.00, '05-01-2024', '30-04-2024', '10-05-2024', 670.00, 1600.00, 18, 1, 4, 2),
(4, 4, 209, 900.00, '20-06-2023', '15-01-2025', '01-02-2025', 880.00, 1720.00, 19, 1, 1, 1),
(5, 5, 210, 1150.00, '10-01-2024', '30-06-2025', '15-07-2025', 1120.00, 1780.00, 20, 1, 1, 1),
(6, 1, 211, 640.00, '20-01-2015', '25-05-2017', '01-06-2014', 630.00, 1580.00, 21, 1, 1, 1),
(7, 2, 212, 790.00, '14-02-2015', '10-09-2016', '01-10-2016', 770.00, 1690.00, 22, 1, 2, 2),
(8, 3, 213, 910.00, '01-06-2017', '20-12-2018', '15-01-2019', 900.00, 1800.00, 23, 1, 2, 2),
(9, 4, 214, 860.00, '03-03-2019', '25-07-2020', '10-08-2020', 850.00, 1760.00, 24, 1, 3, 3),
(10, 5, 215, 1050.00, '10-10-2021', '30-01-2023', '15-02-2023', 1030.00, 1820.00, 25, 1, 1, 1),
(1, 1, 216, 480.00, '15-03-2022', '01-07-2023', '10-07-2023', 470.00, 1540.00, 26, 1, 3, 3),
(2, 2, 217, 770.00, '20-05-2024', '30-10-2024', '15-11-2024', 760.00, 1670.00, 27, 1, 4, 2),
(3, 3, 218, 890.00, '01-02-2024', '01-04-2025', '15-04-2025', 880.00, 1790.00, 28, 1, 2, 2),
(4, 4, 219, 1020.00, '10-07-2024', '10-12-2025', '01-01-2026', 1000.00, 1850.00, 29, 1, 1, 1),
(5, 5, 220, 1180.00, '05-01-2025', '30-06-2026', '20-07-2026', 1170.00, 1900.00, 30, 1, 1, 1),
(2, 1, 1005, 1200.50, '15-03-2019', '20-12-2020', '30-11-2020', 950.75, 800.00, 3, 1, 2, 3),
(3, 2, 1006, 800.00, '10-05-2018', '22-07-2019', '01-07-2019', 600.00, 1200.00, 4, 2, 3, 2),
(1, 3, 1007, 1500.00, '05-01-2021', '15-09-2022', '30-08-2022', 1400.00, 950.00, 5, 1, 1, 1),
(4, 1, 1008, 1000.00, '20-06-2020', '30-11-2021', '15-11-2021', 850.00, 1050.00, 6, 2, 2, 2),
(5, 2, 1009, 2000.00, '01-08-2017', '10-12-2018', '01-12-2018', 1800.00, 1100.00, 7, 1, 3, 3);


insert into participaciones_socios (id_proyecto, id_socio) values
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 11),
(12, 12),
(13, 13),
(14, 14),
(15, 15),
(16, 16),
(17, 17),
(18, 18),
(19, 19),
(20, 20),
(21, 21),
(22, 22),
(23, 23),
(24, 24),
(25, 25),
(26, 26),
(27, 27),
(28, 28),
(29, 29),
(30, 30);

insert into facturas (id_cliente, id_metodo_pago, id_estado_pago, fecha, total) values
(1, 1, 2, '15-11-2023', 675000.00),
(2, 2, 2, '20-01-2024', 1900000.00),
(3, 3, 1, '30-05-2023', 1260000.00),
(4, 4, 2, '01-12-2023', 2530000.00),
(5, 5, 3, '10-02-2024', 1827000.00),
(6, 1, 2, '15-11-2022', 65000.00),
(7, 2, 2, '20-01-2024', 10000.00),
(8, 3, 1, '30-05-2025', 12600.00),
(9, 4, 2, '01-12-2025', 2530000.00),
(10, 5, 3, '10-02-2021', 1527000.00),
(11, 1, 2, '12-05-2020', 928000.00),
(12, 2, 2, '18-07-2023', 1440000.00),
(13, 3, 1, '22-02-2024', 1138500.00),
(14, 4, 2, '30-04-2024', 1656000.00),
(15, 5, 3, '10-06-2024', 1890000.00),
(16, 1, 2, '14-03-2024', 791000.00),
(17, 2, 2, '20-05-2024', 1262400.00),
(18, 3, 1, '05-06-2024', 1072000.00),
(19, 4, 2, '10-01-2025', 1513600.00),
(20, 5, 3, '01-03-2025', 1998400.00),
(21, 1, 1, '15-04-2023', 25000.75),
(22, 2, 2, '10-07-2022', 18000.50),
(23, 1, 3, '05-09-2021', 32000.00),
(24, 3, 1, '20-11-2020', 15000.25),
(25, 2, 2, '25-01-2019', 27000.80),
(26, 1, 2, '01-11-2024', 723800.00),
(27, 2, 2, '20-02-2025', 1269200.00),
(28, 3, 1, '10-04-2025', 1575200.00),
(29, 4, 2, '20-06-2025', 1850000.00),
(30, 5, 3, '15-08-2025', 2223000.00);

insert into detalles_facturados (id_proyecto, id_factura, precio) values
(1, 1, 675000.00),
(2, 2, 1900000.00),
(3, 3, 1260000.00),
(4, 4, 2530000.00),
(5, 5, 1827000.00),
(6, 6, 928000.00),
(7, 7, 1440000.00),
(8, 8, 1138500.00),
(9, 9, 1656000.00),
(10, 10, 1890000.00),
(11, 11, 791000.00),
(12, 12, 1262400.00),
(13, 13, 1072000.00),
(14, 14, 1513600.00),
(15, 15, 1998400.00),
(16, 16, 723800.00),
(17, 17, 1269200.00),
(18, 18, 1575200.00),
(19, 19, 1850000.00),
(20, 20, 2223000.00),
(21, 21, 928000.00),
(22, 22, 1440000.00),
(23, 23, 1138500.00),
(24, 24, 1656000.00),
(25, 25, 1513600.00),
(26, 26, 2530000.00),
(27, 27, 1827000.00),
(28, 28, 928000.00),
(29, 29, 1440000.00),
(30, 30, 1138500.00);


--~~~~~~~~~~~~~ CARGA DE DATOS ~~~~~~~~~~~~~~~~~~~~

-- Mostrar nro catastral, estado, tipo de proyecto, país y fecha final de los proyectos de empresas de Chile, Uruguay y Brasil, que haya iniciado hace 5 años y que su estado ya esté finalizado

select nro_catastral as 'Número catastral', estado as 'Estado del proyecto', tipo_proyecto as 'Tipo Proyecto', pais as 'País', fecha_final as 'Fecha finalización'
from estados_proyectos as ep 
join proyectos as p on ep.id_estado_proyecto = p.id_estado_proyecto
join tipo_proyectos as tp on tp.id_tipo_proyecto = p.id_tipo_proyecto
join localizaciones as l on l.id_localizacion = p.id_localizacion
join ubicaciones as u on u.id_ubicacion = l.id_ubicacion
join paises as pa on pa.id_pais = u.id_pais

where pais in ('Chile', 'Uruguay', 'Brasil')
	and YEAR(fecha_inicio) <= YEAR(GETDATE()) -5
	and estado = 'Finalizado'

-- Mostrar nro catastral, estado, tipo de proyecto y provincia (junto a su ciudad) de todos los proyectos del año pasado que hayan sido suspendidos en Argentina

select nro_catastral as 'Número catastral', estado as 'Estado del proyecto', tipo_proyecto as 'Tipo Proyecto', (provincia+' | '+ciudad) as 'Provincia y Ciudad', fecha_inicio
from estados_proyectos as ep 
join proyectos as p on ep.id_estado_proyecto = p.id_estado_proyecto
join tipo_proyectos as tp on tp.id_tipo_proyecto = p.id_tipo_proyecto
join localizaciones as l on l.id_localizacion = p.id_localizacion
join ubicaciones as u on u.id_ubicacion = l.id_ubicacion
join paises as pa on pa.id_pais = u.id_pais
join provincias as pr on pr.id_provincia = u.id_provincia
join ciudades as ci on ci.id_ciudad = u.id_ciudad

where estado = 'Suspendido'
	and pais = 'Argentina'

-- Mostrar nro catastral, estado, tipo de proyecto, fecha final y precio final de los 10 proyectos más caros que estén terminados y sean de clientes particulares

select top 10 nro_catastral as 'Número catastral', estado as 'Estado del proyecto', tipo_proyecto as 'Tipo Proyecto', fecha_final as 'Fecha finalización', total as 'Monto final'
from estados_proyectos as ep 
join proyectos as p on ep.id_estado_proyecto = p.id_estado_proyecto
join tipo_proyectos as tp on tp.id_tipo_proyecto = p.id_tipo_proyecto
join clientes as c on c.id_cliente = p.id_cliente
join tipos_clientes as tc on tc.id_tipo_cliente = c.id_tipo_cliente
join facturas as f on f.id_cliente = c.id_cliente

where estado = 'Finalizado'
	and tipo_cliente = 'Particular'
order by total desc

-- Mostrar la cantidad de proyectos realizados en cada año hecho por clientes originarios de Argentina

select year(fecha_inicio) as 'Año', count(*) as 'Cantidad de proyectos'
from estados_proyectos as ep 
join proyectos as p on ep.id_estado_proyecto = p.id_estado_proyecto
join tipo_proyectos as tp on tp.id_tipo_proyecto = p.id_tipo_proyecto
join clientes as c on c.id_cliente = p.id_cliente
join tipos_clientes as tc on tc.id_tipo_cliente = c.id_tipo_cliente
join facturas as f on f.id_cliente = c.id_cliente
join localizaciones as l on l.id_localizacion = c.id_localizacion
join ubicaciones as u on u.id_ubicacion = l.id_ubicacion
join paises as pa on pa.id_pais = u.id_pais
WHERE pais = 'Argentina'
GROUP BY YEAR(p.fecha_inicio)
ORDER BY Año

-- Mostrar fecha, total y método de pago de todas las facturas de clientes particulares que hayan pagado por tarjeta de crédito

select fecha as 'Fecha', total as 'Monto total', metodo as 'Metodo de pago'
from facturas as f
join clientes c ON f.id_cliente = c.id_cliente
join tipos_clientes as tc on tc.id_tipo_cliente = c.id_tipo_cliente
join metodos_pagos as mp on mp.id_metodo_pago = f.id_metodo_pago
where tipo_cliente = 'Particular'
  and metodo = 'Tarjeta de crédito'

-- Mostrar provincia (junto a la ciudad), nro catastral, estado, nombre del cliente, tipo de cliente, precio final y método de pago  todos los proyectos realizados en São paulo y Santiago por una entidad pública y hayan pagado mediante Tarjeta de crédito. Mostrar también los que hayan pagado con otro método.

select (provincia+' | '+ ciudad) as 'Provincia y ciudad', nro_catastral 'Número catastral', estado as 'Estado del proyecto', nombre as 'Nombre del cliente', tipo_cliente 'Tipo de cliente', total as 'Monto final', metodo as 'Metodo de pago'
from proyectos as p
join estados_proyectos as ep on ep.id_estado_proyecto = p.id_etapa_proyecto
join clientes as c ON p.id_cliente = c.id_cliente
join tipos_clientes as tc on tc.id_tipo_cliente = c.id_tipo_cliente
join localizaciones as l ON p.id_localizacion = l.id_localizacion
join ubicaciones as u on l.id_ubicacion = u.id_ubicacion
join ciudades as ci on ci.id_ciudad = u.id_ciudad
join provincias as pr on pr.id_provincia = u.id_provincia
join facturas as f ON p.id_proyecto = p.id_proyecto
left join metodos_pagos as mp on mp.id_metodo_pago = f.id_metodo_pago
where provincia in ('São Paulo', 'Santiago')
  and tipo_cliente = 'entidad pública'
order by 
  case 
    when metodo = 'Tarjeta de crédito' THEN 0
    else 1
  end


--Total facturado por cada socio y cantidad de facturas emitidas--

SELECT s.nombre as 'Nombre socio', COUNT(DISTINCT f.id_factura) AS 'Cantidad de facturas', SUM(df.precio) AS 'Total facturado'
FROM socios s
JOIN participaciones_socios ps ON ps.id_socio = s.id_socio
JOIN proyectos p ON p.id_proyecto = ps.id_proyecto
JOIN detalles_facturados df ON df.id_proyecto = p.id_proyecto
JOIN facturas f ON f.id_factura = df.id_factura
GROUP BY s.id_socio, s.nombre
ORDER BY 'Total facturado' DESC;


--Precio promedio de proyecto por ciudad (ubicacion)--

SELECT c.ciudad as 'Ciudad', AVG(p.precio_m_cuadrado * p.superficie_proyecto) AS 'Precio promedio por proyecto'
FROM proyectos p
JOIN localizaciones l ON p.id_localizacion = l.id_localizacion
JOIN ubicaciones u ON l.id_ubicacion = u.id_ubicacion
JOIN ciudades c ON u.id_ciudad = c.id_ciudad
GROUP BY c.ciudad
ORDER BY 'Precio promedio por proyecto' DESC;

--Barrios por cantidad de clientes y socios--

SELECT b.barrio AS 'Barrio', COUNT(DISTINCT c.id_cliente) AS 'Cantidad de clientes', COUNT(DISTINCT s.id_socio) AS 'Cantidad de socios'
FROM barrios b
LEFT JOIN localizaciones l ON l.id_barrio = b.id_barrio
LEFT JOIN clientes c ON c.id_localizacion = l.id_localizacion
LEFT JOIN socios s ON s.id_localizacion = l.id_localizacion
GROUP BY b.barrio
ORDER BY 'Cantidad de clientes' DESC;

-- Facturas cuya fecha sea mayor a 2015, el precio sea mayor a 100.000 y el nombre  del socio sea 'Juan'

SELECT f.fecha AS 'Fecha', f.total AS 'Total', s.nombre AS 'Nombre Socio'
FROM facturas f
JOIN detalles_facturados df ON df.id_factura = f.id_factura
JOIN proyectos p ON p.id_proyecto = df.id_proyecto
JOIN participaciones_socios ps ON ps.id_proyecto = p.id_proyecto
JOIN socios s ON s.id_socio = ps.id_socio
WHERE f.fecha > '2015-12-31'
    AND f.total > 100000
    AND s.nombre like 'Juan%'
ORDER BY f.fecha;


--Proyectos con precio total sea mayor a 200.000, con localidad en Paraguay--

SELECT p.nro_catastral AS 'Nro. Catastral', p.fecha_inicio AS 'Fecha Inicio', p.fecha_final AS 'Fecha Final', p.precio_m_cuadrado * p.superficie_proyecto AS 'Precio Total', c.pais AS 'País', l.calle AS 'Calle', l.altura AS 'Altura'
FROM proyectos p
JOIN localizaciones l ON p.id_localizacion = l.id_localizacion
JOIN ubicaciones u ON l.id_ubicacion = u.id_ubicacion
JOIN paises c ON u.id_pais = c.id_pais
WHERE (p.precio_m_cuadrado * p.superficie_proyecto) > 200000
    AND c.pais = 'Paraguay'
ORDER BY 'Precio Total' DESC;

--Clientes con la mayor cantidad de proyectos, cuyo DNI sea mayor a 30.000.000--

SELECT cl.nombre AS 'Cliente',COUNT(p.id_proyecto) AS 'Cantidad de proyectos',tc.cuit AS 'DNI/CUIT'
FROM clientes cl
JOIN tipos_clientes tc ON cl.id_tipo_cliente = tc.id_tipo_cliente
JOIN proyectos p ON p.id_cliente = cl.id_cliente
WHERE TRY_CAST(REPLACE(tc.cuit, '-', '') AS BIGINT) > 30000000
GROUP BY cl.nombre,tc.cuit
ORDER BY 'Cantidad de proyectos' DESC;

--Proyectos con mayor diferencia de superficie del terreno y superficie del proyecto, asi como precio x metro cuadrado (plata desperdiciada)

SELECT p.nro_catastral AS 'Nro. Catastral',p.superficie_terreno AS 'Superficie Terreno',p.superficie_proyecto AS 'Superficie Proyecto',(p.superficie_terreno - p.superficie_proyecto) AS 'Diferencia Superficie',p.precio_m_cuadrado AS 'Precio por m²',(p.superficie_terreno - p.superficie_proyecto) * p.precio_m_cuadrado AS 'Plata Desperdiciada'
FROM proyectos p
WHERE (p.superficie_terreno - p.superficie_proyecto) > 0
ORDER BY 'Plata Desperdiciada' DESC;

--Proyectos que hayan finalizado en menos de 500 días y su tipo de proyecto sea residencial

SELECT p.nro_catastral AS 'Nro. Catastral',p.fecha_inicio AS 'Fecha Inicio',p.fecha_final AS 'Fecha Final',DATEDIFF(day, p.fecha_inicio, p.fecha_final) AS 'Duración (días)',tp.tipo_proyecto AS 'Tipo de Proyecto'
FROM proyectos p
JOIN tipo_proyectos tp ON p.id_tipo_proyecto = tp.id_tipo_proyecto
WHERE DATEDIFF(day, p.fecha_inicio, p.fecha_final) < 500
    AND LOWER(tp.tipo_proyecto) = 'Residencial'
ORDER BY p.fecha_final DESC;

--Socios que tengan mail o telefono conocidos, que sean del mismo barrio que sus clientes--

SELECT s.nombre AS 'Nombre Socio',
    s.mail AS 'Mail Socio',
    s.telefono AS 'Teléfono Socio',
    b.barrio AS 'Barrio'
FROM socios s
JOIN localizaciones ls ON s.id_localizacion = ls.id_localizacion
JOIN barrios b ON ls.id_barrio = b.id_barrio
JOIN clientes c ON c.id_localizacion = ls.id_localizacion
WHERE (s.mail IS NOT NULL AND s.mail <> '')
	OR (s.telefono IS NOT NULL AND s.telefono <> '')
GROUP BY s.nombre, s.mail, s.telefono, b.barrio
ORDER BY s.nombre;

--Clientes cuyo apellido empieza de la A a la M y que han facturado, con detalle de socio y forma de pago

SELECT cl.nombre AS 'Cliente', tc.apellido AS 'Apellido', s.nombre AS 'Nombre Socio', mp.metodo AS 'Método de Pago', f.fecha AS 'Fecha Factura', f.total AS 'Total Facturado'
FROM clientes cl
JOIN tipos_clientes tc ON cl.id_tipo_cliente = tc.id_tipo_cliente
JOIN facturas f ON f.id_cliente = cl.id_cliente
JOIN detalles_facturados df ON df.id_factura = f.id_factura
JOIN proyectos p ON p.id_proyecto = df.id_proyecto
JOIN participaciones_socios ps ON ps.id_proyecto = p.id_proyecto
JOIN socios s ON s.id_socio = ps.id_socio
JOIN metodos_pagos mp ON f.id_metodo_pago = mp.id_metodo_pago
WHERE tc.apellido LIKE '[A-M]%' -- Apellidos que empiezan con letras A a M
GROUP BY cl.nombre, tc.apellido, s.nombre, mp.metodo, f.fecha, f.total
ORDER BY f.fecha DESC;
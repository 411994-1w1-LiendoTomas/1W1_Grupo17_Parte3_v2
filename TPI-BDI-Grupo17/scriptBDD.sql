CREATE DATABASE BDD_Grupo17
GO
USE BDD_Grupo17
GO
-- Nivel 0: Tablas sin dependencias
CREATE TABLE Canales_Venta (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Generos (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Origenes (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Clasificaciones (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Distribuidoras (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Formatos (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Idiomas (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Provincias (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Sexos (
    id TINYINT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(50) NOT NULL
);

CREATE TABLE Formas_Pago (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Nacionalidades (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Calles (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Estado_Facturas (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Tipo_Promociones (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Tipo_Facturas (
    id INT PRIMARY KEY IDENTITY(1,1),
    codigo VARCHAR(5) NOT NULL, -- Ajustado
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Tipo_Butacas (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Tipo_Productos (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Tipo_Usuarios (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Estado_Reservas (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

-- Nivel 1: Dependen de Nivel 0
CREATE TABLE Peliculas (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(255) NOT NULL, -- Ajustado
    id_clasificacion INT NOT NULL FOREIGN KEY REFERENCES Clasificaciones(id),
    duracion TIME NOT NULL,
    id_distribuidora INT NOT NULL FOREIGN KEY REFERENCES Distribuidoras(id),
    fec_estreno DATE NOT NULL,
    id_origen INT NOT NULL FOREIGN KEY REFERENCES Origenes(id)
);

CREATE TABLE Directores (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    id_nacionalidad INT NOT NULL FOREIGN KEY REFERENCES Nacionalidades(id)
);

CREATE TABLE Localidades (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL,
    id_provincia INT NOT NULL FOREIGN KEY REFERENCES Provincias(id)
);

CREATE TABLE Promociones (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_tipo INT NOT NULL FOREIGN KEY REFERENCES Tipo_Promociones(id),
    nombre VARCHAR(255) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
    valor DECIMAL(18, 2) NOT NULL
);

CREATE TABLE Productos (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL,
    id_tipo INT NOT NULL FOREIGN KEY REFERENCES Tipo_Productos(id),
    precio DECIMAL(18, 2) NOT NULL
);

-- Nivel 2: Dependen de Nivel 1
CREATE TABLE Barrios (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL,
    id_localidad INT NOT NULL FOREIGN KEY REFERENCES Localidades(id)
);

CREATE TABLE Peliculas_Directores (
    id_pelicula INT NOT NULL FOREIGN KEY REFERENCES Peliculas(id),
    id_director INT NOT NULL FOREIGN KEY REFERENCES Directores(id),
    PRIMARY KEY (id_pelicula, id_director)
);

CREATE TABLE Peliculas_Generos (
    id_pelicula INT NOT NULL FOREIGN KEY REFERENCES Peliculas(id),
    id_genero INT NOT NULL FOREIGN KEY REFERENCES Generos(id),
    PRIMARY KEY (id_pelicula, id_genero)
);

-- Nivel 3: Dependen de Nivel 2
CREATE TABLE Cines (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(255) NOT NULL, -- Ajustado
    id_calle INT NOT NULL FOREIGN KEY REFERENCES Calles(id),
    altura INT NOT NULL,
    id_barrio INT NOT NULL FOREIGN KEY REFERENCES Barrios(id)
);

-- Nivel 4: Dependen de Nivel 3 (y Nivel 0, 1, 2)
CREATE TABLE Salas (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL,
    id_cine INT NOT NULL FOREIGN KEY REFERENCES Cines(id)
);

CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY, -- << NUEVA PK
    dni INT NOT NULL UNIQUE,                  -- << DNI ahora es UNIQUE
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    id_sexo TINYINT NOT NULL FOREIGN KEY REFERENCES Sexos(id),
    fecha_nac DATE NOT NULL,
    id_calle INT NOT NULL FOREIGN KEY REFERENCES Calles(id),
    altura INT NOT NULL,
    id_barrio INT NOT NULL FOREIGN KEY REFERENCES Barrios(id),
    mail VARCHAR(254) NOT NULL, -- Ajustado
    nro_tel VARCHAR(25) NOT NULL, -- Ajustado
    fecha_alta DATE NOT NULL,
    activo BIT NOT NULL,
    id_tipo_usuario INT NOT NULL FOREIGN KEY REFERENCES Tipo_Usuarios(id),
    contraseña VARCHAR(255) NOT NULL -- << NUEVO CAMPO
);

CREATE TABLE Empleados (
    id_empleado INT IDENTITY(1,1) PRIMARY KEY, -- << NUEVA PK
    dni INT NOT NULL UNIQUE,                   -- << DNI ahora es UNIQUE
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    fecha_nac DATE NOT NULL,
    id_sexo TINYINT NOT NULL FOREIGN KEY REFERENCES Sexos(id),
    id_calle INT NOT NULL FOREIGN KEY REFERENCES Calles(id),
    altura INT NOT NULL,
    id_barrio INT NOT NULL FOREIGN KEY REFERENCES Barrios(id),
    mail VARCHAR(254) NOT NULL, -- Ajustado
    nro_tel VARCHAR(25) NOT NULL, -- Ajustado
    fecha_alta DATE NOT NULL,
    activo BIT NOT NULL
);

-- Nivel 5: Dependen de Nivel 4
CREATE TABLE Funciones (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_pelicula INT NOT NULL FOREIGN KEY REFERENCES Peliculas(id),
    dia DATE NOT NULL,
    horario TIME NOT NULL,
    id_sala INT NOT NULL FOREIGN KEY REFERENCES Salas(id),
    id_formato INT NOT NULL FOREIGN KEY REFERENCES Formatos(id),
    id_idioma INT NOT NULL FOREIGN KEY REFERENCES Idiomas(id)
);

CREATE TABLE Butacas (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_sala INT NOT NULL FOREIGN KEY REFERENCES Salas(id),
    fila CHAR(1) NOT NULL,
    numero TINYINT NOT NULL,
    id_tipo_butaca INT NOT NULL FOREIGN KEY REFERENCES Tipo_Butacas(id)
);

CREATE TABLE Facturas (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_canal_venta INT NOT NULL FOREIGN KEY REFERENCES Canales_Venta(id),
    id_usuario INT NULL FOREIGN KEY REFERENCES Usuarios(id_usuario), -- << CORREGIDO
    id_empleado INT NULL FOREIGN KEY REFERENCES Empleados(id_empleado), -- << CORREGIDO
    id_forma_pago INT NOT NULL FOREIGN KEY REFERENCES Formas_Pago(id),
    id_estado INT NOT NULL FOREIGN KEY REFERENCES Estado_Facturas(id),
    id_tipo_factura INT NOT NULL FOREIGN KEY REFERENCES Tipo_Facturas(id),
    id_cine INT NOT NULL FOREIGN KEY REFERENCES Cines(id),
    fecha DATETIME NOT NULL,
    total DECIMAL(18, 2) NOT NULL
);

-- Nivel 6: Dependen de Nivel 5
CREATE TABLE Entradas (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_funcion INT NOT NULL FOREIGN KEY REFERENCES Funciones(id),
    id_butaca INT NOT NULL FOREIGN KEY REFERENCES Butacas(id),
    precio_base DECIMAL(18, 2) NOT NULL
);

CREATE TABLE Reservas (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_usuario INT NOT NULL FOREIGN KEY REFERENCES Usuarios(id_usuario), -- << CORREGIDO
    fecha DATETIME NOT NULL,
    id_estado INT NOT NULL FOREIGN KEY REFERENCES Estado_Reservas(id),
    vencimiento DATETIME NOT NULL,
    id_cine INT NOT NULL FOREIGN KEY REFERENCES Cines(id),
    id_factura INT NULL FOREIGN KEY REFERENCES Facturas(id)
);

-- Nivel 7: Dependen de Nivel 6
CREATE TABLE Detalle_Facturas (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_factura INT NOT NULL FOREIGN KEY REFERENCES Facturas(id),
    id_entrada INT NULL FOREIGN KEY REFERENCES Entradas(id),
    id_producto INT NULL FOREIGN KEY REFERENCES Productos(id),
    id_promocion INT NULL FOREIGN KEY REFERENCES Promociones(id),
    precio_unitario DECIMAL(18, 2) NOT NULL,
    cantidad SMALLINT NOT NULL
);

CREATE TABLE Reserva_Entradas (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_reserva INT NOT NULL FOREIGN KEY REFERENCES Reservas(id),
    id_funcion INT NOT NULL FOREIGN KEY REFERENCES Funciones(id),
    id_butaca INT NOT NULL FOREIGN KEY REFERENCES Butacas(id),
    precio_base DECIMAL(18, 2) NOT NULL
);


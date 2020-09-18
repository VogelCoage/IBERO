CREATE DATABASE rescate_imposible -- Creación de la Base de Datos para un videojuego
GO
-----------------------------------------------------------------------------------------
USE rescate_imposible --Acceso a la Base de datos según su nombre
GO
-----------------------------------------------------------------------------------------
-- Creación de las tablas que forman parte de la base de datos
-----------------------------------------------------------------------------------------
CREATE TABLE Perfil_jugador(
    id_perfil INT IDENTITY,
    fecha_crea DATE,
    id_pers INT,
    id_XP INT,
    id_scene INT,
    id_pt INT,
    PRIMARY KEY(id_perfil)
)
GO

CREATE TABLE Personaje(
    id_pers INT IDENTITY,
    Nombre VARCHAR(30),
    Sexo VARCHAR(1),
    PRIMARY KEY(id_pers)
)
GO
CREATE TABLE Nivel_XP(
    id_XP INT IDENTITY,
    cant_XP INT,
    PRIMARY KEY(id_XP)
)
GO
CREATE TABLE Habilidad(
    id_habil INT IDENTITY,
    describ_habil VARCHAR(100),
    PRIMARY KEY(id_habil)
)
GO
CREATE TABLE XPHABIL(
    id_XP INT,
    id_habil INT
)
GO
CREATE TABLE ptAvance(
    id_pt INT IDENTITY,
    pt_descrip VARCHAR(30),
    PRIMARY KEY(id_pt)
)
GO
CREATE TABLE escenario(
    id_scene INT IDENTITY,
    descrip_scene VARCHAR(100),
    cant_stamina INT,
    PRIMARY KEY(id_scene)
)
GO
-----------------------------------------------------------------------------------------
-- Inserción de registros en las tablas
-----------------------------------------------------------------------------------------
INSERT INTO escenario VALUES('Barrios Bajos', 10)
INSERT INTO escenario VALUES('Casa Abandonada', 12)
INSERT INTO escenario VALUES('Desierto', 14)
INSERT INTO escenario VALUES('La Gran Torre', 16)
INSERT INTO escenario VALUES('El Sotano Secreto', 18)

INSERT INTO Habilidad VALUES('Golpe de dragón')
INSERT INTO Habilidad VALUES('Patada de tornado')
INSERT INTO Habilidad VALUES('Combo de golpe de hierro')
INSERT INTO Habilidad VALUES('Patada relámpago')
INSERT INTO Habilidad VALUES('Golpe fantasma')

INSERT INTO Nivel_XP VALUES('5000')
INSERT INTO Nivel_XP VALUES('15000')
INSERT INTO Nivel_XP VALUES('30000')
INSERT INTO Nivel_XP VALUES('75000')
INSERT INTO Nivel_XP VALUES('150000')

INSERT INTO Personaje VALUES('Joss', 'M')
INSERT INTO Personaje VALUES('Casandra', 'F')
INSERT INTO Personaje VALUES('Ted', 'M')
INSERT INTO Personaje VALUES('Fer', 'F')
INSERT INTO Personaje VALUES('Vogel', 'M')

INSERT INTO ptAvance VALUES('Inicio')
INSERT INTO ptAvance VALUES('Punto medio')
INSERT INTO ptAvance VALUES('Recta final')

INSERT INTO XPHABIL VALUES(1, 1)
INSERT INTO XPHABIL VALUES(2, 4)
INSERT INTO XPHABIL VALUES(3, 5)
INSERT INTO XPHABIL VALUES(4, 2)
INSERT INTO XPHABIL VALUES(5, 3)

INSERT INTO Perfil_jugador VALUES('2020-09-17', 1, 3, 2, 2)
INSERT INTO Perfil_jugador VALUES('2020-08-12', 2, 1, 3, 1)
INSERT INTO Perfil_jugador VALUES('2020-06-10', 4, 2, 3, 3)
INSERT INTO Perfil_jugador VALUES('2020-09-11', 5, 4, 1, 2)
INSERT INTO Perfil_jugador VALUES('2020-06-24', 3, 2, 4, 1)

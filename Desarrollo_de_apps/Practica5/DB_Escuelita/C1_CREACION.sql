CREATE DATABASE Escuelita --CREATE sirve para crear bases de datos o tablas
GO
----------------------------------------------------------------------------
USE Escuelita --USE se usa para tener acceso a la base de datos
GO
----------------------------------------------------------------------------
CREATE TABLE Alumnos(  --CREATE nuevaente usado ahora para crear una tabla y sus campos (atributos)
    Matricula INT IDENTITY, --IDENTITY define un entero automático
    Nombre VARCHAR(100),
    ApellidoP VARCHAR(100),
    ApellidoM VARCHAR(100),
    Edad INT,
    PRIMARY KEY(Matricula) --Aquí se define la llave primaria
)
GO
-----------------------------------------------------------------------------
INSERT INTO Alumnos VALUES('Pedro', 'Chávez', 'López', 20) -- INSERT Crea registros
INSERT INTO Alumnos VALUES('Sergio', 'Hernández', 'Chávez', 25)
INSERT INTO Alumnos VALUES('Jonathan', 'Pérez', 'Torres', 21)

INSERT INTO Alumnos VALUES('Margarito', 'Flores', 'Fernandez', 18) -- INSERT Crea registros
INSERT INTO Alumnos VALUES('Margarita', 'Flores', 'Fernandez', 21)
INSERT INTO Alumnos VALUES('Alan', 'Smith', NULL, 20)
INSERT INTO Alumnos VALUES('Donald', 'López', NULL, 21)
-----------------------------------------------------------------------------
SELECT * FROM Alumnos --SELECT sirve para visualizar los datos de las tablas
SELECT * FROM Alumnos WHERE edad >= 21 --Muestra a los alumnos cuya edad es mayor o igual a 21 años
SELECT * FROM Alumnos WHERE nombre = 'Sergio' --Muestra a todos los alumnos con el nombre Sergio
SELECT * FROM Alumnos WHERE edad >= 21 AND edad < 30 --Muestra a los alumnos cuya edad va desde los 21 a los 29
SELECT * FROM Alumnos WHERE edad BETWEEN 21 AND 30 --Lo mismo que el anterior
SELECT * FROM Alumnos WHERE Edad = 20 OR edad = 21 --Muestra alumnos con una edad de 20 o 21 años
SELECT * FROM Alumnos WHERE Edad IN (20,25) --Lo mismo que OR (comando anterior)
SELECT * FROM Alumnos WHERE Edad NOT IN (20,25) --Muestra a los alumnos que no tengan 20 o 25 años
SELECT * FROM Alumnos WHERE Edad != 20 AND Edad != 25 --Lo mismo que el anterior
SELECT * FROM Alumnos WHERE Edad <> 20 AND Edad <> 25 --Lo mismo que el anterior

SELECT * FROM Alumnos WHERE Edad = 20 AND edad = 21 --ERROR LÓGICO!!! Ningún alumno tiene ambas edades

SELECT * FROM Alumnos WHERE ApellidoM IS NULL --Muestra alumnos cuyo apellido materno es nulo
SELECT * FROM Alumnos WHERE Nombre LIKE 'Marga%' --Muestra alumnos cuyo nombre comience con Marga
SELECT * FROM Alumnos WHERE Nombre LIKE '%d' --Muestra alumnos cuyo nombre termine en d
-----------------------------------------------------------------------------


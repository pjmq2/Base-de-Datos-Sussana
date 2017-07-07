

/****** Object:  StoredProcedure [dbo].[SaveImage]    Script Date: 03/26/2012 21:45:23 ******/

USE DB_GRUPO3

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON

GO
create proc [dbo].[SaveImage] 
@name varchar(50),
@img image as
update EJERCICIO
set Imagen = @img
where nombre like @name

GO
create proc [dbo].[ReadImage] @name varchar(50) as
SELECT Imagen FROM EJERCICIO
WHERE nombre=@name

GO
create proc [dbo].[SaveFile] 
@cedula varchar(9),
@Dato varchar(500),
@archivo varbinary(MAX) as
update DATOS_CLINICOS
set Archivo = @archivo
where CedPaciente = @cedula AND Dato = @Dato

GO
create proc [dbo].[ReadFile]
@cedula varchar(9),
@Dato varchar(500) as
SELECT Archivo FROM DATOS_CLINICOS
WHERE CedPaciente = @cedula AND Dato = @Dato

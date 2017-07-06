use DB_GRUPO3

---
GO
CREATE PROCEDURE dbo.agregarUsuario
	@pLogin NVARCHAR(50),
	@pPassword NVARCHAR(50), 
	@cedula char(9),
	@estado bit OUTPUT
AS
BEGIN
SET NOCOUNT ON
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
BEGIN TRY
	INSERT INTO dbo.[Usuario] (cedulaUsuario, nombreUsuario, PasswordHash, Salt)
	VALUES(@cedula, @pLogin, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS 
	NVARCHAR(36))), @salt)
	SET @estado=1
END TRY
BEGIN CATCH
	SET @estado=ERROR_MESSAGE()
END CATCH
END

---
GO
CREATE PROCEDURE consultaTodasCitas
AS
SELECT C.CedPaciente,A.NombreP,A.Apellido1,A.Apellido2,C.Fecha,C.Precio,C.Descripcion,C.Duracion,C.Lugar,C.Estado_Paciente
FROM CITA C JOIN PLAN_TRATAMIENTO P ON P.CedPaciente = C.CedPaciente and P.Pad_Actual = C.Padec_Act join Paciente A ON A.Cedula = P.CedPaciente

---
GO
CREATE PROCEDURE eliminarCita
@cedula char(9), @fecha varchar(18)
AS
DELETE FROM CITA
WHERE CedPaciente = @cedula and Fecha = @fecha

---
GO
Create procedure eliminarMaterial
	@nombre	varchar(50)
AS
select distinct Material.Nombre
into #temp
FROM Material
Where Material.Nombre = @nombre

Delete Material
Where Nombre in (SELECT * from #temp)

drop table #temp

---
GO
CREATE PROCEDURE eliminarPaciente 
@cedula char(9)
AS
delete from PACIENTE
where PACIENTE.Cedula = @cedula

drop procedure eliminarPaciente
---
GO
CREATE PROCEDURE ModificarCita
@cedula char(9),@padecimiento varchar(50),@fecha varchar(18), @precio int, @descripcion varchar(500), @duracion decimal(4,2),
@lugar varchar(50), @estado varchar(50),@ceduCambiar char(9), @fechaCambiar varchar(18)
AS
UPDATE CITA
SET CedPaciente = @cedula, Padec_Act = @padecimiento, Fecha = @fecha, Precio = @precio, Descripcion = @descripcion,
Duracion = @duracion, Lugar = @lugar, Estado_Paciente = @estado
WHERE CedPaciente = @ceduCambiar and Fecha = @fechaCambiar
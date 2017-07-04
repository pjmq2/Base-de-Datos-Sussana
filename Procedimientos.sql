use DB_GRUPO3

--
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

CREATE PROCEDURE consultaTodasCitas
AS
SELECT C.CedPaciente,A.NombreP,A.Apellido1,A.Apellido2,C.Fecha,C.Precio,C.Descripcion,C.Duracion,C.Lugar,C.Estado_Paciente
FROM CITA C JOIN PLAN_TRATAMIENTO P ON P.CedPaciente = C.CedPaciente and P.Pad_Actual = C.Padec_Act join Paciente A ON A.Cedula = P.CedPaciente

CREATE PROCEDURE eliminarCita
@cedula char(9)
AS
DELETE FROM CITA
WHERE CedPaciente = @cedula

GO
CREATE PROCEDURE eliminarPaciente 
@nombre varchar(20)
AS
select distinct Paciente.Cedula
into #temp
from Paciente
WHERE Paciente.NombreP = @nombre
delete Paciente
where Cedula in (select * from #temp)
drop table #temp


CREATE PROCEDURE ModificarCita
@cedula char(9),@padecimiento varchar(50),@fecha datetime, @precio int, @descripcion varchar(500), @duracion decimal(4,2),
@lugar varchar(50), @estado varchar(50),@ceduCambiar char(9)
AS
UPDATE CITA
SET CedPaciente = @cedula, Padec_Act = @padecimiento, Fecha = @fecha, Precio = @precio, Descripcion = @descripcion,
Duracion = @duracion, Lugar = @lugar, Estado_Paciente = @estado
WHERE CedPaciente = @ceduCambiar



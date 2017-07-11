use DB_GRUPO3


---
GO
CREATE PROCEDURE dbo.agregarUsuario
	@pLogin NVARCHAR(50),
	@pPassword NVARCHAR(50), 
	@estado bit OUTPUT
AS
BEGIN
SET NOCOUNT ON
	DECLARE @salt UNIQUEIDENTIFIER = NEWID()
BEGIN TRY
	INSERT INTO dbo.[Usuario] (nombreUsuario, PasswordHash, Salt)
	VALUES(@pLogin, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), @salt)
	SET @estado = 1
END TRY
BEGIN CATCH
	SET @estado=ERROR_MESSAGE()
END CATCH
END

Declare @bit as bit
EXEC agregarUsuario N'admin', N'admin17', @bit OUTPUT
print @bit

SELECT * FROM Usuario
delete from Usuario

---
GO
CREATE PROCEDURE dbo.Login
	@pLoginName nvarchar(254),
	@pPassword nvarchar(50),
	@isInDB bit = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @userID	NVARCHAR(254)
	IF EXISTS (SELECT TOP 1 nombreUsuario FROM [dbo].[Usuario] WHERE nombreUsuario = @pLoginName)
	BEGIN
	
		SET @userID = (SELECT nombreUsuario FROM [dbo].[Usuario] WHERE nombreUsuario = @pLoginName AND passwordHash = HASHBYTES('SHA2_512', @pPassword + CAST(salt AS NVARCHAR(36))))
		IF(@userID IS NULL)
		BEGIN
			SET @isInDB = 0
		END
		ELSE
			SET @isInDB = 1
	END
	ELSE
		SET @isInDB = 0
			
END

DROP PROCEDURE Login

declare @isInDB2 bit
exec Login @pLoginName = N'admin', @pPassword = N'admin17', @isInDB = @isInDB2 OUTPUT
select @isInDB2 as N'@isInDB'
 
---
GO
CREATE PROCEDURE consultaTodasCitas
AS
SELECT C.CedPaciente,A.NombreP,A.Apellido1,A.Apellido2,C.Padec_Act, C.Fecha,C.Precio,C.PrecioTotal, C.Descripcion,C.Duracion,C.Lugar,C.Estado_Paciente
FROM CITA C JOIN PLAN_TRATAMIENTO P ON P.CedPaciente = C.CedPaciente and P.Pad_Actual = C.Padec_Act join Paciente A ON A.Cedula = P.CedPaciente

drop procedure consultaTodasCitas


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
Create procedure eliminarTecnica
	@nombre	varchar(50)
AS
select distinct Tecnicas.Nombre
into #temp
FROM Tecnicas
Where Tecnicas.Nombre = @nombre

Delete Tecnicas
Where Nombre in (SELECT * from #temp)

drop table #temp



---
GO
Create procedure eliminarRequiereDe
	@nombreTec	varchar(50),
	@nombreMat	varchar(50)
AS
select Requiere_De.Nombre_Tec, Requiere_De.Nombre_Mat
into #temp
FROM Requiere_De
Where Requiere_De.Nombre_Tec = @nombreTec AND Requiere_De.Nombre_Mat = @nombreMat

Delete Requiere_De
Where Nombre_Tec in (SELECT Nombre_Tec from #temp) AND Requiere_De.Nombre_Mat in (SELECT Nombre_Mat from #temp)

drop table #temp



---
GO
CREATE PROCEDURE eliminarPaciente 
@cedula char(9)
AS
delete from PACIENTE
where PACIENTE.Cedula = @cedula



---
GO
CREATE PROCEDURE eliminarPlanEjercicio
@cedula char(9),
@padecimiento varchar(50),
@nivel varchar(10)
AS
delete from PLAN_EJERCICIOS
where CedPaciente = @cedula and Padec_Act = @padecimiento and Nivel = @nivel



---
GO
CREATE PROCEDURE ModificarCita
@cedula char(9),@padecimiento varchar(50),@fecha varchar(18), @precio int, @descripcion varchar(500), @duracion varchar(10),
@lugar varchar(50), @estado varchar(50), @cedulaCambiar char(9), @padecimientoCambiar varchar(50), @fechaCambiar varchar(18)
AS
DECLARE @nuevaDuracion decimal(4,2)
SET @nuevaDuracion = [dbo].convierteDecimal(@duracion)
UPDATE CITA
SET CedPaciente = @cedula, Padec_Act = @padecimiento, Fecha = @fecha, Precio = @precio, Descripcion = @descripcion,
Duracion = @nuevaDuracion, Lugar = @lugar, Estado_Paciente = @estado
where CedPaciente = @cedulaCambiar and Padec_Act = @padecimientoCambiar and Fecha = @fechaCambiar



---
CREATE FUNCTION convierteDecimal(
@valor varchar(10))
RETURNS decimal(4,2)
AS
BEGIN
DECLARE @retorno decimal(4,2)
SET @retorno = CONVERT(decimal(4,2),replace(@valor,',','.'))
RETURN @retorno
END

---

CREATE TRIGGER PrecioTotalCita
on Se_realizan after insert
as
declare @CedPac char(9),@padec varchar(50),@fecha varchar(18), @nombreTecnica varchar(50)
select @CedPac = i.CedPaciente, @padec = i.Padec_Act, @fecha = i.Fecha_Cita, @nombreTecnica = i.Nombre_Tec
from inserted i 
 update CITA
 set PrecioTotal = PrecioTotal + (select sum(t.Precio)
								  from inserted i join TECNICA t on t.Nombre = i.Nombre_Tec join requiere_de r on t.Nombre = r.Nombre_Tec join Material m on m.nombre = r.Nombre_Mat
					              where t.Nombre = @nombreTecnica
								 ) + (select sum(m.Precio*r.Cantidad)
										from inserted i join TECNICA t on t.Nombre = i.Nombre_Tec join requiere_de r on t.Nombre = r.Nombre_Tec join Material m on m.nombre = r.Nombre_Mat
										where r.Nombre_Tec = @nombreTecnica
										)
where CedPaciente = @CedPac and Padec_Act = @padec and Fecha = @fecha 



---

CREATE TRIGGER PrecioTotalCitaEliminar
on SE_REALIZAN instead of delete
as
declare @cedBorrar char(9), @padBorrar varchar(50), @fechaBorrar varchar(18), @nombreTecBorrar varchar(50)
select @cedBorrar = d.CedPaciente, @padBorrar = d.Padec_Act, @fechaBorrar = d.Fecha_Cita, @nombreTecBorrar = d.Nombre_Tec
from deleted d
UPDATE CITA
 set PrecioTotal = PrecioTotal - (select sum(t.Precio)
								  from deleted d join TECNICA t on t.Nombre = d.Nombre_Tec join requiere_de r on t.Nombre = r.Nombre_Tec join Material m on m.nombre = r.Nombre_Mat
					              where t.Nombre = @nombreTecBorrar
								 ) - (select sum(m.Precio*r.Cantidad)
										from deleted d join TECNICA t on t.Nombre = d.Nombre_Tec join requiere_de r on t.Nombre = r.Nombre_Tec join Material m on m.nombre = r.Nombre_Mat
										where r.Nombre_Tec = @nombreTecBorrar
										)
where CedPaciente = @cedBorrar and Padec_Act = @padBorrar and Fecha = @fechaBorrar
DELETE FROM SE_REALIZAN
where CedPaciente = @cedBorrar and Padec_Act = @padBorrar and Fecha_Cita = @fechaBorrar and Nombre_Tec = @nombreTecBorrar




---
CREATE TRIGGER BorraCitaDeSeRealizan
ON CITA INSTEAD OF DELETE 
AS
DECLARE @cedula char(9), @padec varchar(50), @fecha varchar(18)
SELECT @cedula = d.CedPaciente, @padec = d.Padec_Act, @fecha = d.Fecha
FROM deleted d
DELETE FROM SE_REALIZAN 
WHERE CedPaciente = @cedula and Padec_Act = @padec and Fecha_Cita = @fecha
DELETE FROM CITA
WHERE CedPaciente = @cedula and Padec_Act = @padec and Fecha = @fecha
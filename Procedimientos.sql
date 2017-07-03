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
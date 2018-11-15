USE BulletProofRecords
GO

CREATE PROCEDURE sp_insertarCancion(
	@nombre NVARCHAR(200),
	@artista INT,
	@album INT,
	@genero nvarchar(100),
	@aniocreacion NVARCHAR(4)
)
AS
BEGIN
	INSERT INTO Music.Cancion (Nombre, Artista, Album, Genero, A�oCreacion)
		VALUES (@nombre, @artista,@album, @genero, @aniocreacion)
END
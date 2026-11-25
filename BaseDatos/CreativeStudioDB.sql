-- Ejecutar el archivo completo en SQL Server Management Studio.
USE master;
GO
IF DB_ID(N'CreativeStudioDB') IS NULL
    CREATE DATABASE CreativeStudioDB;
GO
USE CreativeStudioDB;
GO
SET XACT_ABORT ON;
SET QUOTED_IDENTIFIER ON;
SET ANSI_NULLS ON;
BEGIN TRANSACTION;

IF OBJECT_ID(N'dbo.TipoSala', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TipoSala (
        IdTipoSala int IDENTITY PRIMARY KEY,
        Nombre nvarchar(80) NOT NULL UNIQUE,
        TarifaPorHora decimal(12,2) NOT NULL CHECK (TarifaPorHora > 0),
        Descripcion nvarchar(200) NOT NULL
    );
END;

IF OBJECT_ID(N'dbo.Reserva', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Reserva (
        IdReserva int IDENTITY PRIMARY KEY,
        NombreCliente nvarchar(120) NOT NULL,
        CorreoCliente nvarchar(254) NOT NULL,
        TipoReserva nvarchar(12) NOT NULL CHECK (TipoReserva IN (N'Individual', N'Corporativa')),
        FechaReserva datetime2(0) NOT NULL,
        CantidadHoras tinyint NOT NULL CHECK (CantidadHoras BETWEEN 1 AND 4),
        IdTipoSala int NOT NULL REFERENCES dbo.TipoSala(IdTipoSala),
        TarifaAplicada decimal(12,2) NOT NULL CHECK (TarifaAplicada > 0),
        Total AS CONVERT(decimal(12,2), TarifaAplicada * CantidadHoras *
            CASE WHEN TipoReserva = N'Corporativa' THEN 0.90 ELSE 1.00 END) PERSISTED,
        FechaRegistro datetime2(0) NOT NULL DEFAULT SYSDATETIME(),
        CHECK (FechaReserva > FechaRegistro)
    );
END;

INSERT INTO dbo.TipoSala (Nombre, TarifaPorHora, Descripcion)
SELECT s.Nombre, s.Tarifa, s.Descripcion
FROM (VALUES
    (N'Podcast', 7000, N'Espacio equipado para grabar audio.'),
    (N'Video y streaming', 10000, N'Estudio de video y transmisión en vivo.')
) AS s(Nombre, Tarifa, Descripcion)
WHERE NOT EXISTS (SELECT 1 FROM dbo.TipoSala t WHERE t.Nombre = s.Nombre);

IF NOT EXISTS (SELECT 1 FROM dbo.Reserva)
BEGIN
    INSERT INTO dbo.Reserva (NombreCliente, CorreoCliente, TipoReserva, FechaReserva,
        CantidadHoras, IdTipoSala, TarifaAplicada)
    SELECT N'Estudio Brisa', N'brisa@example.com', N'Corporativa', DATEADD(day, 3, SYSDATETIME()),
        3, IdTipoSala, TarifaPorHora FROM dbo.TipoSala WHERE Nombre = N'Video y streaming';
END;
COMMIT;

SELECT r.IdReserva, r.NombreCliente, r.TipoReserva, s.Nombre AS Sala,
       r.FechaReserva, r.CantidadHoras, r.TarifaAplicada, r.Total
FROM dbo.Reserva AS r
JOIN dbo.TipoSala AS s ON s.IdTipoSala = r.IdTipoSala;

-- Ejemplo de eliminación: insertar una reserva de práctica y borrar solo esa fila.
BEGIN TRANSACTION;
INSERT INTO dbo.Reserva (NombreCliente, CorreoCliente, TipoReserva, FechaReserva,
    CantidadHoras, IdTipoSala, TarifaAplicada)
SELECT N'Prueba', N'prueba@example.com', N'Individual', DATEADD(day, 1, SYSDATETIME()),
    1, IdTipoSala, TarifaPorHora FROM dbo.TipoSala WHERE Nombre = N'Podcast';
DECLARE @ReservaPrueba int = SCOPE_IDENTITY();
DELETE FROM dbo.Reserva WHERE IdReserva = @ReservaPrueba;
COMMIT;

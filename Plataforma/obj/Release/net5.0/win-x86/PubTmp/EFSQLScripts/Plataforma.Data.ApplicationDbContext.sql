IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506082754_FirstMigration')
BEGIN
    CREATE TABLE [Cursos] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Cursos] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506082754_FirstMigration')
BEGIN
    CREATE TABLE [Empresa] (
        [Id] int NOT NULL IDENTITY,
        [Nombre_Empresa] nvarchar(max) NULL,
        [Nombre_Comercial] nvarchar(max) NULL,
        [seguridad_social] int NOT NULL,
        [Nif] nvarchar(max) NULL,
        [Direccion] nvarchar(max) NULL,
        [Cp] int NOT NULL,
        [Provincia] nvarchar(max) NULL,
        [Localidad] nvarchar(max) NULL,
        [DireccionComercial] nvarchar(max) NULL,
        [CPComercial] int NOT NULL,
        [ProvinciaComercial] nvarchar(max) NULL,
        [LocalidadComercial] nvarchar(max) NULL,
        [Telefono] nvarchar(max) NULL,
        [email] nvarchar(max) NULL,
        [CuentaCotizacion] nvarchar(max) NULL,
        [sector] nvarchar(max) NULL,
        [convenio] nvarchar(max) NULL,
        [actividadprincial] nvarchar(max) NULL,
        [CNAE] nvarchar(max) NULL,
        [Representacionlegal] bit NOT NULL,
        [nuevacreacion] bit NOT NULL,
        [creditodisponible] int NOT NULL,
        [Banco] nvarchar(max) NULL,
        [Cuenta] nvarchar(max) NULL,
        [creacion] datetime2 NOT NULL,
        [venta] bit NOT NULL,
        [Nombrereprensentante] nvarchar(max) NULL,
        [Generorepresentante] bit NOT NULL,
        [nifrepresentante] nvarchar(max) NULL,
        [Fechafirma] datetime2 NOT NULL,
        [nombregestoria] nvarchar(max) NULL,
        [contatogestoria] nvarchar(max) NULL,
        [emailgestoria] nvarchar(max) NULL,
        [telefonogestoria] nvarchar(max) NULL,
        [ano] int NOT NULL,
        [Idcurso] int NOT NULL,
        CONSTRAINT [PK_Empresa] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506082754_FirstMigration')
BEGIN
    CREATE TABLE [EmpresaCurso] (
        [Id] int NOT NULL IDENTITY,
        [CursoNome] nvarchar(max) NULL,
        [IdEmpresa] int NOT NULL,
        [Inicio] datetime2 NOT NULL,
        [Final] datetime2 NOT NULL,
        CONSTRAINT [PK_EmpresaCurso] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506082754_FirstMigration')
BEGIN
    CREATE TABLE [EmpresasCurso] (
        [Id] int NOT NULL IDENTITY,
        CONSTRAINT [PK_EmpresasCurso] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506082754_FirstMigration')
BEGIN
    CREATE TABLE [Trabajadores] (
        [Id] int NOT NULL IDENTITY,
        [TrabajadorNome] nvarchar(max) NULL,
        [TrabajadorNif] nvarchar(max) NULL,
        [IdEmpresa] int NOT NULL,
        [Fundae] bit NOT NULL,
        [SeguridadSocial] nvarchar(max) NULL,
        [FechaTrabajador] datetime2 NOT NULL,
        [Trabajadortipo] nvarchar(max) NULL,
        [TrabajadorAlta] bit NOT NULL,
        [AnoTrabajador] int NOT NULL,
        [Mestrabajador] int NOT NULL,
        CONSTRAINT [PK_Trabajadores] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210506082754_FirstMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210506082754_FirstMigration', N'5.0.6');
END;
GO

COMMIT;
GO


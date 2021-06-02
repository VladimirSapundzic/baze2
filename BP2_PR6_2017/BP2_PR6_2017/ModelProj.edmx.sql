
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2021 17:12:46
-- Generated from EDMX file: C:\Users\Vlada\Desktop\baze2\BP2_PR6_2017\BP2_PR6_2017\ModelProj.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [baze];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_NagradaOsvaja]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OsvajaSet] DROP CONSTRAINT [FK_NagradaOsvaja];
GO
IF OBJECT_ID(N'[dbo].[FK_IzdavacKnjiga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KnjigaSet] DROP CONSTRAINT [FK_IzdavacKnjiga];
GO
IF OBJECT_ID(N'[dbo].[FK_AutorKnjiga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KnjigaSet] DROP CONSTRAINT [FK_AutorKnjiga];
GO
IF OBJECT_ID(N'[dbo].[FK_SkladisteNalazi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NalaziSet] DROP CONSTRAINT [FK_SkladisteNalazi];
GO
IF OBJECT_ID(N'[dbo].[FK_KupacRecenzija]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecenzijaSet] DROP CONSTRAINT [FK_KupacRecenzija];
GO
IF OBJECT_ID(N'[dbo].[FK_KupacKupovina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KupovinaSet] DROP CONSTRAINT [FK_KupacKupovina];
GO
IF OBJECT_ID(N'[dbo].[FK_KreiraAdministrator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KreiraSet] DROP CONSTRAINT [FK_KreiraAdministrator];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministratorKreira]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KreiraSet] DROP CONSTRAINT [FK_AdministratorKreira];
GO
IF OBJECT_ID(N'[dbo].[FK_KnjigaRecenzija]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecenzijaSet] DROP CONSTRAINT [FK_KnjigaRecenzija];
GO
IF OBJECT_ID(N'[dbo].[FK_KnjigaNalazi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NalaziSet] DROP CONSTRAINT [FK_KnjigaNalazi];
GO
IF OBJECT_ID(N'[dbo].[FK_KnjigaKupovina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KupovinaSet] DROP CONSTRAINT [FK_KnjigaKupovina];
GO
IF OBJECT_ID(N'[dbo].[FK_OsvajaKnjiga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OsvajaSet] DROP CONSTRAINT [FK_OsvajaKnjiga];
GO
IF OBJECT_ID(N'[dbo].[FK_Kupac_inherits_Korisnik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KorisnikSet_Kupac] DROP CONSTRAINT [FK_Kupac_inherits_Korisnik];
GO
IF OBJECT_ID(N'[dbo].[FK_Administrator_inherits_Korisnik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KorisnikSet_Administrator] DROP CONSTRAINT [FK_Administrator_inherits_Korisnik];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[NagradaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NagradaSet];
GO
IF OBJECT_ID(N'[dbo].[IzdavacSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IzdavacSet];
GO
IF OBJECT_ID(N'[dbo].[AutorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AutorSet];
GO
IF OBJECT_ID(N'[dbo].[SkladisteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SkladisteSet];
GO
IF OBJECT_ID(N'[dbo].[KorisnikSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KorisnikSet];
GO
IF OBJECT_ID(N'[dbo].[RecenzijaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RecenzijaSet];
GO
IF OBJECT_ID(N'[dbo].[KnjigaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KnjigaSet];
GO
IF OBJECT_ID(N'[dbo].[NalaziSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NalaziSet];
GO
IF OBJECT_ID(N'[dbo].[OsvajaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OsvajaSet];
GO
IF OBJECT_ID(N'[dbo].[KreiraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KreiraSet];
GO
IF OBJECT_ID(N'[dbo].[KupovinaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KupovinaSet];
GO
IF OBJECT_ID(N'[dbo].[KorisnikSet_Kupac]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KorisnikSet_Kupac];
GO
IF OBJECT_ID(N'[dbo].[KorisnikSet_Administrator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KorisnikSet_Administrator];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'NagradaSet'
CREATE TABLE [dbo].[NagradaSet] (
    [IdNgr] int IDENTITY(1,1) NOT NULL,
    [NazivNagrade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'IzdavacSet'
CREATE TABLE [dbo].[IzdavacSet] (
    [IdIzd] int IDENTITY(1,1) NOT NULL,
    [NazivIzdavaca] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AutorSet'
CREATE TABLE [dbo].[AutorSet] (
    [IdAut] int IDENTITY(1,1) NOT NULL,
    [ImeAutora] nvarchar(max)  NOT NULL,
    [PrezAutora] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SkladisteSet'
CREATE TABLE [dbo].[SkladisteSet] (
    [IdSkl] int IDENTITY(1,1) NOT NULL,
    [AdrSkladista] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KorisnikSet'
CREATE TABLE [dbo].[KorisnikSet] (
    [IdKor] int IDENTITY(1,1) NOT NULL,
    [ImeKor] nvarchar(max)  NOT NULL,
    [PrezKor] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RecenzijaSet'
CREATE TABLE [dbo].[RecenzijaSet] (
    [KnjigaISBN] int  NOT NULL,
    [KupacIdKor] int  NOT NULL,
    [Id] int  NOT NULL,
    [Komentar] nvarchar(max)  NOT NULL,
    [Ocena] int  NOT NULL,
    [Kupac_IdKor] int  NOT NULL
);
GO

-- Creating table 'KnjigaSet'
CREATE TABLE [dbo].[KnjigaSet] (
    [ISBN] int IDENTITY(1,1) NOT NULL,
    [AutorIdAut] int  NOT NULL,
    [IzdavacIdIzd] int  NOT NULL
);
GO

-- Creating table 'NalaziSet'
CREATE TABLE [dbo].[NalaziSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SkladisteIdSkl] int  NOT NULL,
    [Knjiga_ISBN] int  NOT NULL
);
GO

-- Creating table 'OsvajaSet'
CREATE TABLE [dbo].[OsvajaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NagradaIdNgr] int  NOT NULL,
    [KnjigaISBN1] int  NOT NULL
);
GO

-- Creating table 'KreiraSet'
CREATE TABLE [dbo].[KreiraSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AdministratorIdKor] int  NOT NULL,
    [Administrator_IdKor] int  NOT NULL,
    [KreiranAdministrator_IdKor] int  NOT NULL
);
GO

-- Creating table 'KupovinaSet'
CREATE TABLE [dbo].[KupovinaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [KupacIdKor] int  NOT NULL,
    [Kupac_IdKor] int  NOT NULL,
    [Knjiga_ISBN] int  NOT NULL
);
GO

-- Creating table 'KorisnikSet_Kupac'
CREATE TABLE [dbo].[KorisnikSet_Kupac] (
    [stanjeRacuna] int  NOT NULL,
    [IdKor] int  NOT NULL
);
GO

-- Creating table 'KorisnikSet_Administrator'
CREATE TABLE [dbo].[KorisnikSet_Administrator] (
    [DatumKreiranja] datetime  NOT NULL,
    [IdKor] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdNgr] in table 'NagradaSet'
ALTER TABLE [dbo].[NagradaSet]
ADD CONSTRAINT [PK_NagradaSet]
    PRIMARY KEY CLUSTERED ([IdNgr] ASC);
GO

-- Creating primary key on [IdIzd] in table 'IzdavacSet'
ALTER TABLE [dbo].[IzdavacSet]
ADD CONSTRAINT [PK_IzdavacSet]
    PRIMARY KEY CLUSTERED ([IdIzd] ASC);
GO

-- Creating primary key on [IdAut] in table 'AutorSet'
ALTER TABLE [dbo].[AutorSet]
ADD CONSTRAINT [PK_AutorSet]
    PRIMARY KEY CLUSTERED ([IdAut] ASC);
GO

-- Creating primary key on [IdSkl] in table 'SkladisteSet'
ALTER TABLE [dbo].[SkladisteSet]
ADD CONSTRAINT [PK_SkladisteSet]
    PRIMARY KEY CLUSTERED ([IdSkl] ASC);
GO

-- Creating primary key on [IdKor] in table 'KorisnikSet'
ALTER TABLE [dbo].[KorisnikSet]
ADD CONSTRAINT [PK_KorisnikSet]
    PRIMARY KEY CLUSTERED ([IdKor] ASC);
GO

-- Creating primary key on [Id] in table 'RecenzijaSet'
ALTER TABLE [dbo].[RecenzijaSet]
ADD CONSTRAINT [PK_RecenzijaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ISBN] in table 'KnjigaSet'
ALTER TABLE [dbo].[KnjigaSet]
ADD CONSTRAINT [PK_KnjigaSet]
    PRIMARY KEY CLUSTERED ([ISBN] ASC);
GO

-- Creating primary key on [Id] in table 'NalaziSet'
ALTER TABLE [dbo].[NalaziSet]
ADD CONSTRAINT [PK_NalaziSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OsvajaSet'
ALTER TABLE [dbo].[OsvajaSet]
ADD CONSTRAINT [PK_OsvajaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KreiraSet'
ALTER TABLE [dbo].[KreiraSet]
ADD CONSTRAINT [PK_KreiraSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KupovinaSet'
ALTER TABLE [dbo].[KupovinaSet]
ADD CONSTRAINT [PK_KupovinaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdKor] in table 'KorisnikSet_Kupac'
ALTER TABLE [dbo].[KorisnikSet_Kupac]
ADD CONSTRAINT [PK_KorisnikSet_Kupac]
    PRIMARY KEY CLUSTERED ([IdKor] ASC);
GO

-- Creating primary key on [IdKor] in table 'KorisnikSet_Administrator'
ALTER TABLE [dbo].[KorisnikSet_Administrator]
ADD CONSTRAINT [PK_KorisnikSet_Administrator]
    PRIMARY KEY CLUSTERED ([IdKor] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [NagradaIdNgr] in table 'OsvajaSet'
ALTER TABLE [dbo].[OsvajaSet]
ADD CONSTRAINT [FK_NagradaOsvaja]
    FOREIGN KEY ([NagradaIdNgr])
    REFERENCES [dbo].[NagradaSet]
        ([IdNgr])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NagradaOsvaja'
CREATE INDEX [IX_FK_NagradaOsvaja]
ON [dbo].[OsvajaSet]
    ([NagradaIdNgr]);
GO

-- Creating foreign key on [IzdavacIdIzd] in table 'KnjigaSet'
ALTER TABLE [dbo].[KnjigaSet]
ADD CONSTRAINT [FK_IzdavacKnjiga]
    FOREIGN KEY ([IzdavacIdIzd])
    REFERENCES [dbo].[IzdavacSet]
        ([IdIzd])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IzdavacKnjiga'
CREATE INDEX [IX_FK_IzdavacKnjiga]
ON [dbo].[KnjigaSet]
    ([IzdavacIdIzd]);
GO

-- Creating foreign key on [AutorIdAut] in table 'KnjigaSet'
ALTER TABLE [dbo].[KnjigaSet]
ADD CONSTRAINT [FK_AutorKnjiga]
    FOREIGN KEY ([AutorIdAut])
    REFERENCES [dbo].[AutorSet]
        ([IdAut])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutorKnjiga'
CREATE INDEX [IX_FK_AutorKnjiga]
ON [dbo].[KnjigaSet]
    ([AutorIdAut]);
GO

-- Creating foreign key on [SkladisteIdSkl] in table 'NalaziSet'
ALTER TABLE [dbo].[NalaziSet]
ADD CONSTRAINT [FK_SkladisteNalazi]
    FOREIGN KEY ([SkladisteIdSkl])
    REFERENCES [dbo].[SkladisteSet]
        ([IdSkl])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SkladisteNalazi'
CREATE INDEX [IX_FK_SkladisteNalazi]
ON [dbo].[NalaziSet]
    ([SkladisteIdSkl]);
GO

-- Creating foreign key on [Kupac_IdKor] in table 'RecenzijaSet'
ALTER TABLE [dbo].[RecenzijaSet]
ADD CONSTRAINT [FK_KupacRecenzija]
    FOREIGN KEY ([Kupac_IdKor])
    REFERENCES [dbo].[KorisnikSet_Kupac]
        ([IdKor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KupacRecenzija'
CREATE INDEX [IX_FK_KupacRecenzija]
ON [dbo].[RecenzijaSet]
    ([Kupac_IdKor]);
GO

-- Creating foreign key on [Kupac_IdKor] in table 'KupovinaSet'
ALTER TABLE [dbo].[KupovinaSet]
ADD CONSTRAINT [FK_KupacKupovina]
    FOREIGN KEY ([Kupac_IdKor])
    REFERENCES [dbo].[KorisnikSet_Kupac]
        ([IdKor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KupacKupovina'
CREATE INDEX [IX_FK_KupacKupovina]
ON [dbo].[KupovinaSet]
    ([Kupac_IdKor]);
GO

-- Creating foreign key on [Administrator_IdKor] in table 'KreiraSet'
ALTER TABLE [dbo].[KreiraSet]
ADD CONSTRAINT [FK_KreiraAdministrator]
    FOREIGN KEY ([Administrator_IdKor])
    REFERENCES [dbo].[KorisnikSet_Administrator]
        ([IdKor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KreiraAdministrator'
CREATE INDEX [IX_FK_KreiraAdministrator]
ON [dbo].[KreiraSet]
    ([Administrator_IdKor]);
GO

-- Creating foreign key on [KreiranAdministrator_IdKor] in table 'KreiraSet'
ALTER TABLE [dbo].[KreiraSet]
ADD CONSTRAINT [FK_AdministratorKreira]
    FOREIGN KEY ([KreiranAdministrator_IdKor])
    REFERENCES [dbo].[KorisnikSet_Administrator]
        ([IdKor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministratorKreira'
CREATE INDEX [IX_FK_AdministratorKreira]
ON [dbo].[KreiraSet]
    ([KreiranAdministrator_IdKor]);
GO

-- Creating foreign key on [KnjigaISBN] in table 'RecenzijaSet'
ALTER TABLE [dbo].[RecenzijaSet]
ADD CONSTRAINT [FK_KnjigaRecenzija]
    FOREIGN KEY ([KnjigaISBN])
    REFERENCES [dbo].[KnjigaSet]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KnjigaRecenzija'
CREATE INDEX [IX_FK_KnjigaRecenzija]
ON [dbo].[RecenzijaSet]
    ([KnjigaISBN]);
GO

-- Creating foreign key on [Knjiga_ISBN] in table 'NalaziSet'
ALTER TABLE [dbo].[NalaziSet]
ADD CONSTRAINT [FK_KnjigaNalazi]
    FOREIGN KEY ([Knjiga_ISBN])
    REFERENCES [dbo].[KnjigaSet]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KnjigaNalazi'
CREATE INDEX [IX_FK_KnjigaNalazi]
ON [dbo].[NalaziSet]
    ([Knjiga_ISBN]);
GO

-- Creating foreign key on [Knjiga_ISBN] in table 'KupovinaSet'
ALTER TABLE [dbo].[KupovinaSet]
ADD CONSTRAINT [FK_KnjigaKupovina]
    FOREIGN KEY ([Knjiga_ISBN])
    REFERENCES [dbo].[KnjigaSet]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KnjigaKupovina'
CREATE INDEX [IX_FK_KnjigaKupovina]
ON [dbo].[KupovinaSet]
    ([Knjiga_ISBN]);
GO

-- Creating foreign key on [KnjigaISBN1] in table 'OsvajaSet'
ALTER TABLE [dbo].[OsvajaSet]
ADD CONSTRAINT [FK_OsvajaKnjiga]
    FOREIGN KEY ([KnjigaISBN1])
    REFERENCES [dbo].[KnjigaSet]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OsvajaKnjiga'
CREATE INDEX [IX_FK_OsvajaKnjiga]
ON [dbo].[OsvajaSet]
    ([KnjigaISBN1]);
GO

-- Creating foreign key on [IdKor] in table 'KorisnikSet_Kupac'
ALTER TABLE [dbo].[KorisnikSet_Kupac]
ADD CONSTRAINT [FK_Kupac_inherits_Korisnik]
    FOREIGN KEY ([IdKor])
    REFERENCES [dbo].[KorisnikSet]
        ([IdKor])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdKor] in table 'KorisnikSet_Administrator'
ALTER TABLE [dbo].[KorisnikSet_Administrator]
ADD CONSTRAINT [FK_Administrator_inherits_Korisnik]
    FOREIGN KEY ([IdKor])
    REFERENCES [dbo].[KorisnikSet]
        ([IdKor])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
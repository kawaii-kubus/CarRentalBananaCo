USE master;
GO
IF DB_ID(N'BananaCarRental') IS NOT NULL
DROP DATABASE BananaCarRental
GO
CREATE database BananaCarRental
GO
USE BananaCarRental
GO
CREATE TABLE [User]
(
Id UNIQUEIDENTIFIER primary Key default NEWID(),
Username nvarchar(50) unique not null,
[Password] nvarchar(100) not null,
[Name] nvarchar(50) not null,
LastName nvarchar(50) not null,
Email nvarchar(100) unique not null
)
GO
CREATE TABLE [dbo].[Status](
[ID] [int] Primary Key Identity,
[DostepnoscSamochodu] [nvarchar] (100) NOT NULL)
GO
CREATE TABLE [dbo].[ListaSamochodow](
[ID] [int] Primary Key Identity,
[Marka] [nvarchar] (50) NOT NULL,
[Model] [nvarchar] (100) NOT NULL,
[Nadwozie] [nvarchar] (250) NOT NULL,
[MocSilnika] [nvarchar] (50) NOT NULL,
[StatusID] [int] FOREIGN KEY REFERENCES Status(ID))
GO
CREATE TABLE [dbo].[Pracownicy](
[ID] [int] Primary Key Identity,
[Imie] [nvarchar] (50) NOT NULL,
[Nazwisko] [nvarchar] (100) NOT NULL,
[Email] [nvarchar] (100) NOT NULL,
[Telefon] [nvarchar] (20) NOT NULL,
[StatusID] [int] FOREIGN KEY REFERENCES Status(ID))
GO
CREATE TABLE [dbo].[ZamowieniaSamochodow](
[ID] [int] Primary Key Identity,
[SamochodID] [int] FOREIGN KEY REFERENCES ListaSamochodow(ID),
[DataZamowienia] [datetime] NOT NULL,
[StatusID] [int] FOREIGN KEY REFERENCES Status(ID))
GO

insert into [User] values (NEWID(), 'admin','admin','Admin','Adminowski','admin@example.com')
insert into [User] values (NEWID(), 'kuba','C','Jakub','C','jakub@example.com')
insert into [User] values (NEWID(), 'test','test','Testowy','Tester','test@example.com')
GO

INSERT INTO Status VALUES
('Dostepny'),
('Niedostepny')
GO

INSERT INTO ListaSamochodow VALUES
('Audi','Q7','Combi','228hp',1),
('BMW','E39','Sedan','134hp',1),
('Lamborghini','Huracan','Coupe','500hp',1 ),
('Nissan','R33 Skyline GT-R 40th Anniversary','Coupe','276hp', 2),
('Volkswagen','Golf 7 GTI','Hatchback','230hp',1),
('Audi','80 B4 ','Sedan','53hp', 1)
GO

INSERT INTO Pracownicy VALUES
('Jakub','Cieciel¹g','jakubc@example.com','666997991',1),
('Robert','Karaœ','karaœ@example.com','111333222',1),
('Mariusz','Pudzianowski','blachy@example.com','899001221',1),
('Micha³','Milewicz','milewicz@example.com','909666111',2),
('Artur','Rojek','rojek@example.com','113777888',1)
GO
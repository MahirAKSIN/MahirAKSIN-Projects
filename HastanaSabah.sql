   
CREATE DATABASE HastaneSabah
GO

USE HastaneSabah
GO

CREATE TABLE Hastalar
(
	ID INT IDENTITY(1,1) NOT NULL,
	TcNo CHAR(11) UNIQUE NOT NULL,
	Ad VARCHAR(20) NOT NULL,
	Soyad VARCHAR(20) NOT NULL,
	Cinsiyet CHAR(1) NOT NULL,
	Adres VARCHAR(30) NULL,
	Telefon CHAR(11) NULL,
	Mail VARCHAR(30) NULL,
	PRIMARY KEY(ID)
)
GO

INSERT INTO Hastalar
(TcNo,Ad,Soyad,Cinsiyet)
VALUES
('54565588844','Erencan','Germirli','E'),
('78483312211','Selin','Fergenç','K'),
('56667777786','Sadullah','Kullar','E'),
('88898998888','Neþe','Libalýk','K')
GO

USE HastaneSabah
CREATE TABLE Bolumler
(
	ID INT IDENTITY(1,1) NOT NULL,
	BolumAd VARCHAR(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
)
GO

INSERT INTO Bolumler
VALUES
('Dahiliye'),('Nöroloji'),('Ortopedi')
GO

USE HastaneSabah
CREATE TABLE Doktorlar
(
	ID INT IDENTITY(1,1) NOT NULL,
	SicilNo VARCHAR(5) UNIQUE NOT NULL,
	AdSoyad VARCHAR(40) NOT NULL,
	Tel VARCHAR(11) NULL,
	Mail VARCHAR(30) NULL,
	BolumID INT NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(BolumID) REFERENCES Bolumler(ID)
)
GO

INSERT INTO Doktorlar VALUES
('58564','Ali Can','553444888','alican@gmail.com',1),
('25486','Demet Evgar','5556664477','demetevgar@gmail.com',1),
('59877','Sedat Kanar','6664447788','sedatkanar@gmail.com',3),
('33666','Ferhunde Haným','5556665588','ferhundehanim@gmail.com',2),
('44147','Zafer Kimki','3554447779','zaferkimki@gmail.com',2)
GO



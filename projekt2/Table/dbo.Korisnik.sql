CREATE TABLE [dbo].[Korisnik] 
( 
	[ID_korisnik] INTEGER NOT NULL IDENTITY, 
	[OIB] INTEGER NOT NULL, 
	[Ime] VARCHAR(50) NOT NULL, 
	[Prezime] VARCHAR(50) NOT NULL, 
	[Adress] VARCHAR(500) NOT NULL, 
    [Broj Telefona] NCHAR(10) NOT NULL, 
    [e-mail] VARCHAR(100) NOT NULL, 
    [password] VARCHAR(32) NOT NULL, 
    PRIMARY KEY(ID_korisnik) 
)
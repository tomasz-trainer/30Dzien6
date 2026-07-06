
CREATE TABLE Zawodnicy (
    Id_zawodnika INT NOT NULL PRIMARY KEY identity(1,1),
    Id_trenera INT NULL,
    Imie NVARCHAR(255) NOT NULL,
    Nazwisko NVARCHAR(255) NOT NULL,
    Kraj CHAR(3) NOT NULL,
    Data_ur DATETIME2 NOT NULL,
    Wzrost INT NOT NULL,
    Waga INT NOT NULL
);



drop table Zawodnicy


select * from Zawodnicy order by wzrost


insert into zawodnicy values (4,'marcin','bachleda'...)+


INSERT INTO Zawodnicy (Id_trenera, Imie, Nazwisko, Kraj, Data_ur, Wzrost, Waga) VALUES
(4, N'Marcin', N'BACHLEDA2', 'POL', '1982-09-04', 166, 56),
(4, N'Robert', N'MATEJA3', 'POL', '1974-10-05', 180, 63),
(5, N'Alexander', N'HERR', 'GER', '1978-10-04', 173, 65),
(5, N'Stephan', N'HOCKE', 'GER', '1983-10-20', 178, 59),
(5, N'Martin', N'SCHMITT', 'GER', '1978-01-29', 181, 64),
(5, N'Michael', N'UHRMANN', 'GER', '1978-09-09', 184, 64),
(5, N'Georg', N'SPAETH', 'GER', '1981-02-24', 187, 68),
(2, N'Matti', N'HAUTAMAEKI', 'FIN', '1981-07-14', 174, 57),
(2, N'Tami', N'KIURU', 'FIN', '1976-09-13', 183, 59),
(2, N'Janne', N'AHONEN', 'FIN', '1977-05-11', 184, 67),
(1, N'Martin', N'HOELLWARTH5', 'AUT', '1974-04-13', 182, 67),
(1, N'Thomas', N'MORGENSTERN2', 'AUT', '1986-10-30', 174, 57),
(3, N'Tommy', N'INGEBRIGTSEN', 'NOR', '1977-08-08', 179, 56),
(3, N'Bjoern-Einar', N'ROMOEREN', 'NOR', '1981-04-01', 182, 63),
(3, N'Roar', N'LJOEKELSOEY', 'NOR', '1976-05-31', 175, 62),
(0, N'Alan', N'ALBORN', 'USA', '1980-12-13', 177, 57),
(4, N'Adam', N'MAŁYSZ', 'POL', '1977-12-03', 169, 60);


select imie from zawodnicy where Id_zawodnika = 1

alter table Zawodnicy 
alter column Id_trenera INT NULL

update zawodnicy set id_trenera = null where id_trenera=0
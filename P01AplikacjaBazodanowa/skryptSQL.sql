
CREATE TABLE Zawodnicy (
    Id_zawodnika INT NOT NULL PRIMARY KEY,
    Id_trenera INT NOT NULL,
    Imie NVARCHAR(50) NOT NULL,
    Nazwisko NVARCHAR(100) NOT NULL,
    Kraj CHAR(3) NOT NULL,
    Data_ur DATE NOT NULL,
    Wzrost INT NOT NULL,
    Waga INT NOT NULL
);



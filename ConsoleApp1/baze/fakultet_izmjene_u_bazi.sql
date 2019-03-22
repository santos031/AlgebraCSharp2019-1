--Z.4.4.
USE Fakultet
SELECT oznDvorana, nazPred, sat
INTO predmetiDvorane
FROM pred JOIN rezervacija
ON pred.sifPred=rezervacija.sifPred

--Z.4.5.
USE Fakultet
GO
CREATE VIEW Stanovanje
AS
	SELECT imeNastavnik, prezNastavnik, nazMjesto
	FROM nastavnik JOIN mjesto
	ON nastavnik.pbrStan=mjesto.pbr

SELECT *
FROM Stanovanje

--Z.4.6.
USE Fakultet
GO
CREATE VIEW ProlaznostIspita
AS
	SELECT imeStud, prezStud, nazPred, ocjena, imeNastavnik, prezNastavnik
	FROM stud JOIn ispit
	ON stud.mbrStud=ispit.mbrStud
	JOIN nastavnik
	ON nastavnik.sifNastavnik=ispit.sifNastavnik
	JOIN pred
	ON pred.sifPred=ispit.sifPred

SELECT * FROM ProlaznostIspita
USE Fakultet
--3.2.
SELECT
stud.mbrStud
, concat(stud.imeStud, ' ', stud.prezStud) AS 'ime i prezime'
FROM stud

--3.3.
SELECT DISTINCT stud.imeStud
FROM stud
ORDER BY stud.imeStud DESC

--3.4
SELECT stud.mbrStud
FROM stud INNER JOIN ispit
ON stud.mbrStud= ispit.mbrStud
WHERE ispit.sifPred=146
AND ispit.ocjena>1

--3.22
SELECT *
-- n.*,
-- m1.nazMjesto,
-- m2.nazMjesto,
-- z1.nazZupanija
FROM nastavnik n LEFT JOIN ispit i
ON n.sifNastavnik=i.sifNastavnik
INNER JOIN stud s
ON i.mbrStud=s.mbrStud
LEFT JOIN mjesto m1 ON m1.pbr=n.pbrStan 
LEFT JOIN zupanija z1 ON z1.sifZupanija=m1.sifZupanija
LEFT JOIN mjesto m2 ON m2.pbr=s.pbrStan
LEFT JOIN zupanija z2 ON z2.sifZupanija=m2.sifZupanija
WHERE m1.sifZupanija=m2.sifZupanija 
AND m1.pbr <> m2.pbr

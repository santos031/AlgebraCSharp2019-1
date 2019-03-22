--Z 3.12.
USE Fakultet
SELECT imeStud, prezStud, ocjena
FROM stud, ispit	
WHERE stud.mbrStud=ispit.mbrStud
AND ocjena=1
AND (sifPred BETWEEN 220 AND 240)

--Z 3.13.
USE Fakultet
SELECT DISTINCT imeStud, prezStud, ocjena
FROM stud JOIN ispit	
ON stud.mbrStud=ispit.mbrStud
WHERE ocjena=3

-- Z 3.14.
USE Fakultet
SELECT DISTINCT nazPred 
FROM pred
JOIN ispit
ON ispit.sifPred=pred.sifPred

--Z 3.15
USE Fakultet
SELECT DISTINCT nazPred 
FROM pred
LEFT JOIN ispit
ON pred.sifPred=ispit.sifPred
WHERE datIspit IS NULL
ORDER BY nazPred ASC

--Z 3.16
USE Fakultet
SELECT nazPred, oznDvorana
FROM pred LEFT JOIN rezervacija
ON pred.sifPred=rezervacija.sifPred
WHERE brojSatiTjedno>2

--Z 3.17
USE Fakultet
SELECT nazPred, nazOrgjed, upisanoStud
FROM pred JOIN orgjed
ON pred.sifOrgjed=orgjed.sifOrgjed
WHERE upisanoStud>20

--Z 3.18
USE Fakultet
SELECT DISTINCT nazMjesto
FROM mjesto JOIN stud
ON mjesto.pbr=stud.pbrStan

--Z 3.19
USE Fakultet
SELECT imeStud, prezStud, nazPred, ocjena
FROM ispit i
JOIN stud s ON i.mbrStud=s.mbrStud
JOIN pred p ON p.sifPred=i.sifPred

--Z 3.20
USE Fakultet
SELECT nazPred, oznDvorana, nazOrgjed
FROM pred JOIN rezervacija
ON pred.sifPred=rezervacija.sifPred
JOIN orgjed ON orgjed.sifOrgjed=pred.sifOrgjed

--Z 3.21
USE Fakultet
SELECT DISTINCT imeStud, prezStud, nazMjesto
FROM stud
JOIN mjesto ON mjesto.pbr=stud.pbrStan
JOIN ispit ON stud.mbrStud=ispit.mbrStud
JOIN pred ON pred.sifPred=ispit.sifPred
WHERE nazPred='Osnove baza podataka' AND ocjena=1

--3.26
USE Fakultet
SELECT imeStud, prezStud
FROM stud
JOIN mjesto m1 ON stud.pbrRod= m1.pbr
JOIN mjesto m2 ON stud.pbrStan=m2.pbr
WHERE pbrRod<>pbrStan
AND m1.sifZupanija = m2.sifZupanija

--3.27
USE Fakultet
SELECT stud.*, nastavnik.*
FROM stud, nastavnik
WHERE stud.prezStud=nastavnik.prezNastavnik
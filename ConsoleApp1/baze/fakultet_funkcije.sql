--Z 5.1.
USE Fakultet
SELECT imeStud, prezStud, nazMjesto
FROM stud JOIN mjesto
ON mjesto.pbr=stud.pbrRod
WHERE imeStud LIKE 'F% '

--Z 5.2.
USE Fakultet
SELECT imeNAstavnik, prezNastavnik, nazMjesto
FROM nastavnik JOIN mjesto
ON mjesto.pbr=nastavnik.pbrStan
WHERE SUBSTRING (nazMjesto,3,1)= 'Z'

--Z 5.3.
USE Fakultet
SELECT imeStud, prezStud, imeNAstavnik, prezNastavnik
FROM stud JOIN ispit
ON ispit.mbrStud=stud.mbrStud
JOIN nastavnik
ON ispit.sifNastavnik=nastavnik.sifNastavnik
WHERE SUBSTRING(imeStud, 5,1)= SUBSTRING(imeNastavnik, 5,1)

-- Z 5.6
USE Fakultet
SELECT DISTINCT imeStud, prezStud, datIspit
FROM stud JOIN ispit
ON stud.mbrStud=ispit.mbrStud
WHERE DAY(datIspit) BETWEEN 10 AND 20

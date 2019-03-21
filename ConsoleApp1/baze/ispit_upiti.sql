--4.ZADATAK
USE Ispit
SELECT p.ime,
p.prezime, 
DATEDIFF(d, m.posudio,GETDATE())as brojDana
FROM mediji m 
LEFT JOIN prijatelji p 
ON m.prijatelj_id=p.id
WHERE m.vratio IS NULL

--5.ZADATAK
UPDATE  mediji SET vratio= GETDATE()
WHERE vratio IS NULL

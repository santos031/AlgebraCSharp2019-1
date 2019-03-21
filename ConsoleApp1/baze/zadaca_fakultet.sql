/* 3.2.ISPISVANJE IME I PREZIME NASTAVNIKA*/
USE Fakultet
SELECT imeNastavnik,
prezNastavnik
FROM dbo.nastavnik
GO


/*3.3.ISPIS MATICNOG BROJA,IMENA I PREZIMENA UCENIKA, S TIME DA SU IME I PREZIME U JEDNOM STUPCU*/
USE Fakultet
SELECT imeStud + ' ' +  prezStud AS ime_prezime,
 mbrStud
 FROM dbo.stud
 GO


 /*3.4.ISPIS IME STUDENATA BEZ PONAVLJANJA ISTIH IME I SORTIRANO SILAZNO PO ABECEDI*/
 USE Fakultet
 SELECT DISTINCT imeStud
 FROM stud
 ORDER BY imeStud DESC
 GO
 

 /*3.5.ISPIS MATICNIH BR STUDENATA KOJI SU POLOZILI ISPIT SA SIFROM 146*/
 USE Fakultet
 SELECT mbrStud
 FROM ispit
 WHERE sifPred = 146
 GO
 

 /*3.6.ISPIS IMENA I PREZIMENA NASTAVNIKA, TE IZRACUN NJIHOVIH PLACA KROZ FORMULU (koef + 0.4)*800 */
 USE Fakultet
 SELECT imeNastavnik,
 prezNastavnik,
 (koef*0.4)*800 AS 'Pla�a'
 FROM nastavnik
 GO
 

 /*3.7.ISPIS IMENA I PREZIMENA NASTAVNIKA IZ PRETHODNOG ZADATKA KOJI IMAJU PLACE MANJE OD 3500 i VECE od 8000*/
 USE Fakultet
 SELECT imeNastavnik,
 prezNastavnik,
 (koef*0.4)*800 AS 'Pla�a'
 FROM nastavnik
 WHERE ((koef*0.4)*800 < 3500) OR ((koef*0.4)*800 > 8000)
 ORDER BY 'Pla�a' ASC
 GO
 

 /*3.8.ISPIS SVIH PODATAKA STUDENATA KOJIMA IME PO�INJE I ZAVR�AVA SA SAMOGLASNIKOM*/
 USE Fakultet
 SELECT * FROM stud
 WHERE imeStud LIKE '[a e i o u]%[a e i o u]'
 GO
 

 /*3.9.ISPIS SVIH PODATAKA STUDENATA KOJIMA IME PO�INJE I ZAVR�AVA BILO KOJIM ZNAKOM OSIM SAMOGLASNIKOM
 USE Fakultet
 SELECT * FROM stud
 WHERE imeStud LIKE '[^ a e i o u]%[^ a e i o u]'
 GO
 nest ne stima???????*/


 /*3.10.ISPIS SVIH PODATAKA STUDENATA KOJIMA IME PO�INJE ILI ZAVR�AVA SA SAMOGLASNIKOM
 USE Fakultet
 SELECT * FROM stud
 WHERE imeStud LIKE '[^ a e i o u]%' OR imeStud LIKE '%[^ a e i o u]'
 GO
 nest ne stima???????*/


 /*3.11.ISPIS SVIH PODATAKA STUDENATA KOJIMA IME ILI PREZIME SADRZI SLOVA n I k JEDNO IZA DRUGOGA*/
 USE Fakultet
 SELECT * FROM stud
 WHERE imeStud LIKE '%nk%' OR prezStud LIKE '%nk%'
 GO
 
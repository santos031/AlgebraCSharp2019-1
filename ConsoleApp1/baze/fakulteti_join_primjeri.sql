USE [Fakultet]
GO

CREATE VIEW v_nastavnici_mjesto AS 
SELECT [imeNastavnik] AS Imen
      ,[prezNastavnik] AS Prezime
	  ,[Fakultet].[dbo].[mjesto].nazMjesto AS 'Mjesto u kojem zivi'
  FROM [dbo].[nastavnik] INNER JOIN mjesto
  ON nastavnik.pbrStan = mjesto.pbr
GO

--mjesta iz kojih nema nastavnika
SELECT TOP (1000) [pbr]
        ,[nazMjesto]
		,[sifZupanija]
		,nastavnik.*
		FROM [dbo].[mjesto] 
		LEFT JOIN nastavnik
  ON mjesto.pbr = nastavnik.pbrStan
  WHERE nastavnik.koef IS NULL
  GO



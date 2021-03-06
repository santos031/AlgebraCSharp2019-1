/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (100) PERCENT o1.sifOrgjed
      ,o1.[nazOrgjed]
    --  ,o1[sifNadorgjed]
	  ,count (o2.[nazOrgjed]) AS 'broj zavoda'
  FROM [Fakultet].[dbo].[orgjed] o1 LEFT JOIN orgjed o2
  ON o1.sifOrgjed = o2.sifNadorgjed
  GROUP BY o1.sifOrgjed, o1.[nazOrgjed]
  HAVING count (o2.[nazOrgjed]) != 0
  ORDER BY 'broj zavoda' DESC
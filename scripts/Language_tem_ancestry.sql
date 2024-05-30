DROP TABLE IF EXISTS #AncestryTemp
CREATE TABLE #AncestryTemp (
	ID int identity(1,1) primary key,
    [name] VARCHAR(28),
    [language] VARCHAR(128)
);



Declare @JSON varchar(max)
SELECT @JSON=BulkColumn
FROM OPENROWSET (BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Ancestries_data.json', SINGLE_CLOB) import
If (ISJSON(@JSON)=1)
Print 'It is a valid JSON'
ELSE
Print 'Error in JSON format'
-- Corrigir a leitura dos dados do JSON
INSERT #AncestryTemp ([name],[language])
SELECT 
    [name] AS [name],
	[language] as [language]

FROM OPENJSON(@JSON)
WITH (
    [name] VARCHAR(50) '$.name',

	[language] varchar(50)  '$.language'

) AS Ancestries;


select * from #AncestryTemp


INSERT INTO Language_tem_ancestry (id_language, id_ancestry)
SELECT l.ID AS id_language, a.ID AS id_ancestry
FROM #AncestryTemp a
JOIN [Language] l ON CHARINDEX(l.Designation, a.[language]) > 0
JOIN Ancestry an ON a.[name] = an.[name];
select * from  Language_tem_ancestry order by id_ancestry

use rpg
--------------------------------------------language---------------------------------------------------------
go

DECLARE @json_data VARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Languages.json', SINGLE_CLOB
) AS datasource;

INSERT INTO [Language](Designation) 
SELECT  
    Designation
 
FROM OPENJSON (@json_data)
WITH
(

    Designation VARCHAR(28)
    
);

SELECT * FROM Language;



go
---------------------------------------------ancestry-------------------------------------------------------
go




Declare @JSON varchar(max)
SELECT @JSON=BulkColumn
FROM OPENROWSET (BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Ancestries_data.json', SINGLE_CLOB) import
If (ISJSON(@JSON)=1)
Print 'It is a valid JSON'
ELSE
Print 'Error in JSON format'

INSERT Ancestry ([name], hp, [size], speed, ability_boost, ability_flaw, vision, rarity)
SELECT 
    [name] AS [name],
    hp AS hp,
    [size] AS [size],
    CAST(REPLACE(speed, ' feet', '') AS INT) AS speed,
    ability_boost AS ability_boost,
    ability_flaw AS ability_flaw,
    vision AS vision,
    rarity AS rarity
FROM OPENJSON(@JSON)
WITH (
    [name] VARCHAR(50) '$.name',
    hp INT '$.hp',
    [size] VARCHAR(10) '$.size',
    speed NVARCHAR(20) '$.speed',
    ability_boost VARCHAR(50) '$.ability_boost',
    ability_flaw VARCHAR(50) '$.ability_flaw',
    vision VARCHAR(20) '$.vision',
    rarity VARCHAR(20) '$.rarity'
) AS Ancestries;
select * from Ancestry




go
---------------------------------------------language-ancestry--------------------------------------------------
go 

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

go
---------------------------------------------feats--------------------------------------------------
go 



DECLARE @json_data VARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Feats_data.json', SINGLE_CLOB
) AS datasource;

INSERT INTO Feats (rarity, prerequisite, summary, [name], [level]) 
SELECT rarity, prerequisite, summary, [name], [level] 
FROM OPENJSON (@json_data)
WITH
(
    [name] VARCHAR(28), 
    rarity CHAR(28),
    prerequisite VARCHAR(128),
    summary VARCHAR(128),
    [level] INT
);
select * from Feats



go
---------------------------------------------spells--------------------------------------------------
go 



DECLARE @json_data VARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Spells_data.json', SINGLE_CLOB
) AS datasource;

INSERT INTO Spells (spell_type, [name], actions, defense, [target], rarity, [trigger], area, [rank], heighten, duration, [range]) 
SELECT 
    spell_type, 
    [name], 
    actions, 
    defense, 
    [target], 
    rarity, 
    [trigger], 
    area, 
	CAST(REPLACE(REPLACE(REPLACE(REPLACE([rank], 'th', ''), 'rd', ''), 'nd', ''), 'st', '') AS INT),    
	heighten, 
    duration, 
    [range]
FROM OPENJSON (@json_data)
WITH
(
    spell_type CHAR(28),
    [name] VARCHAR(28),
    actions VARCHAR(28),
    defense VARCHAR(28),
    [target] VARCHAR(64),
    rarity CHAR(28),
    [trigger] VARCHAR(128),
    area VARCHAR(64),
    [rank] VARCHAR(16),
    heighten VARCHAR(64),
    duration VARCHAR(64),
    [range] VARCHAR(64)
);

SELECT * FROM Spells;



go
---------------------------------------------traits--------------------------------------------------
go 

-- Declare a variable to hold your data
DECLARE @TraitsList NVARCHAR(MAX);

-- Load the data from the file
SELECT @TraitsList = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\data\traits.txt',
    SINGLE_CLOB  -- Uses a single, continuous column data type
) AS j;



INSERT INTO Traits (designation, details)
SELECT TRIM(value) AS designation, 'Batatas' AS details  
FROM STRING_SPLIT(@TraitsList, ',');


SELECT * FROM Traits;




---------------------------------------------------------------background---------------------------------------------------------------------------
go

Declare @JSON varchar(max)
SELECT @JSON=BulkColumn
FROM OPENROWSET (BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Backgrounds_data.json', SINGLE_CLOB) import
If (ISJSON(@JSON)=1)
Print 'It is a valid JSON'
ELSE
Print 'Error in JSON format'

INSERT Background ([name], ability, skill, feat, rarity, summary)
SELECT 
    [name] AS [name],
    ability AS ability,
    skill AS skill,
    feat AS feat,
    rarity AS rarity,
    summary AS summary
FROM OPENJSON(@JSON)
WITH (
    [name] VARCHAR(50) '$.name',
    ability VARCHAR(50) '$.ability',
    skill VARCHAR(50) '$.skill',
    feat NVARCHAR(50) '$.feat',
    rarity VARCHAR(50) '$.rarity',
    summary VARCHAR(512) '$.summary'
) AS Backgrounds;
select * from Background

go
---------------------------------------------------------background-feats----------------------------------------------

DECLARE @JSON NVARCHAR(MAX)


SELECT @JSON = BulkColumn
FROM OPENROWSET (BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Backgrounds_data.json', SINGLE_CLOB) AS jsonImport

IF (ISJSON(@JSON) = 1)
    PRINT 'É um JSON válido'
ELSE
    PRINT 'Erro no formato JSON'


CREATE TABLE #TempBackground (
    [name] VARCHAR(28),
    ability VARCHAR(128),
    skill VARCHAR(128),
    feat VARCHAR(128),
    rarity VARCHAR(28),
    summary VARCHAR(512)
)


INSERT INTO #TempBackground ([name], ability, skill, feat, rarity, summary)
SELECT 
    JSON_VALUE(anc.value, '$.name') AS [name],
    JSON_VALUE(anc.value, '$.ability') AS ability,
    JSON_VALUE(anc.value, '$.skill') AS skill,
    JSON_VALUE(anc.value, '$.feat') AS feat,
    JSON_VALUE(anc.value, '$.rarity') AS rarity,
    JSON_VALUE(anc.value, '$.summary') AS summary
FROM OPENJSON(@JSON) AS anc

INSERT INTO Feats_tem_background (id_feat, id_background)
SELECT 
    f.ID AS id_feat,
    b.ID AS id_background
FROM 
    #TempBackground tb
JOIN 
    Background b ON tb.name = b.[name]
JOIN 
    Feats f ON tb.feat = f.[name]


DROP TABLE #TempBackground
select * from Feats_tem_background

go 
----------------------------------------------          -------------------------------------------
go
---------------------------------------------language-ancestry--------------------------------------------------
go 
go
---------------------------------------------language-ancestry--------------------------------------------------
go 
go
---------------------------------------------language-ancestry--------------------------------------------------
go 
go

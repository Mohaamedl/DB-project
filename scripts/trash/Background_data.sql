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
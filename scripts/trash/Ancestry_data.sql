
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


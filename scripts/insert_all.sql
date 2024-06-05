use rpg

--------------------------------------------tradition------------------------------------------------------
INSERT INTO Tradition ([name], details)
VALUES 
    ('Arcane', 'Arcane does everything besides healing. Extremely versatile and lots of strong utility.'),
    ('Divine', 'Divine has lots of healing and protection magic. Damage spells tend to be on the lower end unless you''re fighting undead or outsiders.'),
    ('Occult', 'Occult excels at subtle magic. Very few spells to affect the physical world. Main focuses are enchantment, illusion and divination. Nearly no elemental spells and very few ways to target Reflex saves.'),
    ('Primal', 'Primal is the opposite of occult. Nearly everything is a physical effect in some way. Lots of elemental spells and good healing options. Lacks subtle spells and has trouble targeting will saves. Also nearly no ways to deal with enemy spellcasters other than dispel magic (or blowing them up).');

select * from Tradition
--------------------------------------------language---------------------------------------------------------

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

INSERT #AncestryTemp ([name],[language])
SELECT 
    [name] AS [name],
	[language] as [language]

FROM OPENJSON(@JSON)
WITH (
    [name] VARCHAR(50) '$.name',

	[language] varchar(50)  '$.language'

) AS Ancestries;


INSERT INTO Language_tem_ancestry (id_language, id_ancestry)
SELECT l.ID AS id_language, a.ID AS id_ancestry
FROM #AncestryTemp a
JOIN [Language] l ON CHARINDEX(l.Designation, a.[language]) > 0
JOIN Ancestry an ON a.[name] = an.[name];
select * from  Language_tem_ancestry order by id_ancestry
DROP TABLE #AncestryTemp
go
---------------------------------------------feats--------------------------------------------------




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


DECLARE @TraitsList NVARCHAR(MAX);

SELECT @TraitsList = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\data\traits.txt',
    SINGLE_CLOB  
) AS j;



INSERT INTO Traits (designation, details)
SELECT TRIM(value) AS designation, 'Batatas' AS details  
FROM STRING_SPLIT(@TraitsList, ',');


SELECT * FROM Traits;



go
---------------------------------------------------------------background---------------------------------------------------------------------------


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
----------------------------------------------skills -------------------------------------------

DECLARE @json_data VARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\skills_data.json', SINGLE_CLOB
) AS datasource;

INSERT INTO Skills(designation,details) 
SELECT  
    designation,details
 
FROM OPENJSON (@json_data)
WITH
(

    designation VARCHAR(50),
	details varchar(512)
    
);

SELECT * FROM Skills;


go
---------------------------------------------spell-progression--------------------------------------------------
DECLARE @JsonData NVARCHAR(MAX)

SELECT @JsonData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Spells_progression_data.json', SINGLE_CLOB) AS j

INSERT INTO Spell_progression ([level], cantrips, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10)
SELECT 
    [Your Level] AS [level],
    Cantrips as cantrips ,
    CASE WHEN [1st] = '-' THEN NULL ELSE TRY_CAST(REPLACE([1st], '*', '') AS INT) END AS n1,
    CASE WHEN [2nd] = '-' THEN NULL ELSE TRY_CAST([2nd] AS INT) END AS n2,
    CASE WHEN [3rd] = '-' THEN NULL ELSE TRY_CAST([3rd] AS INT) END AS n3,
    CASE WHEN [4th] = '-' THEN NULL ELSE TRY_CAST([4th] AS INT) END AS n4,
    CASE WHEN [5th] = '-' THEN NULL ELSE TRY_CAST([5th] AS INT) END AS n5,
    CASE WHEN [6th] = '-' THEN NULL ELSE TRY_CAST([6th] AS INT) END AS n6,
    CASE WHEN [7th] = '-' THEN NULL ELSE TRY_CAST([7th] AS INT) END AS n7,
    CASE WHEN [8th] = '-' THEN NULL ELSE TRY_CAST([8th] AS INT) END AS n8,
    CASE WHEN [9th] = '-' THEN NULL ELSE TRY_CAST([9th] AS INT) END AS n9,
    CASE WHEN [10th] = '-' THEN NULL ELSE TRY_CAST(REPLACE([10th], '*', '') AS INT) END AS n10
FROM OPENJSON(@JsonData)
WITH (
    [Your Level] INT '$."Your Level"',
    Cantrips INT '$.Cantrips',
    [1st] NVARCHAR(10) '$."1st"',
    [2nd] NVARCHAR(10) '$."2nd"',
    [3rd] NVARCHAR(10) '$."3rd"',
    [4th] NVARCHAR(10) '$."4th"',
    [5th] NVARCHAR(10) '$."5th"',
    [6th] NVARCHAR(10) '$."6th"',
    [7th] NVARCHAR(10) '$."7th"',
    [8th] NVARCHAR(10) '$."8th"',
    [9th] NVARCHAR(10) '$."9th"',
    [10th] NVARCHAR(10) '$."10th"'
)

select* from Spell_progression

go
-----------------------------------------------------class-----------------------------------------------------

DECLARE @json_data VARCHAR(MAX);
DECLARE @classes_spell_prog VARCHAR(200);
SET @classes_spell_prog = 'Bard,Cleric,Druid,Magus,Oracle,Sorcerer,Summoner,Witch';

SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Classes_data.json', SINGLE_CLOB
) AS datasource;

INSERT INTO Class([name], HP, prof_attack, prof_defense, ability, spell_progression_id) 
SELECT  
    cls.[name],
    cls.hp,
    cls.attack_proficiency,
    cls.defense_proficiency,
    cls.ability,
    CASE
        WHEN prog.[name] IS NOT NULL THEN 1
        ELSE NULL
    END AS spell_progression_id
FROM OPENJSON (@json_data)
WITH
(
    [name] VARCHAR(50),
    hp INT,
    ability VARCHAR(50),
    attack_proficiency VARCHAR(512),
    defense_proficiency VARCHAR(512)
) AS cls
LEFT JOIN (
    SELECT value AS [name]
    FROM STRING_SPLIT(@classes_spell_prog, ',')
) AS prog
ON cls.[name] = prog.[name];


SELECT * FROM Class;



go
---------------------------------------------class-features--------------------------------------------------
DECLARE @JsonData NVARCHAR(MAX);
DECLARE @class_id INT;
SET @class_id = 1;

SELECT @JsonData = BulkColumn
FROM OPENROWSET(BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Class_features.json', SINGLE_CLOB) AS j;

WITH JsonData AS (
    SELECT 
        [Your Level] AS [level],
        [Class Features] AS feature,
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS rn
    FROM OPENJSON(@JsonData)
    WITH (
        [Your Level] INT '$."Your Level"',
        [Class Features] VARCHAR(128) '$."Class Features"'
    )
)
INSERT INTO Class_features ([level], class_id, feature)
SELECT 
    level,
    ((rn - 1) / 20) + 1 AS class_id,
    feature
FROM JsonData;

select * from Class_features
go
-----------------------------------------------class_tradition------------------------------------------------



INSERT INTO Class_tem_tradition (class_id, tradition_id)
SELECT c.ID, t.ID
FROM Class c, Tradition t
WHERE c.name = 'Magus' AND t.name = 'Arcane';

INSERT INTO Class_tem_tradition (class_id, tradition_id)
SELECT c.ID, t.ID
FROM Class c, Tradition t
WHERE c.name = 'Oracle' AND t.name = 'Divine';

INSERT INTO Class_tem_tradition (class_id, tradition_id)
SELECT c.ID, t.ID
FROM Class c, Tradition t
WHERE c.name = 'Psychic' AND t.name = 'Occult';

INSERT INTO Class_tem_tradition (class_id, tradition_id)
SELECT c.ID, t.ID
FROM Class c, Tradition t
WHERE c.name = 'Sorcerer' AND t.name IN ('Arcane', 'Divine', 'Occult', 'Primal');

INSERT INTO Class_tem_tradition (class_id, tradition_id)
SELECT c.ID, t.ID
FROM Class c, Tradition t
WHERE c.name = 'Summoner' AND t.name IN ('Arcane', 'Divine', 'Occult', 'Primal');

select * from Class_tem_tradition

go
--------------------------------------------------------Equipment-----------------------------------------------------------
IF OBJECT_ID('dbo.RemoveNonNumericChars', 'FN') IS NOT NULL
    DROP FUNCTION dbo.RemoveNonNumericChars;
GO

CREATE FUNCTION dbo.RemoveNonNumericChars (@input VARCHAR(50))
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @output VARCHAR(50);
    SET @output = '';

    DECLARE @i INT = 1;
    DECLARE @len INT = LEN(@input);
    
    WHILE @i <= @len
    BEGIN
        IF SUBSTRING(@input, @i, 1) LIKE '[0-9 ]'
        BEGIN
            SET @output = @output + SUBSTRING(@input, @i, 1);
        END
        SET @i = @i + 1;
    END
    
    RETURN @output;
END;
GO

IF OBJECT_ID('dbo.ConvertPriceToCP', 'FN') IS NOT NULL
    DROP FUNCTION dbo.ConvertPriceToCP;
GO

CREATE FUNCTION dbo.ConvertPriceToCP (@price VARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @converted_price INT;


    DECLARE @numeric_value VARCHAR(50) = LEFT(@price, PATINDEX('%[a-zA-Z]%', @price) - 1);


    DECLARE @unit_of_measure VARCHAR(50) = SUBSTRING(@price, PATINDEX('%[a-zA-Z]%', @price), LEN(@price));

    
    SET @converted_price = 
        CASE 
            WHEN @unit_of_measure = 'pp' THEN CAST(REPLACE(@numeric_value, ',', '') AS INT) * 1000
            WHEN @unit_of_measure = 'gp' THEN CAST(REPLACE(@numeric_value, ',', '') AS INT) * 100
            WHEN @unit_of_measure = 'sp' THEN CAST(REPLACE(@numeric_value, ',', '') AS INT) * 10
            WHEN @unit_of_measure = 'cp' THEN CAST(REPLACE(@numeric_value, ',', '') AS INT)
            ELSE 0 
        END;

    RETURN @converted_price;
END;
GO


DECLARE @json_data NVARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Equipment_data.json', SINGLE_CLOB
) AS datasource;


INSERT INTO Equipment([name], item_category, item_sub_category, usage, [bulk], rarity, weapon_category, [level], price)
SELECT  
    name,
    item_category,
    item_subcategory,
    usage,
    [bulk],
    rarity,
    weapon_category,  
    CASE 
        WHEN [level] = '-1' THEN 0
        ELSE CAST([level] AS INT)
    END AS [level],
    dbo.ConvertPriceToCP(price) 
FROM OPENJSON (@json_data)
WITH (
    [name] VARCHAR(64) '$.name',
    item_category CHAR(64) '$.item_category',
    item_subcategory CHAR(64) '$.item_subcategory',
    usage CHAR(28) '$.usage',
    [bulk] CHAR(1) '$.bulk',
    rarity CHAR(28) '$.rarity',
    [level] VARCHAR(10) '$.level',
    price VARCHAR(50) '$.price',
    weapon_category VARCHAR(28) '$.weapon_category' 
);


SELECT * FROM Equipment;
-------------------------------------------------Equipment_tem_Traits--------------------------------------------------------
SELECT @json_data = BulkColumn 
FROM OPENROWSET(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Equipment_data.json', 
    SINGLE_CLOB) AS datasource;

IF OBJECT_ID('tempdb..#EquipmentTraits') IS NOT NULL DROP TABLE #EquipmentTraits;
CREATE TABLE #EquipmentTraits (
    EquipmentName NVARCHAR(64),
    Traits NVARCHAR(400)
);

INSERT INTO #EquipmentTraits (EquipmentName, Traits)
SELECT 
    [name],
    [trait]
FROM 
    OPENJSON(@json_data)
    WITH (
        [name] NVARCHAR(64),
        [trait] NVARCHAR(400)
    );

IF OBJECT_ID('tempdb..#SplitTraits') IS NOT NULL DROP TABLE #SplitTraits;
CREATE TABLE #SplitTraits (
    EquipmentID INT,
    Trait NVARCHAR(100)
);

INSERT INTO #SplitTraits (EquipmentID, Trait)
SELECT 
    e.ID,
    LTRIM(RTRIM(value)) 
FROM 
    Equipment e
JOIN 
    #EquipmentTraits et ON e.[name] = et.EquipmentName
CROSS APPLY 
    STRING_SPLIT(et.Traits, ',');

INSERT INTO Equipment_tem_Traits (id_equipment, id_trait)
SELECT DISTINCT
    st.EquipmentID,
    t.ID
FROM 
    #SplitTraits st
JOIN 
    Traits t ON t.designation = st.Trait
WHERE 
    NOT EXISTS (
        SELECT 1 
        FROM Equipment_tem_Traits ett 
        WHERE ett.id_equipment = st.EquipmentID AND ett.id_trait = t.ID
    );

select * from Equipment_tem_traits

-----------------------------------------------Spells_tem_traits-------------------------------------------------------------
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Spells_data.json', SINGLE_CLOB
) AS datasource;

IF OBJECT_ID('tempdb..#SpellTraits') IS NOT NULL DROP TABLE #SpellTraits;
CREATE TABLE #SpellTraits (
    SpellName VARCHAR(28),
    TraitName NVARCHAR(100)
);

INSERT INTO #SpellTraits (SpellName, TraitName)
SELECT 
    TRIM([name]), 
    TRIM(value)
FROM 
    OPENJSON(@json_data)
    WITH (
        [name] VARCHAR(28) '$.name',
        traits NVARCHAR(400) '$.trait'
    )
CROSS APPLY STRING_SPLIT(traits, ',');

INSERT INTO Spells_tem_traits (id_spells, id_trait)
SELECT DISTINCT
    s.ID, 
    t.ID
FROM 
    #SpellTraits st
JOIN 
    Spells s ON s.[name] = st.SpellName
JOIN 
    Traits t ON t.designation = st.TraitName
WHERE 
    NOT EXISTS (
        SELECT 1 
        FROM Spells_tem_traits stt 
        WHERE stt.id_spells = s.ID AND stt.id_trait = t.ID
    );

DROP TABLE IF EXISTS #SpellTraits;

SELECT * FROM Spells_tem_traits;

-----------------------------------------------Feats_tem_traits-------------------------------------------------------------

SELECT @json_data = BulkColumn 
FROM OPENROWSET(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Feats_data.json', 
    SINGLE_CLOB
) AS datasource;

IF OBJECT_ID('tempdb..#FeatTraits') IS NOT NULL DROP TABLE #FeatTraits;
CREATE TABLE #FeatTraits (
    FeatName VARCHAR(128),
    TraitName NVARCHAR(100)
);

INSERT INTO #FeatTraits (FeatName, TraitName)
SELECT 
    [name], 
    LTRIM(RTRIM(value)) AS TraitName
FROM 
    OPENJSON(@json_data)
    WITH (
        [name] VARCHAR(128) '$.name',
        traits NVARCHAR(400) '$.trait'
    )
CROSS APPLY STRING_SPLIT(traits, ',');

INSERT INTO Feats_tem_traits (id_feat, id_trait)
SELECT DISTINCT
    f.ID, 
    t.ID
FROM 
    #FeatTraits ft
JOIN 
    Feats f ON f.[name] = ft.FeatName
JOIN 
    Traits t ON t.designation = ft.TraitName
WHERE 
    NOT EXISTS (
        SELECT 1 
        FROM Feats_tem_traits ftt 
        WHERE ftt.id_feat = f.ID AND ftt.id_trait = t.ID
    );

DROP TABLE IF EXISTS #FeatTraits;

SELECT * FROM Feats_tem_traits;
-------------------------------------------------Spells_tem_tradition---------------------------------------------------
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Spells_data.json', SINGLE_CLOB
) AS datasource;

IF OBJECT_ID('tempdb..#SpellTraditions') IS NOT NULL DROP TABLE #SpellTraditions;
CREATE TABLE #SpellTraditions (
    SpellName VARCHAR(28),
    TraditionName NVARCHAR(100)
);

INSERT INTO #SpellTraditions (SpellName, TraditionName)
SELECT 
    [name], 
    LTRIM(RTRIM(value)) AS TraditionName
FROM 
    OPENJSON(@json_data)
    WITH (
        [name] VARCHAR(28) '$.name',
        traditions NVARCHAR(400) '$.tradition'
    )
CROSS APPLY STRING_SPLIT(traditions, ',');

INSERT INTO Spells_tem_tradition (id_spells, id_tradition)
SELECT DISTINCT
    s.ID, 
    t.ID
FROM 
    #SpellTraditions st
JOIN 
    Spells s ON s.[name] = st.SpellName
JOIN 
    Tradition t ON t.[name] = st.TraditionName
WHERE 
    NOT EXISTS (
        SELECT 1 
        FROM Spells_tem_tradition stt 
        WHERE stt.id_spells = s.ID AND stt.id_tradition = t.ID
    );

DROP TABLE IF EXISTS #SpellTraditions;


insert into Ability_scores values(10,10,10,10,10,10);
insert into [Character] values('character1', 16,1,25,14,12,9,1,0,0,0,0,0,0);
insert into Character_tem_feats values(1,7),(1,8),(1,21);
insert into Character_tem_equipment values(1,1460),(1,2847),(1,2887);
insert into Character_tem_language values(1,1),(1,17);
insert into Character_tem_language values(1,1),(1,382),(1,759);


INSERT INTO Ability_scores VALUES (12, 14, 13, 15, 11, 10);
INSERT INTO Ability_scores VALUES (13, 12, 14, 11, 16, 15);
INSERT INTO Ability_scores VALUES (14, 15, 12, 13, 10, 11);
INSERT INTO Ability_scores VALUES (10, 13, 11, 12, 15, 14);
INSERT INTO Ability_scores VALUES (11, 10, 15, 14, 12, 13);
INSERT INTO Ability_scores VALUES (15, 11, 10, 16, 13, 12);
INSERT INTO Ability_scores VALUES (10, 12, 14, 11, 13, 15);
INSERT INTO Ability_scores VALUES (13, 10, 12, 14, 15, 11);
INSERT INTO Ability_scores VALUES (12, 11, 15, 10, 14, 13);
INSERT INTO Ability_scores VALUES (11, 14, 10, 13, 12, 15);

INSERT INTO [Character] VALUES ('character2', 18, 1, 28, 16, 14, 10, 2, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character3', 17, 1, 27, 15, 13, 12, 3, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character4', 19, 1, 29, 14, 12, 11, 4, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character5', 16, 1, 25, 14, 13, 10, 5, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character6', 18, 1, 28, 15, 12, 11, 6, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character7', 17, 1, 27, 14, 10, 12, 7, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character8', 19, 1, 29, 13, 14, 10, 8, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character9', 16, 1, 25, 12, 11, 13, 9, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character10', 18, 1, 28, 14, 15, 10, 10, 0, 0, 0, 0, 0, 0);
INSERT INTO [Character] VALUES ('character11', 17, 1, 27, 15, 12, 11, 11, 0, 0, 0, 0, 0, 0);

INSERT INTO Character_tem_feats VALUES (2, 9), (2, 10), (2, 12);
INSERT INTO Character_tem_feats VALUES (3, 8), (3, 11), (3, 14);
INSERT INTO Character_tem_feats VALUES (4, 7), (4, 13), (4, 15);
INSERT INTO Character_tem_feats VALUES (5, 9), (5, 16), (5, 18);
INSERT INTO Character_tem_feats VALUES (6, 10), (6, 17), (6, 20);
INSERT INTO Character_tem_feats VALUES (7, 8), (7, 12), (7, 21);
INSERT INTO Character_tem_feats VALUES (8, 9), (8, 14), (8, 22);
INSERT INTO Character_tem_feats VALUES (9, 11), (9, 15), (9, 23);
INSERT INTO Character_tem_feats VALUES (10, 12), (10, 16), (10, 24);
INSERT INTO Character_tem_feats VALUES (11, 7), (11, 17), (11, 25);

INSERT INTO Character_tem_equipment VALUES (2, 1470), (2, 2850), (2, 2890);
INSERT INTO Character_tem_equipment VALUES (3, 1480), (3, 2860), (3, 2900);
INSERT INTO Character_tem_equipment VALUES (4, 1490), (4, 2870), (4, 2910);
INSERT INTO Character_tem_equipment VALUES (5, 1500), (5, 2880), (5, 2920);
INSERT INTO Character_tem_equipment VALUES (6, 1510), (6, 2890), (6, 2930);
INSERT INTO Character_tem_equipment VALUES (7, 1520), (7, 2900), (7, 2940);
INSERT INTO Character_tem_equipment VALUES (8, 1530), (8, 2910), (8, 2950);
INSERT INTO Character_tem_equipment VALUES (9, 1540), (9, 2920), (9, 2960);
INSERT INTO Character_tem_equipment VALUES (10, 1550), (10, 2930), (10, 2970);
INSERT INTO Character_tem_equipment VALUES (11, 1560), (11, 2940), (11, 2980);

INSERT INTO Character_tem_language VALUES (2, 2), (2, 3);
INSERT INTO Character_tem_language VALUES (3, 4), (3, 5);
INSERT INTO Character_tem_language VALUES (4, 6), (4, 7);
INSERT INTO Character_tem_language VALUES (5, 8), (5, 9);
INSERT INTO Character_tem_language VALUES (6, 10), (6, 11);
INSERT INTO Character_tem_language VALUES (7, 12), (7, 13);
INSERT INTO Character_tem_language VALUES (8, 14), (8, 15);
INSERT INTO Character_tem_language VALUES (9, 16), (9, 17);
INSERT INTO Character_tem_language VALUES (10, 1), (10, 3);
INSERT INTO Character_tem_language VALUES (11, 5), (11, 7);
INSERT INTO Character_tem_spells VALUES (2, 1200), (2, 1250), (2, 1280);
INSERT INTO Character_tem_spells VALUES (3, 1150), (3, 1190), (3, 1230);
INSERT INTO Character_tem_spells VALUES (4, 1130), (4, 1170), (4, 1210);
INSERT INTO Character_tem_spells VALUES (5, 1100), (5, 1140), (5, 1180);
INSERT INTO Character_tem_spells VALUES (6, 1050), (6, 1090), (6, 1120);
INSERT INTO Character_tem_spells VALUES (7, 1010), (7, 1060), (7, 1080);
INSERT INTO Character_tem_spells VALUES (8, 1000), (8, 1030), (8, 1070);
INSERT INTO Character_tem_spells VALUES (9, 900), (9, 950), (9, 980);
INSERT INTO Character_tem_spells VALUES (10, 850), (10, 890), (10, 920);
INSERT INTO Character_tem_spells VALUES (11, 800), (11, 830), (11, 870);





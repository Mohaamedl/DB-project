-- Assuming @json_data is populated with the Feats JSON content
DECLARE @json_data NVARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET(
    BULK 'C:\Users\joaog\Documents\GitHub\DB-project\json\Feats_data.json', 
    SINGLE_CLOB
) AS datasource;

-- Assuming @json_data has been declared and populated earlier in the script

-- Temporary table to hold feat names and their split traits
IF OBJECT_ID('tempdb..#FeatTraits') IS NOT NULL DROP TABLE #FeatTraits;
CREATE TABLE #FeatTraits (
    FeatName VARCHAR(128),
    TraitName NVARCHAR(100)
);

-- Populate the temporary table with feat names and their traits
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

-- Insert into Feats_tem_traits with a check to prevent duplicates
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

-- Clean up temporary table
DROP TABLE IF EXISTS #FeatTraits;

-- Verification of inserted data
SELECT * FROM Feats_tem_traits;

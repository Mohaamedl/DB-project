-- Assuming @json_data is already populated with the JSON content
DECLARE @json_data NVARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\joaog\Documents\GitHub\DB-project\json\Spells_data.json', SINGLE_CLOB
) AS datasource;

-- Temporary table to hold spell names and their split traits
IF OBJECT_ID('tempdb..#SpellTraits') IS NOT NULL DROP TABLE #SpellTraits;
CREATE TABLE #SpellTraits (
    SpellName VARCHAR(28),
    TraitName NVARCHAR(100)
);

-- Clean the data for a safer join and check
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

-- Insert into Spells_tem_traits with a check to prevent duplicates
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

-- Clean up temporary table
DROP TABLE IF EXISTS #SpellTraits;

-- Verification of inserted data
SELECT * FROM Spells_tem_traits;

-- Assuming @json_data is already populated with the Spells JSON content
DECLARE @json_data NVARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\joaog\Documents\GitHub\DB-project\json\Spells_data.json', SINGLE_CLOB
) AS datasource;

-- Temporary table to hold spell names and their traditions
IF OBJECT_ID('tempdb..#SpellTraditions') IS NOT NULL DROP TABLE #SpellTraditions;
CREATE TABLE #SpellTraditions (
    SpellName VARCHAR(28),
    TraditionName NVARCHAR(100)
);

-- Populate the temporary table with spell names and their traditions
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

-- Insert into Spells_tem_tradition with a check to prevent duplicates
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

-- Clean up temporary table
DROP TABLE IF EXISTS #SpellTraditions;

-- Verification of inserted data
SELECT * FROM Spells_tem_tradition;

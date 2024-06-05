-- Declare the JSON data variable at the start of the script
DECLARE @json_data NVARCHAR(MAX);

-- Load JSON data into the variable from a file
SELECT @json_data = BulkColumn 
FROM OPENROWSET(
    BULK 'C:\Users\joaog\Documents\GitHub\DB-project\json\Equipment_data.json', 
    SINGLE_CLOB) AS datasource;

-- Temporary table for Equipment and their Traits
IF OBJECT_ID('tempdb..#EquipmentTraits') IS NOT NULL DROP TABLE #EquipmentTraits;
CREATE TABLE #EquipmentTraits (
    EquipmentName NVARCHAR(64),
    Traits NVARCHAR(400)
);

-- Populate the temporary table with names and traits
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

-- Temporary table for split traits with equipment IDs
IF OBJECT_ID('tempdb..#SplitTraits') IS NOT NULL DROP TABLE #SplitTraits;
CREATE TABLE #SplitTraits (
    EquipmentID INT,
    Trait NVARCHAR(100)
);

-- Insert split traits with equipment IDs
INSERT INTO #SplitTraits (EquipmentID, Trait)
SELECT 
    e.ID,
    LTRIM(RTRIM(value)) -- Trim spaces to ensure clean data matching
FROM 
    Equipment e
JOIN 
    #EquipmentTraits et ON e.[name] = et.EquipmentName
CROSS APPLY 
    STRING_SPLIT(et.Traits, ',');

-- Inserting into the Many-to-Many Relationship Table
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
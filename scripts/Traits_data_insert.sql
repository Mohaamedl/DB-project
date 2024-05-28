USE rpg;
-- Declare a variable to hold your data
DECLARE @TraitsList NVARCHAR(MAX);

-- Load the data from the file
SELECT @TraitsList = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\joaog\Documents\GitHub\DB-project\data\traits.txt',
    SINGLE_CLOB  -- Uses a single, continuous column data type
) AS j;

-- Insert data into Traits table
INSERT INTO Traits (designation)
SELECT TRIM(value) AS designation
FROM STRING_SPLIT(@TraitsList, ',');
select * from Traits

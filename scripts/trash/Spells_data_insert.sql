USE rpg;
DECLARE @json_data VARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\joaog\Documents\GitHub\DB-project\json\Spells_data.json', SINGLE_CLOB
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
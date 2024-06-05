use rpg
DECLARE @json_data VARCHAR(MAX);
SELECT @json_data = BulkColumn 
FROM OPENROWSET 
(
    BULK 'C:\Users\joaog\Documents\GitHub\DB-project\json\Feats_data.json', SINGLE_CLOB
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

USE rpg;
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
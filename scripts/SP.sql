
USE rpg
-- Criação da stored procedure
CREATE PROCEDURE GetLanguagesByAncestry
    @AncestryName VARCHAR(28)
AS
BEGIN
    SELECT l.Designation
    FROM Ancestry a
    JOIN Language_tem_ancestry la ON a.ID = la.id_ancestry
    JOIN [Language] l ON la.id_language = l.ID
    WHERE a.[name] = @AncestryName
END

GO

drop procedure GetLanguagesByAncestry
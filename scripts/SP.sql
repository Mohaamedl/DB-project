-- Set the database context
USE rpg;
GO

-- Drop existing procedures if they exist
IF OBJECT_ID('sp_GetFeats', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetFeats;
GO

IF OBJECT_ID('sp_GetSpells', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetSpells;
GO

IF OBJECT_ID('sp_GetEquipments', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetEquipments;
GO

IF OBJECT_ID('sp_GetBackgrounds', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetBackgrounds;
GO

IF OBJECT_ID('GetLanguagesByAncestry', 'P') IS NOT NULL
    DROP PROCEDURE GetLanguagesByAncestry;
GO

-- Create sp_GetFeats Procedure
CREATE PROCEDURE sp_GetFeats
    @Limit INT = 20,
    @ColumnName VARCHAR(64) = NULL,
    @SearchString VARCHAR(64) = NULL,
    @SortBy VARCHAR(64) = 'name',
    @SortOrderAscending BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Query NVARCHAR(MAX) = 'SELECT TOP (@Limit) ID, [name], rarity, prerequisite, summary, [level] FROM Feats';
    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Query += ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%''';
    SET @Query += ' ORDER BY ' + QUOTENAME(@SortBy) + ' ' + CASE WHEN @SortOrderAscending = 1 THEN 'ASC' ELSE 'DESC' END;
    EXEC sp_executesql @Query, N'@Limit INT', @Limit;
END;
GO

-- Create GetLanguagesByAncestry Procedure
CREATE PROCEDURE GetLanguagesByAncestry
    @AncestryName VARCHAR(28)
AS
BEGIN
    SELECT l.Designation
    FROM Ancestry a
    JOIN Language_tem_ancestry la ON a.ID = la.id_ancestry
    JOIN [Language] l ON la.id_language = l.ID
    WHERE a.[name] = @AncestryName;
END;
GO

-- Create sp_GetSpells Procedure
CREATE PROCEDURE sp_GetSpells
    @Limit INT = 20,
    @ColumnName VARCHAR(64) = NULL,
    @SearchString VARCHAR(64) = NULL,
    @RankFilter INT = NULL,
    @RarityFilter CHAR(28) = NULL,
    @SortBy VARCHAR(64) = 'name',
    @SortOrderAscending BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Query NVARCHAR(MAX) = 'SELECT TOP (@Limit) ID, name, rarity, actions, rank, [range] FROM Spells';
    DECLARE @Conditions NVARCHAR(MAX) = '';
    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Conditions += ' AND ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%''';
    IF @RankFilter IS NOT NULL
        SET @Conditions += ' AND rank = @RankFilter';
    IF @RarityFilter IS NOT NULL
        SET @Conditions += ' AND rarity = @RarityFilter';
    IF LEN(@Conditions) > 0
        SET @Query += ' WHERE ' + STUFF(@Conditions, 1, 5, ''); -- Removes initial ' AND '
    SET @Query += ' ORDER BY ' + QUOTENAME(@SortBy) + ' ' + CASE WHEN @SortOrderAscending = 1 THEN 'ASC' ELSE 'DESC' END;
    EXEC sp_executesql @Query, N'@Limit INT, @RankFilter INT, @RarityFilter CHAR(28)', @Limit, @RankFilter, @RarityFilter;
END;
GO

-- Create sp_GetEquipments Procedure
CREATE PROCEDURE sp_GetEquipments
    @Limit INT = 20,
    @ColumnName VARCHAR(64) = NULL,
    @SearchString VARCHAR(64) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Query NVARCHAR(MAX) = 'SELECT TOP (@Limit) ID, [name], item_category, item_sub_category, weapon_category, [level], price, rarity, usage, [bulk] FROM Equipment';
    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Query += ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%''';
    SET @Query += ' ORDER BY [name]';
    EXEC sp_executesql @Query, N'@Limit INT', @Limit;
END;
GO

-- Create sp_GetBackgrounds Procedure
CREATE PROCEDURE sp_GetBackgrounds
    @Limit INT = 20,
    @ColumnName VARCHAR(64) = NULL,
    @SearchString VARCHAR(64) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Query NVARCHAR(MAX) = 'SELECT TOP (@Limit) ID, [name], ability, skill, feat, rarity, summary FROM Background';
    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Query += ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%''';
    SET @Query += ' ORDER BY [name]';
    EXEC sp_executesql @Query, N'@Limit INT', @Limit;
END;
GO

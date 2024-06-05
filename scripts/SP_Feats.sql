IF OBJECT_ID('sp_GetFeats', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetFeats;
GO

CREATE PROCEDURE sp_GetFeats
    @Limit INT = 20,
    @ColumnName VARCHAR(64) = NULL,
    @SearchString VARCHAR(64) = NULL,
    @SortBy VARCHAR(64) = 'name',
    @SortOrderAscending BIT = 1
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Query NVARCHAR(MAX)
    SET @Query = 'SELECT TOP (@Limit) ID, [name], rarity, prerequisite, summary, [level] FROM Feats'

    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Query += ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%'''

    SET @Query += ' ORDER BY [name]'

    EXEC sp_executesql @Query, N'@Limit INT', @Limit
END;
GO

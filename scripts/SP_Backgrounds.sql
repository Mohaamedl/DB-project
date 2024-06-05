CREATE PROCEDURE sp_GetBackgrounds
    @Limit INT = 20,
    @ColumnName VARCHAR(64) = NULL,
    @SearchString VARCHAR(64) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Query NVARCHAR(MAX)
    SET @Query = 'SELECT TOP (@Limit) ID, [name], ability, skill, feat, rarity, summary FROM Background'

    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Query += ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%'''

    SET @Query += ' ORDER BY [name]'

    EXEC sp_executesql @Query, N'@Limit INT', @Limit
END

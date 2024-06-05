IF OBJECT_ID('sp_GetSpells', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetSpells;
GO

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

    DECLARE @Query NVARCHAR(MAX)
    SET @Query = 'SELECT TOP (@Limit) ID, name, rarity, actions, rank, [range] FROM Spells'

    DECLARE @Conditions NVARCHAR(MAX) = ''
    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Conditions += ' AND ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%'''
    IF @RankFilter IS NOT NULL
        SET @Conditions += ' AND rank = @RankFilter'
    IF @RarityFilter IS NOT NULL
        SET @Conditions += ' AND rarity = @RarityFilter'

    IF LEN(@Conditions) > 0
        SET @Query += ' WHERE ' + STUFF(@Conditions, 1, 5, '') -- Removes initial ' AND '

    DECLARE @SortOrder NVARCHAR(4) = CASE WHEN @SortOrderAscending = 1 THEN 'ASC' ELSE 'DESC' END
    SET @Query += ' ORDER BY ' + QUOTENAME(@SortBy) + ' ' + @SortOrder

    EXEC sp_executesql @Query,
                       N'@Limit INT, @RankFilter INT, @RarityFilter CHAR(28)',
                       @Limit, @RankFilter, @RarityFilter
END;
GO

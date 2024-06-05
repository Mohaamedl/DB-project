CREATE PROCEDURE sp_GetEquipments
    @Limit INT = 20,
    @ColumnName VARCHAR(64) = NULL,
    @SearchString VARCHAR(64) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Query NVARCHAR(MAX)
    SET @Query = 'SELECT TOP (@Limit) ID, [name], item_category, item_sub_category, weapon_category, [level], price, rarity, usage, [bulk] FROM Equipment'

    IF @ColumnName IS NOT NULL AND @SearchString IS NOT NULL
        SET @Query += ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + REPLACE(@SearchString, '''', '''''') + '%'''

    SET @Query += ' ORDER BY [name]'

    EXEC sp_executesql @Query, N'@Limit INT', @Limit
END

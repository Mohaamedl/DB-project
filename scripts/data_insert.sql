declare @id;
set @id = 1;

select @json_data = BulkColumn

from openrowset(
	BULK 'C:\Users\moham\Desktop\Uni\3º ano\2º semestre\DB-project\json\Ancestries_data.json', single_clob
) as dataSource


insert into Ancestry(
    [name],
    HP,
	speed ,
	size ,vision)

select [name],hp,speed,size from openjson(@json_data)
with(
	[name] varchar(28),
	hp int ,
	size	char(6),
	speed char(12),
	ability_boost	char(12),
	ability_flaw char(12),
	[language] char(12),
	vision char(12),
	rarity char(12)
	
)


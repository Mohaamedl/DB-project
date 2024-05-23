create table Character(
	ID  int unique not null,
	Dex_mo int,
	Str_mod int,
	Wid_mod int,
	Cond_mod int,
	Cha_mo int,
	Int_mod int,
	speed int not null,
	class_DC varchar(28) not null,
	[level] int,
	HP int
	primary key(ID)
)
create table Languages(
	ID int not null,
	Desig varchar(64)
	primary key(ID)
)
create table Ancestries(
	ID int not null,
	vision varchar(28),
	HP int not null,
	speed int not null,
	size char(28) not null,
	abilityScores_id int not null,
	primary key(ID)

)

create table AbilityScores(
	ID int not null,
	DEXTERITY int not null,
	STRENGTH int not null,
	CONSTITUTION  int not null,
	INTELLIGENCE int not null,
	CHARISMA int not null,
	WINDSOM int not null
	primary key(ID)
)


create table Backgrounds(
	ID int not null,
	summary varchar(512)
	primary key(ID)


)

create table attackRolls(
	ID int not null,
	proficeincy int not null,
	[type] varchar(28) not null
	primary key(ID)

)
create table Feats(
	ID int not null,
	rarity char(28) not null,
	prerequisite varchar(128),
	summary varchar(128),
	[level] int not null
	primary key(ID)
)
create table Trait(
    ID int not null,
    designation varchar(28) not null,
    details varchar(128)
	primary key(ID)



)


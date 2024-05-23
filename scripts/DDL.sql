
use rpg

drop table if exists [Character]


create table [Language](
	ID int not null,
	Desig varchar(64)
	primary key(ID)
)


create table Ability_scores(
	ID int not null,
	DEXTERITY int not null,
	STRENGTH int not null,
	CONSTITUTION  int not null,
	INTELLIGENCE int not null,
	CHARISMA int not null,
	WINDSOM int not null
	primary key(ID)
)


create table Ancestry(
	ID int not null,
	vision varchar(28),
	HP int not null,
	speed int not null,
	size char(28) not null,
	ability_scores_id int references Ability_scores(id),
	primary key(ID)

)




create table Background(
	ID int not null,
	summary varchar(512)
	primary key(ID)


)

create table attackRoll(
	ID int not null,
	proficiency int not null,
	[type] varchar(28) not null
	primary key(ID)

)
create table Feat(
	ID int not null,
	rarity char(28) not null,
	prerequisite varchar(128) null,
	summary varchar(128) null,
	[level] int not null
	primary key(ID)
)


create table Trait(
    ID int not null,
    designation varchar(28) not null,
    details varchar(128)
	primary key(ID)

)


create table Spell(
    ID int not null,
    spell_type char(28) not null,
    [name] varchar(28) not null,
    actions varchar(28) not null,
    defense varchar(28) not null,
    [target] varchar(64) null,
    rarity char(28) not null,
    [trigger] varchar(128) null,
    area varchar(64) null,
    rank int not null,
    heighten int not null,
    duration varchar(64) null,
    [range] int null
    primary key(ID)
)


create table Tradition(
    ID int not null,
    [name] char(28),
    details varchar(128),
    primary key(ID)
)


create table Equipment(
    ID int not null,
    [name] varchar(64) not null,
    item_category char(64) not null,
    item_sub_category char(64) null,
    usage char(28) null,
    [bulk] char(1) null,
    rarity char(28) not null,
    pfs int null,
    [level] int not null default 0,
    price int null
    primary key(ID)
    
)

create table Skill(
    ID int not null,
    designation varchar(28),
    details varchar(256),
    primary key(ID)
)


create table Spell_progression(
    [level] int not null,
    contrips int not null,
    n1 int null,
    n2 int null,
    n3 int null,
    n4 int null,
    n5 int null,
    n6 int null,
    n7 int null,
    n8 int null,
    n9 int null,
    n10 int null
    primary key ([level])
)

create table saving_throws(
    ID int not null,
    proficiency int not null,
    designation char(28) not null,
    [value] int not null,
    primary key (ID)
)


create table Class(
    ID int not null,
    [name] char(28) not null,
    HP int not null,
    skill_prof int,
    will_proff int,
    tradition char(28),-- deviamos ligar na tabela tradition?
    reflex_prof int not null,
    ability int not null,
    attack_prof int not null,
    defense_prof int not null,
    perception_prof int not null,
    progression_class_features varchar(128),
    progression_level int,
    spell_progression_id int references Spell_progression([level])
    primary key (ID)

)



create table [Character](
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
	HP int,
    background_id int references Background(ID),
    ability_scores_id int references Ability_scores(ID),
    class_id int references Class(ID),
	primary key(ID)
)
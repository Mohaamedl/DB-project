USE rpg;

DROP TABLE IF EXISTS Character_tem_language
DROP TABLE IF EXISTS Language_tem_ancestry
DROP TABLE IF EXISTS [Language]
DROP TABLE IF EXISTS Spells_tem_tradition
DROP TABLE IF EXISTS Feats_tem_background
DROP TABLE IF EXISTS Character_tem_attackRolls
DROP TABLE IF EXISTS Attack_rolls
DROP TABLE IF EXISTS Character_tem_equipment
DROP TABLE IF EXISTS Equipment_tem_traits
DROP TABLE IF EXISTS Equipment
DROP TABLE IF EXISTS Spells_tem_traits
DROP TABLE IF EXISTS Feats_tem_traits
DROP TABLE IF EXISTS Traits
DROP TABLE IF EXISTS Character_tem_savingThrow
DROP TABLE IF EXISTS Class_tem_savingThrow
DROP TABLE IF EXISTS Saving_throws
DROP TABLE IF EXISTS Character_tem_spells
DROP TABLE IF EXISTS Spells
DROP TABLE IF EXISTS Character_tem_feats
DROP TABLE IF EXISTS Character_tem_skills
DROP TABLE IF EXISTS Skills
DROP TABLE IF EXISTS user_tem_character
DROP TABLE IF EXISTS [Character]
DROP TABLE IF EXISTS Ancestry
DROP TABLE IF EXISTS Background
DROP TABLE IF EXISTS Class_features
DROP TABLE IF EXISTS Background
DROP TABLE IF EXISTS Class_tem_tradition
DROP TABLE IF EXISTS Class
DROP TABLE IF EXISTS Spell_progression
DROP TABLE IF EXISTS Tradition
DROP TABLE IF EXISTS Ability_scores
DROP TABLE IF EXISTS Feats
DROP TABLE IF EXISTS Users

CREATE TABLE Users ( -- preenchida
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARBINARY(32) NOT NULL, -- 32 bytes para SHA-256
    PasswordSalt VARBINARY(16) NOT NULL, -- 16 bytes para o salt
    [Role] VARCHAR(20) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE [Language] ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    Designation VARCHAR(64),
    PRIMARY KEY(ID)
);

CREATE TABLE Ability_scores (
    ID INT NOT NULL IDENTITY(1,1),
    STRENGTH INT default 10,
	DEXTERITY INT default 10,	--derivado de ancestry boost/flaw, Background e Class
    CONSTITUTION INT default 10,
    INTELLIGENCE INT default 10,
    WISDOM INT default 10,
    CHARISMA INT default 10,
    PRIMARY KEY(ID)
);

CREATE TABLE Attack_rolls (
    ID INT NOT NULL IDENTITY(1,1),
    proficiency INT NOT NULL, --derivado de class.prof_attack
    [type] VARCHAR(28) NOT NULL, --either unarmed, simple, martial, advanced.
    PRIMARY KEY(ID)
);

CREATE TABLE Feats ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    rarity CHAR(28) NOT NULL,
    prerequisite VARCHAR(128) NULL,
    summary VARCHAR(128) NULL,
	[name] VARCHAR(28) NOT NULL, 
    [level] INT NOT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Traits ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    designation VARCHAR(28) NOT NULL,
    details VARCHAR(128),
    PRIMARY KEY(ID)
);

CREATE TABLE Spells ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    spell_type CHAR(28) NOT NULL,
    [name] VARCHAR(28) NOT NULL,
    actions VARCHAR(28) NOT NULL,
    defense VARCHAR(28) NOT NULL,
    [target] VARCHAR(64) NULL,
    rarity CHAR(28) NOT NULL,
    [trigger] VARCHAR(128) NULL,
    area VARCHAR(64) NULL,
    [rank] INT NOT NULL,
    heighten VARCHAR(64),
    duration VARCHAR(64) NULL,
    [range] VARCHAR(64),
    PRIMARY KEY(ID)
);

CREATE TABLE Tradition ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    [name] CHAR(28),
    details VARCHAR(512),
    PRIMARY KEY(ID)
);

CREATE TABLE Equipment ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    [name] VARCHAR(64) NOT NULL,
    item_category CHAR(64) NOT NULL,
    item_sub_category CHAR(64) NULL,
    usage CHAR(28) NULL,
    [bulk] CHAR(1) NULL,
    rarity CHAR(28) NOT NULL,
	weapon_category varchar(28) NOT NULL,
    [level] INT NOT NULL DEFAULT 0,
    price int NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Skills ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    designation VARCHAR(28),
    details VARCHAR(256),
    PRIMARY KEY(ID)
);

CREATE TABLE Spell_progression ( -- preenchida
    [level] INT NOT NULL,
    cantrips INT NOT NULL,
    n1 INT NULL,
    n2 INT NULL,
    n3 INT NULL,
    n4 INT NULL,
    n5 INT NULL,
    n6 INT NULL,
    n7 INT NULL,
    n8 INT NULL,
    n9 INT NULL,
    n10 INT NULL,
    PRIMARY KEY ([level])
);

CREATE TABLE Saving_throws (
    ID INT NOT NULL IDENTITY(1,1),
    proficiency INT NOT NULL, --derivado de class.prof_saving_throws
    designation CHAR(28) NOT NULL,
    [value] INT NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE Ancestry ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
	[name] VARCHAR(28) NOT NULL,
    HP INT NOT NULL,
	size CHAR(14) NOT NULL,
    speed INT NOT NULL,
    ability_flaw varchar(64),
	ability_boost varchar(64),
	vision VARCHAR(28),
	rarity varchar(28),
    PRIMARY KEY(ID)
);

CREATE TABLE Background ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    [name] VARCHAR(28) NOT NULL,
    ability varchar(64) null,
    skill varchar(64) null,
    feat varchar(64) null,
    rarity varchar(28) not null,
	summary VARCHAR(512),
    PRIMARY KEY(ID)
);

CREATE TABLE Class ( -- preenchida
    ID INT NOT NULL IDENTITY(1,1),
    [name] CHAR(50) NOT NULL,
    HP INT NOT NULL,
	prof_attack	VARCHAR(512) NOT NULL,
	prof_defense VARCHAR(512) NOT NULL,
    ability VARCHAR(50) NOT NULL,
    spell_progression_id INT REFERENCES Spell_progression([level]) null
    PRIMARY KEY(ID)
);

CREATE TABLE Class_tem_tradition ( -- preenchida
    class_id INT NOT NULL,
    tradition_id INT NOT NULL,
    PRIMARY KEY (class_id, tradition_id),
    FOREIGN KEY (class_id) REFERENCES Class(ID),
    FOREIGN KEY (tradition_id) REFERENCES Tradition(ID)
);

create table Class_features( -- preenchida
	[level] int not null,
	class_id int references Class(ID),
	feature varchar(128) not null
	primary key (class_id,[level])
)

CREATE TABLE [Character] (
    ID INT UNIQUE NOT NULL IDENTITY(1,1),
    Str_mod INT NOT NULL, --derivado de ability_scores
    Dex_mod INT NOT NULL,
    Con_mod INT NOT NULL,
    Int_mod INT NOT NULL,
    Wis_mod INT NOT NULL,
    Cha_mod INT NOT NULL,
    speed INT NOT NULL, -- derivado de ancestry.speed
    class_DC VARCHAR(28) NOT NULL, -- derivado de class.prof_classDC
    [level] INT NOT NULL,
	[name] VARCHAR(28) NULL,
    HP INT NOT NULL, -- derivado de (class_HP + Con_mod) + Ancestry.HP
    background_id INT REFERENCES Background(ID),
    ability_scores_id INT REFERENCES Ability_scores(ID),
    class_id INT REFERENCES Class(ID),
	ancestry_id INT REFERENCES Ancestry(ID),
    PRIMARY KEY(ID)
);

CREATE TABLE User_tem_character( 
    id_user int references Users(ID) on delete cascade ,
    id_character int references [Character](ID)  on delete cascade,
    primary key (id_user,id_character)
)

CREATE TABLE Character_tem_attackRolls ( 
    id_character INT NOT NULL REFERENCES [Character](ID),
    id_attackRolls INT NOT NULL REFERENCES Attack_rolls(ID),
    PRIMARY KEY (id_character, id_attackRolls)
);

CREATE TABLE Character_tem_equipment ( 
    id_character INT NOT NULL REFERENCES [Character](ID)  on delete cascade,
    id_equipment INT NOT NULL REFERENCES Equipment(ID)  on delete cascade,
    PRIMARY KEY (id_character, id_equipment)
);

CREATE TABLE Character_tem_feats ( 
    id_character INT NOT NULL REFERENCES [Character](ID)  on delete cascade,
    id_feats INT NOT NULL REFERENCES Feats(ID)  on delete cascade,
    PRIMARY KEY (id_character, id_feats)
);

CREATE TABLE Character_tem_language (
    id_character INT NOT NULL REFERENCES [Character](ID)  on delete cascade,
    id_language INT NOT NULL REFERENCES [Language](ID)  on delete cascade,
    PRIMARY KEY (id_character, id_language)
);

CREATE TABLE Character_tem_savingThrow ( 
    id_character INT NOT NULL REFERENCES [Character](ID)  on delete cascade,
    id_savingThrow INT NOT NULL REFERENCES Saving_throws(ID)  on delete cascade,
    PRIMARY KEY (id_character, id_savingThrow)
);

CREATE TABLE Character_tem_skills ( 
    id_character INT NOT NULL REFERENCES [Character](ID)  on delete cascade,
    id_skills INT NOT NULL REFERENCES Skills(ID)  on delete cascade,
    PRIMARY KEY (id_character, id_skills)
);

CREATE TABLE Character_tem_spells ( 
    id_character INT NOT NULL REFERENCES Character(ID)  on delete cascade,
    id_spells INT NOT NULL REFERENCES Spells(ID) on delete cascade,
    PRIMARY KEY (id_character, id_spells)
);

CREATE TABLE Class_tem_savingThrow (
    id_class INT NOT NULL REFERENCES Class(ID)  on delete cascade,
    id_savingThrow INT NOT NULL REFERENCES Saving_Throws(ID)  on delete cascade,
    PRIMARY KEY (id_class, id_savingThrow)
);

CREATE TABLE Equipment_tem_traits ( -- preenchida
    id_equipment INT NOT NULL REFERENCES Equipment(ID)  on delete cascade,
    id_trait INT NOT NULL REFERENCES Traits(ID)  on delete cascade,
    PRIMARY KEY (id_equipment, id_trait)
);

CREATE TABLE Feats_tem_background ( -- preenchida
    id_feat INT NOT NULL REFERENCES Feats(ID)  on delete cascade,
    id_background INT NOT NULL REFERENCES Background(ID)  on delete cascade,
    PRIMARY KEY (id_feat, id_background)
);

CREATE TABLE Feats_tem_traits ( -- preenchida
    id_feat INT NOT NULL REFERENCES Feats(ID)  on delete cascade,
    id_trait INT NOT NULL REFERENCES Traits(ID)  on delete cascade,
    PRIMARY KEY (id_feat, id_trait)
);

CREATE TABLE Language_tem_ancestry ( -- preenchida
    id_language INT NOT NULL REFERENCES [Language](ID) on delete cascade,
    id_ancestry INT NOT NULL REFERENCES Ancestry(ID) on delete cascade,
    PRIMARY KEY (id_language, id_ancestry)
);

CREATE TABLE Spells_tem_traits ( -- preenchida
    id_spells INT NOT NULL REFERENCES Spells(ID)  on delete cascade,
    id_trait INT NOT NULL REFERENCES Traits(ID)  on delete cascade,
    PRIMARY KEY (id_spells, id_trait)
);

CREATE TABLE Spells_tem_tradition ( -- preenchida
    id_spells INT NOT NULL REFERENCES Spells(ID)  on delete cascade,
    id_tradition INT NOT NULL REFERENCES Tradition(ID)  on delete cascade,
    PRIMARY KEY (id_spells, id_tradition)
);

-- Indexes for the Spells table
CREATE INDEX idx_spells_name ON Spells ([name]);
CREATE INDEX idx_spells_rarity ON Spells (rarity);
CREATE INDEX idx_spells_rank ON Spells ([rank]);

-- Index for the name attribute in the Equipment table
CREATE INDEX idx_equipment_name ON Equipment ([name]);

-- Index for the name attribute in the Feats table
CREATE INDEX idx_feats_name ON Feats ([name]);


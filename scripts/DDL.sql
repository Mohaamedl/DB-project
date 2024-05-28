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
DROP TABLE IF EXISTS Feats
DROP TABLE IF EXISTS Character_tem_skills
DROP TABLE IF EXISTS Skills
DROP TABLE IF EXISTS [Character];
DROP TABLE IF EXISTS Ancestry
DROP TABLE IF EXISTS Background
DROP TABLE IF EXISTS Class
DROP TABLE IF EXISTS Spell_progression
DROP TABLE IF EXISTS Tradition
DROP TABLE IF EXISTS Ability_scores


CREATE TABLE [Language] (
    ID INT NOT NULL,
    Designation VARCHAR(64),
    PRIMARY KEY(ID)
);

CREATE TABLE Ability_scores (
    ID INT NOT NULL,
    STRENGTH INT default 10,
	DEXTERITY INT default 10,	--derivado de ancestry boost/flaw, Background e Class
    CONSTITUTION INT default 10,
    INTELLIGENCE INT default 10,
    WISDOM INT default 10,
    CHARISMA INT default 10,
    PRIMARY KEY(ID)
);

CREATE TABLE Attack_rolls (
    ID INT NOT NULL,
    proficiency INT NOT NULL, --derivado de class.prof_attack
    [type] VARCHAR(28) NOT NULL, --either unarmed, simple, martial, advanced.
    PRIMARY KEY(ID)
);

CREATE TABLE Feats (
    ID INT NOT NULL,
    rarity CHAR(28) NOT NULL,
    prerequisite VARCHAR(128) NULL,
    summary VARCHAR(128) NULL,
	[name] VARCHAR(28) NOT NULL, 
    [level] INT NOT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Traits (
    ID INT NOT NULL,
    designation VARCHAR(28) NOT NULL,
    details VARCHAR(128),
    PRIMARY KEY(ID)
);

CREATE TABLE Spells (
    ID INT NOT NULL,
    spell_type CHAR(28) NOT NULL,
    [name] VARCHAR(28) NOT NULL,
    actions VARCHAR(28) NOT NULL,
    defense VARCHAR(28) NOT NULL,
    [target] VARCHAR(64) NULL,
    rarity CHAR(28) NOT NULL,
    [trigger] VARCHAR(128) NULL,
    area VARCHAR(64) NULL,
    [rank] INT NOT NULL,
    heighten INT NOT NULL,
    duration VARCHAR(64) NULL,
    [range] INT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Tradition (
    ID INT NOT NULL,
    [name] CHAR(28),
    details VARCHAR(128),
    PRIMARY KEY(ID)
);

CREATE TABLE Equipment (
    ID INT NOT NULL,
    [name] VARCHAR(64) NOT NULL,
    item_category CHAR(64) NOT NULL,
    item_sub_category CHAR(64) NULL,
    usage CHAR(28) NULL,
    [bulk] CHAR(1) NULL,
    rarity CHAR(28) NOT NULL,
	weapon_category varchar(28) NOT NULL,
    [level] INT NOT NULL DEFAULT 0,
    price INT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Skills (
    ID INT NOT NULL,
    designation VARCHAR(28),
    details VARCHAR(256),
    PRIMARY KEY(ID)
);

CREATE TABLE Spell_progression (
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
    ID INT NOT NULL,
    proficiency INT NOT NULL, --derivado de class.prof_saving_throws
    designation CHAR(28) NOT NULL,
    [value] INT NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE Ancestry (
    ID INT NOT NULL,
    vision VARCHAR(28),
    HP INT NOT NULL,
    speed INT NOT NULL,
    size CHAR(14) NOT NULL,
	[name] VARCHAR(28) NOT NULL,
    ability_scores_flaw_id INT REFERENCES Ability_scores(ID),
	ability_scores_boost_id INT REFERENCES Ability_scores(ID),
    PRIMARY KEY(ID)
);


CREATE TABLE Background (
    ID INT NOT NULL,
    summary VARCHAR(512),
	[name] VARCHAR(28) NOT NULL,
	ID_ability_scores INT REFERENCES Ability_scores(ID),
    PRIMARY KEY(ID)
);

CREATE TABLE Class (
    ID INT NOT NULL,
    [name] CHAR(28) NOT NULL,
    HP INT NOT NULL,
	prof_attack	VARCHAR(128) NOT NULL,
	prof_saving_throws VARCHAR(64) NOT NULL,
	prof_perception VARCHAR(32) NOT NULL,
	prof_defense VARCHAR(128) NOT NULL,
	prof_classDC VARCHAR(32) NOT NULL,
    tradition_id INT REFERENCES Tradition(ID),
    ability VARCHAR(28) NOT NULL,
	progression_class_features VARCHAR(128) NOT NULL,
    progression_level INT,
    spell_progression_id INT REFERENCES Spell_progression([level]),
    PRIMARY KEY(ID)
);

CREATE TABLE [Character] (
    ID INT UNIQUE NOT NULL,
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

CREATE TABLE Character_tem_attackRolls (
    id_character INT NOT NULL REFERENCES [Character](ID),
    id_attackRolls INT NOT NULL REFERENCES Attack_rolls(ID),
    PRIMARY KEY (id_character, id_attackRolls)
);

CREATE TABLE Character_tem_equipment (
    id_character INT NOT NULL REFERENCES [Character](ID),
    id_equipment INT NOT NULL REFERENCES Equipment(ID),
    PRIMARY KEY (id_character, id_equipment)
);

CREATE TABLE Character_tem_feats (
    id_character INT NOT NULL REFERENCES [Character](ID),
    id_feats INT NOT NULL REFERENCES Feats(ID),
    PRIMARY KEY (id_character, id_feats)
);

CREATE TABLE Character_tem_savingThrow (
    id_character INT NOT NULL REFERENCES [Character](ID),
    id_savingThrow INT NOT NULL REFERENCES Saving_throws(ID),
    PRIMARY KEY (id_character, id_savingThrow)
);

CREATE TABLE Character_tem_skills (
    id_character INT NOT NULL REFERENCES [Character](ID),
    id_skills INT NOT NULL REFERENCES Skills(ID),
    PRIMARY KEY (id_character, id_skills)
);

CREATE TABLE Character_tem_spells (
    id_character INT NOT NULL REFERENCES Character(ID),
    id_spells INT NOT NULL REFERENCES Spells(ID),
    PRIMARY KEY (id_character, id_spells)
);

CREATE TABLE Class_tem_savingThrow (
    id_class INT NOT NULL REFERENCES Class(ID),
    id_savingThrow INT NOT NULL REFERENCES Saving_Throws(ID),
    PRIMARY KEY (id_class, id_savingThrow)
);

CREATE TABLE Equipment_tem_traits (
    id_equipment INT NOT NULL REFERENCES Equipment(ID),
    id_trait INT NOT NULL REFERENCES Traits(ID),
    PRIMARY KEY (id_equipment, id_trait)
);

CREATE TABLE Feats_tem_background (
    id_feat INT NOT NULL REFERENCES Feats(ID),
    id_background INT NOT NULL REFERENCES Background(ID),
    PRIMARY KEY (id_feat, id_background)
);

CREATE TABLE Feats_tem_traits (
    id_feat INT NOT NULL REFERENCES Feats(ID),
    id_trait INT NOT NULL REFERENCES Traits(ID),
    PRIMARY KEY (id_feat, id_trait)
);

CREATE TABLE Spells_tem_traits (
    id_spells INT NOT NULL REFERENCES Spells(ID),
    id_trait INT NOT NULL REFERENCES Traits(ID),
    PRIMARY KEY (id_spells, id_trait)
);

CREATE TABLE Spells_tem_tradition (
    id_spells INT NOT NULL REFERENCES Spells(ID),
    id_tradition INT NOT NULL REFERENCES Tradition(ID),
    PRIMARY KEY (id_spells, id_tradition)
);

CREATE TABLE Character_tem_language (
    id_character INT NOT NULL REFERENCES [Character](ID),
    id_language INT NOT NULL REFERENCES [Language](ID),
    PRIMARY KEY (id_character, id_language)
);

CREATE TABLE Language_tem_ancestry (
    id_language INT NOT NULL REFERENCES [Language](ID),
    id_ancestry INT NOT NULL REFERENCES Ancestry(ID),
    PRIMARY KEY (id_language, id_ancestry)
);
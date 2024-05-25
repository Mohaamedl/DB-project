USE rpg;

DROP TABLE IF EXISTS [Character];

CREATE TABLE [Language] (
    ID INT NOT NULL,
    Designation VARCHAR(64),
    PRIMARY KEY(ID)
);

CREATE TABLE Ability_scores (
    ID INT NOT NULL,
    DEXTERITY INT NOT NULL,
    STRENGTH INT NOT NULL,
    CONSTITUTION INT NOT NULL,
    INTELLIGENCE INT NOT NULL,
    CHARISMA INT NOT NULL,
    WISDOM INT NOT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Ancestry (
    ID INT NOT NULL,
    vision VARCHAR(28),
    HP INT NOT NULL,
    speed INT NOT NULL,
    size CHAR(28) NOT NULL,
	[name] VARCHAR(28) NOT NULL,
    ability_scores_flaw_id INT REFERENCES Ability_scores(ID),
	ability_scores_boost_id INT REFERENCES Ability_scores(ID),
    PRIMARY KEY(ID)
);

CREATE TABLE Background (
    ID INT NOT NULL,
    summary VARCHAR(512),
	[name] VARCHAR(28) NOT NULL, 
    PRIMARY KEY(ID)
);

CREATE TABLE Attack_rolls (
    ID INT NOT NULL,
    proficiency INT NOT NULL,
    [type] VARCHAR(28) NOT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Feat (
    ID INT NOT NULL,
    rarity CHAR(28) NOT NULL,
    prerequisite VARCHAR(128) NULL,
    summary VARCHAR(128) NULL,
	[name] VARCHAR(28) NOT NULL, 
    [level] INT NOT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Trait (
    ID INT NOT NULL,
    designation VARCHAR(28) NOT NULL,
    details VARCHAR(128),
    PRIMARY KEY(ID)
);

CREATE TABLE Spell (
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
    [level] INT NOT NULL DEFAULT 0,
    price INT NULL,
    PRIMARY KEY(ID)
);

CREATE TABLE Skill (
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
    proficiency INT NOT NULL,
    designation CHAR(28) NOT NULL,
    [value] INT NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE Class (
    ID INT NOT NULL,
    [name] CHAR(28) NOT NULL,
    HP INT NOT NULL,
    skill_prof INT,
    will_prof INT,
    ID_tradition INT REFERENCES Tradition(ID),
    reflex_prof INT NOT NULL,
    ability VARCHAR(28) NOT NULL,
    attack_prof INT NOT NULL,
    defense_prof INT NOT NULL,
    perception_prof INT NOT NULL,
    progression_class_features VARCHAR(128),
    progression_level INT,
    spell_progression_id INT REFERENCES Spell_progression([level]),
    PRIMARY KEY(ID)
);

CREATE TABLE [Character] (
    ID INT UNIQUE NOT NULL,
    Dex_mod INT,
    Str_mod INT,
    Wis_mod INT,
    Con_mod INT,
    Cha_mod INT,
    Int_mod INT,
    speed INT NOT NULL,
    class_DC VARCHAR(28) NOT NULL,
    [level] INT,
    HP INT,
    background_id INT REFERENCES Background(ID),
    ability_scores_id INT REFERENCES Ability_scores(ID),
    class_id INT REFERENCES Class(ID),
    PRIMARY KEY(ID)
);

CREATE TABLE Background_tem_abilityScores (
    id_background INT NOT NULL,
    id_abilityScores INT NOT NULL,
    PRIMARY KEY (id_background, id_abilityScores)
);

CREATE TABLE Character_tem_attackRolls (
    id_character INT NOT NULL,
    id_attackRolls INT NOT NULL,
    PRIMARY KEY (id_character, id_attackRolls)
);

CREATE TABLE Character_tem_Equipment (
    id_character INT NOT NULL,
    id_equipment INT NOT NULL,
    PRIMARY KEY (id_character, id_equipment)
);

CREATE TABLE Character_tem_feats (
    id_character INT NOT NULL,
    id_feats INT NOT NULL,
    PRIMARY KEY (id_character, id_feats)
);

CREATE TABLE Character_tem_language (
    id_character INT NOT NULL,
    id_language INT NOT NULL,
    PRIMARY KEY (id_character, id_language)
);

CREATE TABLE Character_tem_savingThrow (
    id_character INT NOT NULL,
    id_savingThrow INT NOT NULL,
    PRIMARY KEY (id_character, id_savingThrow)
);

CREATE TABLE Character_tem_skills (
    id_character INT NOT NULL,
    id_skills INT NOT NULL,
    PRIMARY KEY (id_character, id_skills)
);

CREATE TABLE Character_tem_spells (
    id_character INT NOT NULL,
    id_spells INT NOT NULL,
    PRIMARY KEY (id_character, id_spells)
);

CREATE TABLE Class_tem_savingThrow (
    id_class INT NOT NULL,
    id_savingThrow INT NOT NULL,
    PRIMARY KEY (id_class, id_savingThrow)
);

CREATE TABLE Class_tem_tradition (
    id_class INT NOT NULL,
    id_tradition INT NOT NULL,
    PRIMARY KEY (id_class, id_tradition)
);

CREATE TABLE Equipment_tem_trait (
    id_equipment INT NOT NULL,
    id_trait INT NOT NULL,
    PRIMARY KEY (id_equipment, id_trait)
);

CREATE TABLE Feat_tem_background (
    id_feat INT NOT NULL,
    id_background INT NOT NULL,
    PRIMARY KEY (id_feat, id_background)
);

CREATE TABLE Feat_tem_trait (
    id_feat INT NOT NULL,
    id_trait INT NOT NULL,
    PRIMARY KEY (id_feat, id_trait)
);

CREATE TABLE Language_tem_ancestry (
    id_language INT NOT NULL,
    id_ancestry INT NOT NULL,
    PRIMARY KEY (id_language, id_ancestry)
);

CREATE TABLE Skills_tem_background (
    id_skills INT NOT NULL,
    id_background INT NOT NULL,
    PRIMARY KEY (id_skills, id_background)
);

CREATE TABLE Skills_tem_class (
    id_skills INT NOT NULL,
    id_class INT NOT NULL,
    PRIMARY KEY (id_skills, id_class)
);

CREATE TABLE Skill_tem_tradition (
    id_skill INT NOT NULL,
    id_tradition INT NOT NULL,
    PRIMARY KEY (id_skill, id_tradition)
);

CREATE TABLE Spells_tem_trait (
    id_spells INT NOT NULL,
    id_trait INT NOT NULL,
    PRIMARY KEY (id_spells, id_trait)
);

CREATE TABLE Spells_tem_tradition (
    id_spells INT NOT NULL,
    id_tradition INT NOT NULL,
    PRIMARY KEY (id_spells, id_tradition)
);
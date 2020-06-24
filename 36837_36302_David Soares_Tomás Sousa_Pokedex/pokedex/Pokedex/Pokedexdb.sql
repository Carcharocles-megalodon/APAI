CREATE TABLE IF NOT EXISTS Pokemon(
	id INTEGER  PRIMARY KEY AUTOINCREMENT,
	nome varchar(50),
	type varchar(50) NOTNULL,
	type2 varchar(50)
	);
CREATE TABLE IF NOT EXISTS Stats(
	pokemon_id INTEGER,
	hp INTEGER,
	speed INTEGER,
	defense INTEGER,
	attack INTEGER,
	spDefense INTEGER,
	spAttack INTEGER,
	totalStats integer,
	FOREIGN KEY (pokemon_id) REFERENCES Pokemon(id)
	);
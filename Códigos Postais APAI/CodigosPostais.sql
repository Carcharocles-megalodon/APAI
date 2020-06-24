CREATE TABLE distritos(
cod_distrito INTEGER PRIMARY KEY,
nome_distrito VARCHAR(255) NOT NULL
);

CREATE TABLE concelhos(
cod_distrito INTEGER NOT NULL,
cod_concelho INTEGER PRIMARY KEY NOT NULL,
nome_concelho VARCHAR(255),
FOREIGN KEY (cod_distrito) REFERENCES distritos(cod_distrito)
);

CREATE TABLE codigos_postais(
cod_distrito INTEGER NOT NULL,
cod_concelho INTEGER NOT NULL,
cod_localidade INTEGER NOT NULL,
nome_localidade VARCHAR(255),
cod_arteria INTEGER NOT NULL,
tipo_arteria VARCHAR(255),
prep1 VARCHAR(255),
titulo_arteria VARCHAR(255),
prep2 VARCHAR(255),
nome_arteria VARCHAR(255),
local_arteria VARCHAR(255),
troco VARCHAR(255),
porta VARCHAR(255),
cliente VARCHAR(255),
num_codigo_postal INTEGER NOT NULL,
ext_codigo_postal INTEGER NOT NULL,
desig_postal VARCHAR(255) NOT NULL,
FOREIGN KEY (cod_distrito) REFERENCES distritos(cod_distrito),
FOREIGN KEY (cod_concelho) REFERENCES concelhos(cod_concelho)
);




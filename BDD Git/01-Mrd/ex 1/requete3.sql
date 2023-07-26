CREATE TABLE VEHICULES(
   immatriculation CHAR(7),
   Marque VARCHAR(50) NOT NULL,
   kilometrage SMALLINT NOT NULL,
   Date_mise_en_service DATETIME NOT NULL,
   id_personne SMALLINT UNSIGNED NOT NULL,
   PRIMARY KEY(immatriculation),
   FOREIGN KEY(id_personne) REFERENCES personnes(id_personne)
);

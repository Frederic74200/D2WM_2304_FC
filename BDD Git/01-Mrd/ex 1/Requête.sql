
CREATE TABLE etudiant 
(
id_etudiant SMALLINT NOT NULL AUTO_INCREMENT,
nom VARCHAR(50) NOT NULL,
prenom VARCHAR(NOT NULL,
date_entree DATETIME NOT NULL,

PRIMARY KEY (id_etudiant)
);

CREATE TABLE matiere 
(
id_matiere SMALLINT NOT NULL AUTO_INCREMENT,
lib_matiere VARCHAR(50) NOT NULL,
coef TINYINT NOT NULL,  

PRIMARY KEY (id_matiere)
);

CREATE TABLE contole
(
id_etudiant SMALLINT NOT NULL  ,
id_matiere SMALLINT NOT NULL   ,
moyenne DECIMAL(4,2) NOT NULL, 

PRIMARY KEY (id_etudiant, id_matiere), 

FOREIGN KEY (id_etudiant) REFERENCES etudiant(id_etudiant),
FOREIGN KEY (id_matiere) REFERENCES matiere(id_matiere)
);
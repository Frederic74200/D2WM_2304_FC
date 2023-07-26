CREATE TABLE contoleBis
(
id_etudiant SMALLINT NOT NULL  ,
id_matiere SMALLINT NOT NULL   ,
moyenne DECIMAL(4,2) NOT NULL, 
Ddate_controle DATETIME NOT NULL PRIMARY KEY ,



FOREIGN KEY (id_etudiant) REFERENCES etudiant(id_etudiant),
FOREIGN KEY (id_matiere) REFERENCES matiere(id_matiere)
);
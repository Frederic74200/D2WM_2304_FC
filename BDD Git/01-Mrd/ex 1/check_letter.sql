CREATE TABLE rayons
(
nomR VARCHAR((15) NOT NULL UNIQUE,
etage TINYINT NOT NULL, CHECK (etage BETWEEN 0 AND 3), 

PRIMARY KEY (nomR)
);

CREATE TABLE fournisseurs 
(
codeF INT AUTO_INCREMENT NOT NULL UNIQUE,
nomf VARCHAR(50) NOT NULL,
adressef TEXT, 

PRIMARY KEY (codeF)
);

CREATE TABLE articles 
(
codeA INT AUTO_INCREMENT NOT NULL UNIQUE,
nomA VARCHAR(255) NOT NULL,
typeA VARCHAR(3) NOT NULL, 
nomR VARCHAR((15) NOT NULL,

PRIMARY KEY (codeA),

FOREIGN KEY (nomR) REFERENCES rayons(nomR)
);


CREATE TABLE livraisons 
(
codeF INT  NOT NULL ,
codeA INT  NOT NULL ,
quantite INT NOT NULL,

PRIMARY KEY (codef, codeA),

FOREIGN KEY codeF REFERENCES fournisseurs(codeF),
FOREIGN KEY codeA REFERENCES articles(codeA)
); 

CREATE TABLE employes 
(
codeE INT AUTO_INCREMENT NOT NULL UNIQUE,
nomE VARCHAR(50) NOT NULL,
salaire DECIMAL(7,2) NOT NULL,
code_encadrant INT, 
nomR VARCHAR((15) NOT NULL , 

PRIMARY KEY (codeE),
FOREIGN KEY (nomR) REFERENCES rayons(nomR),
FOREIGN KEY (code_encadrant) REFERENCES employes(codeE)
);

 
 /* CREATE INDEX `index_nom` ON `table` (`colonne1`); */
 
CREATE INDEX nomemp_ind ON employes(nomE);
CREATE INDEX typeA_ind ON articles(typeA);



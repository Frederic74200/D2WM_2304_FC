DROP DATABASE voyages;
CREATE DATABASE if NOT EXISTS  voyages ; 
USE voyages; 

CREATE TABLE if not EXISTS  circuits 
(
nocircuit INT AUTO_INCREMENT NOT NULL UNIQUE,
destionation VARCHAR(30) NOT NULL,
duree DECIMAL(3,1) NOT NULL, 
PRIMARY KEY (nocircuit)
);

CREATE TABLE if NOT EXISTS voyages 
(
novoyage INT AUTO_INCREMENT NOT NULL UNIQUE,
datev DATE NOT NULL,
prix DECIMAL(6,2) NOT NULL ,
nbplacesmax INT NOT NULL,
PRIMARY KEY (novoyage)
);

CREATE TABLE if NOT EXISTS clients 
(
noclient INT AUTO_INCREMENT NOT NULL UNIQUE,
nom varchar(50) NOT NULL,
prenom VARCHAR(50) NOT NULL,
adresse TEXT NOT NULL,
tel CHAR(10), CHECK (tel REGEXP'^[0-9]{10}$'),
codepostal CHAR(5), CHECK (codepostal  REGEXP'^[0-9]{5}$'),
PRIMARY KEY (noclient)
); 

CREATE TABLE if NOT EXISTS inscriptions
(
noclient INT NOT NULL,
novoyage INT NOT NULL,
date_iscr DATE NOT NULL DEFAULT (NOW()), 
PRIMARY KEY (noclient, novoyage),
FOREIGN KEY (noclient) REFERENCES clients(noclient),
FOREIGN KEY (novoyage) REFERENCES voyages(novoyage)
);

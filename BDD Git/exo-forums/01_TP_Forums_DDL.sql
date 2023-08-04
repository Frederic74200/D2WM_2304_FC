CREATE TABLE roles(
   role_id INT AUTO_INCREMENT,
   role_nom VARCHAR(20) NOT NULL,
   PRIMARY KEY(role_id),
   UNIQUE(role_nom)
);

CREATE TABLE membres(
   membre_id INT AUTO_INCREMENT,
   membre_pseudo VARCHAR(120),
   membre_motdepasse CHAR(96) NOT NULL,
   membre_email VARCHAR(50) NOT NULL,
   membre_date_inscription DATETIME NOT NULL,
   membre_banni TINYINT NOT NULL,
   membre_date_de_naissance DATE NOT NULL,
   role_id INT NOT NULL,
   PRIMARY KEY(membre_id),
   UNIQUE(membre_pseudo),
   UNIQUE(membre_email),
   FOREIGN KEY(role_id) REFERENCES roles(role_id)
);

CREATE TABLE mots_cles(
   mot_id INT AUTO_INCREMENT,
   mot_cle CHAR(50) NOT NULL,
   PRIMARY KEY(mot_id),
   UNIQUE(mot_cle)
);

CREATE TABLE themes(
   theme_id INT AUTO_INCREMENT,
   theme_libelle VARCHAR(255) NOT NULL,
   PRIMARY KEY(theme_id)
);

CREATE TABLE sujets(
   sujet_id INT AUTO_INCREMENT,
   sujet_libelle VARCHAR(50) NOT NULL,
   theme_id INT NOT NULL,
   PRIMARY KEY(sujet_id),
   FOREIGN KEY(theme_id) REFERENCES themes(theme_id)
);

CREATE TABLE messages(
   message_id VARCHAR(50),
   message_contenu TEXT NOT NULL,
   message_date_depot DATETIME NOT NULL,
   message_date_publication DATETIME,
   sujet_id INT NOT NULL,
   membre_id INT NOT NULL,
   PRIMARY KEY(message_id),
   FOREIGN KEY(sujet_id) REFERENCES sujets(sujet_id),
   FOREIGN KEY(membre_id) REFERENCES membres(membre_id)
);

CREATE TABLE référer(
   sujet_id INT,
   mot_id INT,
   PRIMARY KEY(sujet_id, mot_id),
   FOREIGN KEY(sujet_id) REFERENCES sujets(sujet_id),
   FOREIGN KEY(mot_id) REFERENCES mots_cles(mot_id)
);

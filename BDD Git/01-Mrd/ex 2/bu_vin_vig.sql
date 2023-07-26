


CREATE TABLE achats
(
num_vin INT  NOT NULL ,
num_buv INT  NOT NULL ,
quantite TINYINT NOT NULL,

PRIMARY KEY (num_vin, num_buv),
FOREIGN KEY (num_buv) REFERENCES buveurs(num_buv),
FOREIGN KEY (num_vin) REFERENCES vins(num_vin)
);





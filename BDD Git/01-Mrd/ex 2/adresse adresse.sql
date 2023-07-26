SELECT nom, adresse 
FROM pilote 
WHERE adresse iN (SELECT adresse FROM pilote HAVING  COUNT(adresse) >= 2 ); 
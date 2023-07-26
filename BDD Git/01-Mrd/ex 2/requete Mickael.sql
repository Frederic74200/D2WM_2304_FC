SELECT nom, adresse 
FROM pilote 
WHERE  pil IN  (SELECT pil FROM vol WHERE av IN (SELECT av FROM avion WHERE  marque = "AIRBUS"))
HAVING  adresse IN  (SELECT localisation FROM avion WHERE marque = "AIRBUS"); 


SELECT nom, adresse
FROM pilote
JOIN vol ON pilote.pil = vol.pil 
JOIN avion ON vol.av = avion.av AND avion.marque = 'AIRBUS' 
WHERE pilote.adresse = avion.localisation;
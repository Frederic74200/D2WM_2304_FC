

SELECT DISTINCT  nom, adresse
FROM pilote
JOIN vol ON pilote.pil = vol.pil 
JOIN avion ON vol.av = avion.av AND avion.marque = 'AIRBUS' 
WHERE pilote.adresse != avion.localisation;

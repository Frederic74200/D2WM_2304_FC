SELECT avion.av, avion.loc
FROM avion 
INNER JOIN vol ON vol.av = avion.av
AND  avion.loc = vol.vd
WHERE vol.pil IN  (
SELECT pilote.pil 
FROM pilote 
INNER JOIN vol ON vol.pil = pilote.pil 
WHERE pilote.adr = vol.va
); 
SELECT distinct pilnom
FROM pilote
INNER JOIN vol ON vol.pil = pilote.pil
INNER JOIN avion ON avion.av = vol.av
WHERE avion.avtype IN (
SELECT avtype 
FROM avion 
INNER JOIN vol ON vol.av = avion.av
WHERE vol.pil =1
)
AND  pilote.pil != 1;
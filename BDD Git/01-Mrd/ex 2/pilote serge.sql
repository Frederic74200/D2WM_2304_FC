SELECT volid, vd, va 
FROM vol
WHERE vd IN  (SELECT vd FROM vol JOIN pilote ON pilote.pil = vol.pil AND nom = "SERGE")
HAVING  va IN  (SELECT va FROM vol JOIN pilote ON pilote.pil = vol.pil AND nom = "SERGE"); 

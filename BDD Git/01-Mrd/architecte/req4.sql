SELECT type_travaux.type_travaux_libelle
FROM type_travaux 
JOIN projets ON projets.type_travaux_id = type_travaux.type_travaux_id
GROUP BY type_travaux.type_travaux_libelle
HAVING MAX( projets.projet_superficie_totale)
; 
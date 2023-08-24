USE architectes;
delimiter |
CREATE PROCEDURE recherche_emp_par_fonction ( IN p_fonction_nom VARCHAR(80) )
BEGIN 
SELECT employes.emp_nom, employes.emp_prenom , employes.emp_date_embauche 
FROM employes
JOIN fonctions ON fonctions.fonction_id = employes.fonction_id
WHERE fonctions.fonction_nom = p_fonctions_nom;

END |
delimiter ;
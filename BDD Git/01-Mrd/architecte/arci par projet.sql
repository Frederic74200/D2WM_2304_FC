USE architectes; 
DELIMITER |
CREATE PROCEDURE recherche_emp_archi() BEGIN 
select employes.emp_nom, employes.emp_prenom, employes.emp_matricule
FROM employes
JOIN fonctions ON fonctions.fonction_id = employes.fonction_id WHERE  fonctions.fonction_nom = "Architecte"; 
END |
DELIMITER ;

-- 
-- DROP PROCEDURE recherche_emp_archi;

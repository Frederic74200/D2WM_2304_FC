USE architectes;
DELIMITER |
CREATE PROCEDURE liste_proj_archi( IN p_nom_archi VARCHAR(50)) 
BEGIN 
SELECT projets.projet_ref, projets.projet_date_fin_prevue, projets.projet_prix
FROM projets
JOIN employes ON employes.emp_matricule = projets.emp_matricule
WHERE employes.emp_nom = p_nom_archi; 
END |
DELIMITER ;


SET @nom_emp:="Roussotte"; 
CALL liste_proj_archi(@nom_emp); 


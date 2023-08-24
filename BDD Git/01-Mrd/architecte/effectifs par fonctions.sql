USE architectes;
DELIMITER |
CREATE PROCEDURE eff_par_fonction( IN p_nom_fonction VARCHAR(50), OUT nb_emp INT) 
BEGIN 
SELECT COUNT(employes.emp_matricule) INTO nb_emp
FROM fonctions  
JOIN employes ON employes.fonction_id = fonctions.fonction_id
WHERE fonctions.fonction_nom = p_nom_fonction ; 
END |
DELIMITER ; 


SET @nom_fonction:="Dessinateur";

call eff_par_fonction(@nom_fonction, @nb_emp) ; 
SELECT @nb_emp ; 
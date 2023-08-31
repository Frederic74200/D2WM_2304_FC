DROP PROCEDURE liste_proj_ou_fonct; 


delimiter |
CREATE PROCEDURE liste_proj_ou_fonct( in p_nom VARCHAR(50) ) 
BEGIN 
DECLARE metier VARCHAR(50) ; 

SELECT fonctions.fonction_nom INTO metier 
FROM fonctions
JOIN employes ON employes.fonction_id = fonctions.fonction_id
WHERE employes.emp_nom = p_nom; 

IF (metier = "Architecte") THEN 
SELECT * 
FROM projets 
JOIN employes ON employes.emp_matricule = projets.emp_matricule
WHERE employes.emp_nom =p_nom;

ELSE 
SELECT p_nom,  metier; 

END if; 
END |
delimiter ; 

SET @nom_emp_1:="Roussotte";
CALL liste_proj_ou_fonct(@nom_emp_1); 

SET @nom_emp_2:="Robson";
CALL liste_proj_ou_fonct(@nom_emp_2); 
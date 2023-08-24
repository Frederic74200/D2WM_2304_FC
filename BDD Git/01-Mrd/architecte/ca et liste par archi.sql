DROP PROCEDURE liste_proj_et_ca; 

USE architectes; 
delimiter |
CREATE PROCEDURE liste_proj_et_ca( IN p_nom_emp VARCHAR(50)) 
BEGIN 
SELECT employes.emp_nom, projets.projet_ref, projets.projet_date_fin_prevue, projets.projet_prix
FROM employes 
JOIN projets ON projets.emp_matricule = employes.emp_matricule
JOIN fonctions ON fonctions.fonction_id = employes.fonction_id AND fonctions.fonction_nom = "Architecte"
WHERE employes.emp_nom = p_nom_emp;  
SELECT employes.emp_nom, SUM(projets.projet_prix) AS ca_emp
FROM  employes 
JOIN projets ON projets.emp_matricule = employes.emp_matricule
JOIN fonctions ON fonctions.fonction_id = employes.fonction_id AND fonctions.fonction_nom = "Architecte"
WHERE employes.emp_nom = p_nom_emp
GROUP BY employes.emp_nom;   
END |
delimiter ; 

SET @nom_emp:="Roussotte";
CALL liste_proj_et_ca(@nom_emp); 
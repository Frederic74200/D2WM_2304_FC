DROP PROCEDURE liste_emp_par_projet; 

delimiter |
CREATE PROCEDURE liste_emp_par_projet( in p_num_proj INT) 
BEGIN
SELECT  employes.emp_matricule, employes.emp_nom, fonctions.fonction_nom
FROM employes, fonctions,  participer, projets
WHERE employes.fonction_id = fonctions.fonction_id AND participer.emp_matricule = employes.emp_matricule AND  employes.emp_matricule = projets.emp_matricule and participer.projet_ref = projets.projet_ref
and  projets.projet_ref = p_num_proj
HAVING participer.emp_matricule = employes.emp_matricule OR employes.emp_matricule = projets.emp_matricule
ORDER BY fonctions.fonction_id;
END |
delimiter ; 


SET @num_proj = 1;
CALL liste_emp_par_projet(@num_proj); 



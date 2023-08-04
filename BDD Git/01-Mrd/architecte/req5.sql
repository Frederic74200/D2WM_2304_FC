SELECT projets.projet_date_depot, projets.projet_superficie_totale, projets.projet_prix, COUNT(participer.emp_matricule) AS countemp
FROM projets 
JOIN participer ON participer.projet_ref = projets.projet_ref
GROUP BY projets.projet_ref; 

/*JOIN employes ON participer.emp_matricule AND employes.emp_matricule 
JOIN fonctions ON fonctions.fonction_id = employes.fonction_id AND fonctions.fonction_nom NOT IN ("Architecte");*/
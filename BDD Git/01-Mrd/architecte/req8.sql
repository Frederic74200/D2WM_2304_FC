SELECT DISTINCT  projets.projet_date_depot, projets.projet_date_fin_prevue, projets.projet_superficie_totale, projets.projet_prix,  clients.client_nom, employes.emp_nom
FROM projets, clients, employes, fonctions 
WHERE projets.client_ref = clients.client_ref AND projets.emp_matricule = employes.emp_matricule
AND fonctions.fonction_id = employes.fonction_id 
AND fonctions.fonction_nom = ("Architecte");


/*
JOIN clients ON clients.client_ref = projets.projet_ref
JOIN employes ON employes.emp_matricule = projets.emp_matricule
JOIN fonctions ON fonctions.fonction_id = employes.emp_date_embauche AND fonctions.fonction_nom  */
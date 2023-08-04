SELECT projets.projet_date_depot, projets.projet_prix, clients.client_nom, clients.client_telephone, adresses.adresse_ville
FROM projets
JOIN clients ON clients.client_ref = projets.client_ref
JOIN adresses ON adresses.adresse_id = clients.adresse_id; 
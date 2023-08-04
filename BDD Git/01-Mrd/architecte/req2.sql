SELECT *
FROM projets
JOIN clients ON clients.client_ref = projets.client_ref
WHERE clients.adresse_id = projets.adresse_id; 
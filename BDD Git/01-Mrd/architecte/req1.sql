SELECT clients.client_ref, clients.client_nom , type_clients.type_client_libelle
FROM clients 
JOIN type_clients ON type_clients.type_client_id = clients.type_client_id
WHERE type_clients.type_client_libelle <> "Particulier"
;












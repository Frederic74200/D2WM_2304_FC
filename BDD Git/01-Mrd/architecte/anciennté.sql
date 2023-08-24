DROP PROCEDURE anciennete_emp; 


USE architectes;
delimiter |
CREATE PROCEDURE anciennete_emp( IN p_nom_emp VARCHAR(50) , OUT p_nb_an_anc INT )
BEGIN
SELECT TIMESTAMPDIFF(YEAR, employes.emp_date_embauche,  CURDATE()) INTO p_nb_an_anc
FROM employes
WHERE employes.emp_nom = p_nom_emp ;
END |
delimiter;


SET @nom_empl:="Desplanques";
CALL anciennete_emp(@nom_empl, @p_nb_an_anc); 
SELECT @p_nb_an_anc; 

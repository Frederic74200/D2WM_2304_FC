DROP PROCEDURE cumul_prix_proj; 

delimiter |
CREATE PROCEDURE cumul_prix_proj( IN p_num_proj INT , INOUT  p_prix_proj DECIMAL(10,2))
BEGIN 
SELECT p_prix_proj + projets.projet_prix INTO p_prix_proj
FROM projets 
WHERE projets.projet_ref =  p_num_proj; 
END |
delimiter ;


SET @proj_prix = 0;

CALL cumul_prix_proj(1,  @proj_prix );
SELECT  @proj_prix  AS cumul_1 ; 

CALL cumul_prix_proj(2,  @proj_prix );
SELECT  @proj_prix  AS cumul_2 ; 

CALL cumul_prix_proj(4,  @proj_prix );
SELECT  @proj_prix  AS cumul_3 ; 


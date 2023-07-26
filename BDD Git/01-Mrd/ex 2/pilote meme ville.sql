SELECT *
FROM pilote 
WHERE adr IN (
SELECT  adr
FROM pilote 
GROUP BY adr
HAVING  COUNT(adr) > 1
);
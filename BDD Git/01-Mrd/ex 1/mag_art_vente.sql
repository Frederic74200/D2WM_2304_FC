

ALTER TABLE articles 
ADD CONSTRAINT ck_type CHECK (typeA IN ("P", "L", "D"));
ALTER TABLE personnes
MODIFY code_post CHAR(5) NOT NULL,
CHECK (code_post REGEXP_LIKE '^[0-9]{5}$');
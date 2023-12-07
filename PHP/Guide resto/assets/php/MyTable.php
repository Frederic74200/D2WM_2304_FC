<?php
require "Connexion.php";

class MyTable
{ //attributs
    private PDO $connexion;
    private string $table;
    private int $nbCol;
    private array $tabNomCol;


    public function __construct(string $_table)
    {
        $this->table = $_table;
        $this->connexion = Connexion::getinstance();
    }


    //propriétes


    public function readTable(): array
    {
        $data = array();

        // rédiger la requète mySql
        $requete = "SELECT * from " . $this->table;
        // préparer la requète
        $state = $this->connexion->prepare($requete);
        // Exécuter la requète
        $state->execute();

        // utilser la fonction de récupération des noms des champs à l'intérieur de la classe
        $this->tabNomCol = $this->getFieldsNames();


        // associer les données récupérées au tableau 
        $data = $state->fetchAll();

        // ajouter le tableau des noms de champs au début du tableau de données
        array_unshift($data, $this->tabNomCol);


        // chercher clé primaire --------------

        // rédiger la requète mySql
        $requete = "SELECT COLUMN_NAME
        FROM information_schema.columns
        WHERE table_name = ' " . $this->table . "' AND  COLUMN_KEY = 'PRI'; '";
        // préparer la requète
        $state = $this->connexion->prepare($requete);
        // Exécuter la requète
        $state->execute();

        $araayKeys = array();

        // associer les données récupérées au tableau 
        $araayKeys = $state->fetchAll();

        // ajouter le tableau des clés primaires au début du tableau de données
        array_unshift($data, $araayKeys);


        return $data;
    }

    private function getFieldsNames(): array
    {
        $fieldsNames = array();
        // déterminer le nombre de champs de la table 
        $requete = "SELECT * from " . $this->table;
        // préparer la requète
        $state = $this->connexion->prepare($requete);
        // Exécuter la requète
        $state->execute();
        $this->nbCol = $state->columnCount();
        // PPO get column meta 
        for ($i = 0; $i < $this->nbCol; $i++) {
            $resultat = $state->getColumnMeta($i);
            array_push($fieldsNames, $resultat['name']);
        }

        return $fieldsNames;
    }

    public function getFlags(): array
    {
        $flags = array();
        // déterminer le nombre de champs de la table 
        $requete = "SELECT * from " . $this->table;
        // préparer la requète
        $state = $this->connexion->prepare($requete);
        // Exécuter la requète
        $state->execute();
        $this->nbCol = $state->columnCount();
        // PPO get column meta 
        for ($i = 0; $i < $this->nbCol; $i++) {
            $resultat = $state->getColumnMeta($i);
            array_push($flags, $resultat['flags']);
        }

        return $flags;
    }

    function supprimerLigne($id)
    {
        // Connexion à la base de données
        $maConnexion = Connexion::getInstance();

        // Exécution de la requête DELETE
        $rqt = 'DELETE FROM restaurants WHERE id = :id';
        $state = $maConnexion->prepare($rqt);
        $state->bindParam(':id', $id);
        $state->execute();
    }
}

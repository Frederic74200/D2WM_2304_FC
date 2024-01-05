<?php
require './App/models/Connexion.php';
class interim
{

    private int $nbLignes = 0;


    public function __construct()
    {
    }

    public function getNumDpts(): array
    {
        $numDpts = array();
        $requete = "SELECT id_dep, Name FROM  departements;   ";

        $connect = Connexion::getInstance();
        $state = $connect->prepare($requete);
        $state->execute();
        $nbLigne = $state->rowCount();

        /*   while ($ligne = $state->fetch()) {
            array_push($numDpts, $ligne['Name']);
        }
        while ($obj = $state->fetch()) {
            // array_push($numDpts, $ligne["id_dep"]=> $ligne[]);

            $numDpts[$obj->id_dept] = $obj->Name;
        }*/

        while ($obj = $state->fetch()) {
            $numDpts[$obj->id_dep] = $obj->name;
        }

        return $numDpts;
    }


    public   function resultats(array $_input = null): array
    {

        $result = array();
        $deptInput = $_input['dept'];
        $etsInput = [];
        !empty($_input['typeEts']) ?   $etsInput = $_input['typeEts'] :  $etsInput = [];;
        $connect = Connexion::getInstance();
        $requete = "";


        if (!empty($deptInput) && !empty($etsInput)) {

            $liste = "";

            for ($i = 0; $i < count($etsInput); $i++) {

                $liste .= ", '" . $etsInput[$i] . "'";
            }


            $rest = substr($liste, 1);

            $requete = "SELECT  nom_etab, type_etab , nom_resp, adresse, cp, ville, Telephone , email FROM institutions WHERE depart = " . $deptInput . " AND type_etab IN ( " . $rest . ");";
        } else  
        
        if (!empty($deptInput)) {

            $requete = "SELECT  nom_etab, type_etab , nom_resp, adresse, cp, ville, Telephone , email FROM institutions WHERE depart = " . $deptInput . " ;";
        }


        try {
            $state = $connect->prepare($requete);
            //   $state->bindParam(" :code_inscription", $codeInscr, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }



        while ($ligne = $state->fetch()) {
            array_push($result, $ligne);
            $this->nbLignes++;
        }


        if (empty($result)) {

            $result["Choixdept"] = ["Choisissez un autre département", "", "", "", "", "", "", ""];
            $this->nbLignes = 0;
        }




        return $result;
    }


    public function getValuesEts(array $_input = null): array
    {
        $etsInput = [];
        !empty($_input['typeEts']) ?   $etsInput = $_input['typeEts'] :  $etsInput = [];;
        return $etsInput;
    }


    public function allData(): array
    {
        $result = array();

        $result["Choixdept"] = ["Choisissez un département", "", "", "", "", "", "", ""];

        return $result;
    }

    public function getNbLignes(): int
    {
        return $this->nbLignes;
    }
}

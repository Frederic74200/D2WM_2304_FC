<?php
require './App/models/Connexion.php';
class interim
{



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


    public   function resultats(array $_input): array
    {

        $result = array();

        $deptInput = $_input['dept'];
        $etsInput = $_input['typeEts'];
        $connect = Connexion::getInstance();



        $requete = " SELECT  *  FROM institutions";

        try {
            $state = $connect->prepare($requete);
            //   $state->bindParam(" :code_inscription", $codeInscr, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }



        while ($ligne = $state->fetch()) {
            array_push($result, $ligne);
        }







        return $result;
    }





    public function allData(): array
    {
        $result = array();
        $requete = " SELECT  *  FROM institutions";
        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            //   $state->bindParam(" :code_inscription", $codeInscr, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }



        while ($ligne = $state->fetch()) {
            array_push($result, $ligne);
        }

        return $result;
    }
}

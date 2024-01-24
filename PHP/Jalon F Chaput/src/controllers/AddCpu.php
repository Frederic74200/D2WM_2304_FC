<?php
// require('./src/models/Connexion.php');

namespace App\Controllers;

use App\Models\Connexion;


class AddCpu
{

    public function __construct()
    {
    }


    public function addAcpu(array $_input): int
    {
        $nb = 0;
        $fam =  $_input['famille'];
        $mod = $_input['modele'];
        $freq = $_input['frequence'];

        $requete = "INSERT INTO cpu_intel(cpu_family , cpu_model, cpu_mhz )
        VALUES ( :cpu_family  , :cpu_model ,  :cpu_mhz    );";


        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            //   $state->bindParam(":mail", $_identifiant, PDO::PARAM_STR);

            $state->bindParam(":cpu_family",  $fam, \PDO::PARAM_STR);
            $state->bindParam(":cpu_model", $mod, \PDO::PARAM_STR);
            $state->bindParam(":cpu_mhz", $freq, \PDO::PARAM_INT);

            $state->execute();
            //  $state->execute([":lastname_user" => $this->lastname_user, ":firstname_user" => $this->firstname_user, ":mail_user" => $this->mail_user, ":pass_user " => $hash_mdp, ":level_user" => $this->level_user, ":avatar" => $this->avatar]);
        } catch (\PDOException $e) {
            throw new \Exception("Erreur de connexion à la base de données add user ", 1);
        }

        $nb = $state->rowCount();

        return $nb;
    }
}

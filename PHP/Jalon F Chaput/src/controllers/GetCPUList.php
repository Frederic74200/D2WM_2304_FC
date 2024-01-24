<?php

namespace App\Controllers;

use App\Models\Connexion;

class GetCPUList
{

    public function __construct()
    {
    }


    public function getList()
    {
        $list = null;

        $requete = "SELECT * FROM cpu_intel;";

        $connect = Connexion::getInstance();
        $state = $connect->prepare($requete);
        $state->execute();

        while ($obj = $state->fetch()) {
            $list[$obj->cpu_id] = $obj;
        }




        return $list;
    }
}

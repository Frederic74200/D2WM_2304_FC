<?php

require_once('Personne.php');

use Personne;

class Client extends Personne
{
    private static int $numClient;
    private string $adresse;

    public function __construct($nom, $prenom, $age, $numClient, $adresse)
    {
        parent::__construct($nom, $prenom, $age);
        $this->numClient = $numClient;
        $this->adresse = $adresse;
    }

    public function getAdresse()
    {
        return $this->adresse;
    }
}

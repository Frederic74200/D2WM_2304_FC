<?php

require_once('Personne.php');

use Personne;

class Intervenent extends Personne
{
    private float $salaire;
    private float $autresRevenus;

    public function __construct($nom, $prenom, $age, $salaire, $autresRevenus)
    {
        parent::__construct($nom, $prenom, $age);
        $this->salaire = $salaire;
        $this->autresRevenus = $autresRevenus;
    }

    public function calculerCherges()
    {
        return $this->getAge() < 55 ? ($this->salaire * 0.2) + ($this->autresRevenus * 0.15) : ($this->salaire * 0.1) + ($this->autresRevenus * 0.075);
    }
}

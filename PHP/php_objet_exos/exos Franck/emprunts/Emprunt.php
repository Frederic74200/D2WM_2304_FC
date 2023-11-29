<?php

class Emprunt
{

    private int $capital;
    private float $taux;
    private int $duree;

    public function __construct($capital, $taux, $duree)
    {
        $this->capital = $capital;
        $this->$taux = $taux;
        $this->duree = $duree;
    }

    // petits calculs ------------------------------------------------

    private function getNombreMois(): int
    {
        return $this->duree * 12;
    }

    private function getTauxMensuell(): float
    {
        return $this->taux / 1200;
    }

    // calcul mesualité 

    public function calculerMensualité()
    {
        $mensualite = 0.00;
        $puissanceNegative = -1 * $this->getNombreMois();
        $mensualite = ($this->capital * $this->getTauxMensuell() / (pow(1 + $this->getTauxMensuell(), $puissanceNegative)));
        return   round($mensualite, 2);
    }
}

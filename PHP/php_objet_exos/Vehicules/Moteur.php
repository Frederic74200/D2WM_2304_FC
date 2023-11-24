<?php

class Moteur
{

    protected string $marqueMoteur;
    protected int $vitesseMoteurKmH;

    /**
     * construteur 
     * @param (string, int)
     */
    public function __construct(string $marqueMoteur, int $vitesseMoteurKmH)
    {
        $this->marqueMoteur = $marqueMoteur;
        $this->vitesseMoteurKmH = $vitesseMoteurKmH;
    }

    /**
     * get marque moteur
     * @return string 
     */
    public function getMarqueMoteur()
    {
        return $this->marqueMoteur;
    }

    /**
     * get vitesse moteur
     * @return int
     */
    public function getVitesseMoteur()
    {
        return $this->vitesseMoteurKmH;
    }
}

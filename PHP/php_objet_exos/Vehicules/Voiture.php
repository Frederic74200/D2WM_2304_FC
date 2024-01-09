<?php

require_once('moteur.php');

use Moteur;


class Voiture
{
    protected string $marqueVoiture;
    protected int $poidsEnKg;
    private Moteur $morteur;
    /**
     * constructeur
     * @param (string , int, string, int) 
     * @return  Voiture 
     */

    public function __construct(string $marqueVoiture, int $poidsEnKg = 1000, $morteur)
    {
        $this->marqueVoiture = $marqueVoiture;
        $this->poidsEnKg = $poidsEnKg;
        $this->morteur = $morteur;
    }

    /**
     * retoiurne la voiture enchaire de caractère 
     * @return string 
     */
    public function voitureToString(): string
    {
        return $this->marqueVoiture . " " . $this->poidsEnKg;
    }

    /**
     * get marque de la voiture 
     * @return string
     */
    public function getMarque(): string
    {
        return $this->marqueVoiture;
    }

    /**
     * get poids de la voiture 
     * @return int 
     */
    public function getPoidsVoiture(): int
    {
        return $this->poidsEnKg;
    }

    /**
     * set marque Voiture 
     * @param string 
     */
    public function setmarqueVoiture(string $marqueVoiture): void
    {
        $this->marqueVoiture = $marqueVoiture;
    }

    /**
     * set poids voitere 
     * 
     */
    public function setpoidsVoiture(int $poidsEnKg): void
    {
        $this->poidsEnKg = $poidsEnKg;
    }

    /**
     * get marque moteur
     * @return string
     */
    public function getMarqueMoteur()
    {
        return $this->morteur->getMarqueMoteur();
    }




    /**
     * calculer vitesse voiture 
     * @return int
     */
    public function calculerVitesseVoiture()
    {
        // return ($this->morteur->getVitesseMoteur() - ($this->poidsEnKg * 0.3));      round($div, 2);
        return round(($this->morteur->getVitesseMoteur() - ($this->poidsEnKg * 0.3)), 0);
    }
}

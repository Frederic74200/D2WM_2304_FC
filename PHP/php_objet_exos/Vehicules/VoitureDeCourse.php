<?php
require_once('Voiture.php');

use Voiture;

class VoitureDeCourse extends Voiture
{
    protected Moteur $moteur;

    public function __construct(string $marque, int $poids, Moteur $moteurVc)
    {
        if ($moteurVc->getMarqueMoteur() !== $marque) {
            throw new Exception("La marque du moteur doit être la même que celle de la voiture");
        }

        $this->moteur = $moteurVc;
        parent::__construct($marque, $poids, $moteurVc);
    }


    /*
    public function __construct($VoitCourse)
    {
        try {
            $VoitCourse->getMarque() === $VoitCourse->getMarqueMoteur();
            $this->$VoitCourse = $VoitCourse;
        } catch (Exception $e) {
            echo "Erreur Moteur";
        }
    }
    */

    public function voitCoursetoString()
    {
        return 'voitre OK !';
    }
}

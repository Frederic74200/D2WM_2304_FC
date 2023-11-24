<?php
require_once('Voiture.php');

use Voiture;

class VoitureDeCourse
{

    protected Voiture $VoitCourse;

    public function __construct($VoitCourse)
    {
        try {
            $VoitCourse->getMarque() === $VoitCourse->getMarqueMoteur();
            $this->$VoitCourse = $VoitCourse;
        } catch (Exception $e) {
            echo "Erreur Moteur";
        }
    }

    public function voitCoursetoString()
    {
        return $this->VoitCourse->voitureToString();
    }
}

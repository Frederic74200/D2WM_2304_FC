<?php

require('Voiture.php');
require('VoitureDeCourse.php');

use Voiture;
use VoitureDeCourse;

$bagnole = new Voiture("Peugeot", 999,  new Moteur("Solex", 50));
// $tacot = new VoitureDeCourse("teur", 1000, new Moteur('teur', 300));

$voitureDeCourse = new VoitureDeCourse("Renault", 1000, $moteur);

try {
    $voitureDeCourse = new VoitureDeCourse("Renault", 1000, new Moteur("Peugeot", 300));
} catch (Exception $e) {
    echo $e->getMessage(); // La marque du moteur doit être la même que celle de la voiture
}



echo "voiture to string " . $bagnole->voitureToString();
echo "\n vitesset voiture" . $bagnole->calculerVitesseVoiture();
echo "\n tacot to string" .   strval($voitureDeCourse);

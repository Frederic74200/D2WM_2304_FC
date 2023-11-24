<?php

require('Voiture.php');
require('VoitureDeCourse.php');

use Voiture;
use VoitureDeCourse;

$bagnole = new Voiture("Peugeot", 999,  new Moteur("Solex", 50));
$tacot = new VoitureDeCourse(new Voiture("teur", 1000, new Moteur('teur', 300)));

echo "voiture to string " . $bagnole->voitureToString();
echo "\n vitesset voiture" . $bagnole->calculerVitesseVoiture();
echo "\n tacot to string" . $tacot->voitCoursetoString();

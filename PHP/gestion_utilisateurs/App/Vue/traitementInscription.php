<?php

require 'App/Controller/SinginUsager.php';
// récupéer données inscriptions 
if (isset($_POST) && !empty($_POST)) {
    $values = array();
    $values = array_values($_POST);
    $saisieOK = false;
    do {
        $nbChampsVerif = 0;

        SinginUsager::verificationCode($values[0]) ? $nbChampsVerif++ : $nbChampsVerif--;
        SinginUsager::verificationNom($values[1]) ? $nbChampsVerif++ : $nbChampsVerif--;
        SinginUsager::verificationPrenom($values[2]) ? $nbChampsVerif++ : $nbChampsVerif--;
        SinginUsager::verificationMail($values[3]) ? $nbChampsVerif++ : $nbChampsVerif--;
        SinginUsager::verificationMDP($values[4], $values[5]) ? $nbChampsVerif++ : $nbChampsVerif--;
        SinginUsager::descriptionToString($values[6]) ? $nbChampsVerif++ : $nbChampsVerif--;

        $nbChampsVerif == 6 ? $saisieOK = true : $saisieOK = false;
    } while (!$saisieOK);

    SinginUsager::addUserDB($values);



    var_export($values);
} else {
    echo 'Veuillez remplir le formulaire ! ';
}

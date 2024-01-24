<?php

require 'vendor/autoload.php';

use App\Controllers\AddCpu;


if (!empty($_POST)) {

    $inputFam = false;
    $inputMod = false;
    $inputfreq = false;
    global $inputOk;

    do {

        $regfam = "/^[a-zA-Z0-9]{2}$/";
        $regMod = "/^[A-Z0-9]{6,7}$/";

        $inputFam = filter_input(INPUT_POST, "famille", FILTER_VALIDATE_REGEXP, array(
            "options" => array(
                "regexp" => $regfam,
            ),
        ));
        $inputMod =  filter_input(INPUT_POST, "modele", FILTER_VALIDATE_REGEXP, array(
            "options" => array(
                "regexp" => $regMod,
            ),
        ));
        $inputfreq = filter_input(INPUT_POST, 'frequence', FILTER_VALIDATE_INT);

        if ($_POST['frequence'] < 1600 || $_POST['frequence'] > 5000) {
            $inputfreq = false;
        }

        $inputOk = false;
    } while (!$inputFam && !$inputMod && !$inputfreq);
    $inputOk = true;


    $cpu = new AddCpu();

    $nb = $cpu->addAcpu($_POST);

    if ($nb != 0) {
        echo "<script>alert('Proceeseur ajouté '); window.location.href='index.php'</script>";
    } else {

        echo "<script>alert('Quelque chose s'est mal passé.'); window.location.href='index.php'</script>";
    }
} else {

    require('src/vues/homepage.php');
}

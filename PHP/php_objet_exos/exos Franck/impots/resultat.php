<?php

const TAUX_BAS = 0.09;
const TAUX_HAUT = 0.14;
const PLAFOND = 15000;


function calculImpot($revenu)
{
    $impot = 0.0;

    $revenu < PLAFOND ? $impot = $revenu * TAUX_BAS : $impot = (PLAFOND * TAUX_BAS) + (($revenu - PLAFOND) * TAUX_HAUT);
    return $impot;
}


$nom = $_POST["nom"];
$revenu = $_POST["revenu"];

$impot = calculImpot($revenu);

echo "Bonjour " . $nom . ".Votre impôt se monte à : " . $impot . " €";

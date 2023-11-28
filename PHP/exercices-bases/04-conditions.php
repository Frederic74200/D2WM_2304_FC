<?php

function isMajor(int $agePrs): bool
{
    /* if ( $agePrs < 18 ) {
        return false;
    }
    else 
    {
        return true; 
    */

    return $agePrs < 18 ? false : true;
}


function getRetired(int $age): string
{

    if ($age < 0) {
        return " Vous n\' êtes pas encore né";
    } elseif ($age < 60) {
        return "il vous reste " . 60 - $age . " jusqu\'à la retraite ";
    } elseif ($age === 60) {
        return "Vous êtes à la retraite cette année";
    } else {
        return  "Vous êtes à la retraite cette annéeous êtes à la retraite depuis " . $age - 60 . " ans.";
    }
}


function getMax(float $a, float $b, float $c): float
{

    if ($a === $b || $b === $c || $c === $a) {
        return 0.0;
    } else {
        if ($a < $b) {
            return  $b < $c ?  round($c, 3) :  round($b, 3);
        } elseif ($b < $a) {
            return  $a < $c ?  round($c, 3) :  round($a, 3);
        }
    }
}


function  capitalCity(string $input)
{

    $pays = mb_convert_case($input, MB_CASE_TITLE, "UTF-8");

    switch ($pays) {

        case 'France':
            return "Paris";
            break;

        case 'Allemagne':
            return "Berlin";
            break;

        case 'Italie':
            return "Rome";
            break;

        case 'Maroc':
            return "Rabat";
            break;

        case 'Espagne':
            return "Madrid";
            break;

        case 'Portugal':
            return "Lisbonne";
            break;

        case 'Angleterre':
            return "Londres";
            break;

        default:
            return "Capitale inconnue";
            break;
    }
}




$age1 = 12;
$age2 = 42;

echo "majeur  false : " . isMajor($age1);
echo " majeur true : " . isMajor($age2);

echo "  retraite 12 " . getRetired(12);
echo " retraite 60  " . getRetired(60);
echo " retraite 72 " . getRetired(72);
echo " retraite -2 " . getRetired(-2);

echo " getMax 0  " . getMax(5, 5, 7.56);
echo " getMax a  " . getMax(55.56548, 5, 7.56);
echo " getMax b  " . getMax(5, 5555.569875, 7.56);
echo " getMax c  " . getMax(5, 5.1, 77.56);

echo "capitalCity  France " . capitalCity("france");

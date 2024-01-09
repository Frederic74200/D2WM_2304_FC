<?php

// Constantes pour les taux d'imposition
const TAUX_IMPOT_INFERIEUR_15000 = 0.09;
const TAUX_IMPOT_SUPERIEUR_15000 = 0.14;

// Fonction de calcul de l'impôt
function calculImpot($nom, $revenu)
{
    // Vérification du revenu
    if ($revenu < 15000) {
        return $revenu * TAUX_IMPOT_INFERIEUR_15000;
    } else {
        // Calcul de la part de revenu inférieure à 15 000 euros
        $partRevenueInferieure = 15000;
        // Calcul de l'impôt sur la part de revenu inférieure à 15 000 euros
        $impotInferieure = $partRevenueInferieure * TAUX_IMPOT_INFERIEUR_15000;
        // Calcul de la part de revenu supérieure à 15 000 euros
        $partRevenueSuperieure = $revenu - $partRevenueInferieure;
        // Calcul de l'impôt sur la part de revenu supérieure à 15 000 euros
        $impotSuperieure = $partRevenueSuperieure * TAUX_IMPOT_SUPERIEUR_15000;
        // Retour du montant total de l'impôt
        return $impotInferieure + $impotSuperieure;
    }
}

// Récupération des données du formulaire
$nom = $_POST["nom"];
$revenu = $_POST["revenu"];

// Calcul de l'impôt
$impot = calculImpot($nom, $revenu);

// Affichage du résultat
echo "Mr $nom, votre impôt est de $impot euros";

<?php

namespace App\vue;

$title = "Agence Interim"; ?>

<?php ob_start();


// require 'header.php';
require './templates/header.php';
require './templates/formRecherche.php';
require './templates/h2selDrpt.php';
require './templates/footer.php';
// require 'footer.php';
?>

<?php $content = ob_get_clean(); ?>

<?php require('./templates/layout.php') ?>
<?php $title = "Inscription"; ?>

<?php ob_start();

require './Templates//header.php';
require './Templates/singin.php';


?>

<?php $content = ob_get_clean(); ?>

<?php require('./Templates/layout.php') ?>
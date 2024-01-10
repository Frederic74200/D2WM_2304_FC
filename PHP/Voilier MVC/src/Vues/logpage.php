<?php $title = "Connection"; ?>

<?php ob_start();

require './Templates//header.php';
require './Templates/loginform.php';


?>

<?php $content = ob_get_clean(); ?>

<?php require('./Templates/layout.php') ?>
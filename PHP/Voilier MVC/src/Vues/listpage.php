<?php $title = "Liste voiliers"; ?>

<?php ob_start();

require './Templates//header.php';
require './Templates/liste.php';


?>

<?php $content = ob_get_clean(); ?>

<?php require('./Templates/layout.php') ?>
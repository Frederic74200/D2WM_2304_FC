<?php $title = "Agence Interim"; ?>

<?php ob_start();
require './templates/formRecherche.php';

?>
<?php $content = ob_get_clean(); ?>

<?php require('./templates/layout.php') ?>
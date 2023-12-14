<?php $title = "les site des users"; ?>

<?php ob_start(); ?>
<h1>Le super site des Users !</h1>
<p>Derniers billets du blog :</p>



<?php $content = ob_get_clean(); ?>

<?php require('layout.php') ?>
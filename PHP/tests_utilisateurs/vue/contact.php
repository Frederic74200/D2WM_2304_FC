<?php $title = "contact"; ?>

<?php ob_start();
require './templates/header.php';
require './templates/formcontact.php';
require './templates/footer.php';

?>
<?php $content = ob_get_clean(); ?>

<?php require('./templates/layout.php') ?>
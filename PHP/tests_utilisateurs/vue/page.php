<?php $title = "test"; ?>

<?php ob_start();
require './templates/header.php';

require './templates/homepage.php';
require './templates/footer.php';

?>
<?php $content = ob_get_clean(); ?>

<?php require('./templates/layout.php') ?>
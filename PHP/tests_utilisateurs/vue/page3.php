<?php $title = "Page 3"; ?>

<?php ob_start();
require './templates/header.php';

require './templates/page3.php';
require './templates/footer.php';

?>
<?php $content = ob_get_clean(); ?>

<?php require('./templates/layout.php') ?>
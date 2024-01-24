<?php ob_start();

require('./templates/formAddProc.php');
require('./templates/tableProc.php');

?>

<?php $content = ob_get_clean(); ?>

<?php require('./templates/layout.php') ?>
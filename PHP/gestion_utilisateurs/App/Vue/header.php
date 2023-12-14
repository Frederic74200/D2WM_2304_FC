<?php ob_start(); ?>
<header>
    <p style="color: blue; font-size : 100px;">Mon super menu !</p>
</header>


<?php $header = ob_get_clean(); ?>

<?php require('layout.php') ?>
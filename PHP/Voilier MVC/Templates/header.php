<?php
@session_start();
require './src/Controllers/LogClass.php';

$userInfo = [];


if (isset($_SESSION["userdata"])) {


    $userInfo = $_SESSION["userdata"];
    var_dump($userInfo);
}


?>



<header>
    <img id="logo" src="http://localhost/gitphp/Voilier%20MVC//Assets/images/logo2.jpg" alt="">

    <h2>Locavoile</h2>


    <?php if ($userInfo != null) : ?>

        <img id="avatar" src=<? $userInfo["image_url"] ?> alt="">

        <p>Bienvenue <? $userInfo['firstname_user'] ?> <? $userInfo["lastname_user"] ?> </p>



        <form name='logoutform' action="<?php echo $_SERVER["PHP_SELF"] ?>" method="Get" enctype="multipart/form-data">

            <input type="hidden" name="logout" value="logout">
            <input type="submit" value="Déconnection" id='logoutform'>


        </form>

    <?php else : ?>

        <p>Connectez-vous pour accéder au contenu</p>

    <?php endif; ?>
</header>
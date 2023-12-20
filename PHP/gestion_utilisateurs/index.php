<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Le site des Usagers</title>
</head>

<body>
    <?php

    session_start();
    // si session valide ---------------------------------------------------
    if (isset($_SESSION["nom_utilisateur"])) {
        echo 'Bienvenue  ' . $_SESSION["nom_utilisateur"] . "  Votre fonction : " . $_SESSION["fonction"];
        require 'templates/boutonLogout.php';
        if (isset($_POST['logout'])) {
            require 'templates/formLogin.php';
            session_destroy();
            echo "<script>window.location.href='index.php'</script>";
        }
        // si pas connexion -----------------------------------------------------
    } else {
        require 'templates/accueil.php';
        // afficher bouton se connecter 
        if (isset($_POST['login'])) {

            require 'App/Vue/traitementConnexion.php';
        }
        // affcher bouton s'inscrire 
        if (isset($_POST['signin'])) {
            require 'templates/formSingin.php';
            require 'App/Vue/traitementInscription.php';
        }
    }




    ?>


    <?php
    /*
    $mdp = "admin";

    $hash_mdp =  password_hash($mdp,  PASSWORD_BCRYPT);


    echo $hash_mdp; */
    ?>







</body>

</html>
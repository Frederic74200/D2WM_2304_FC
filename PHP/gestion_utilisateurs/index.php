<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Le site des Usagers</title>
</head>

<body>
    <?php
    require 'App/Controller/LoginUsager.php';
    session_start();

    if (isset($_SESSION["nom_utilisateur"])) {
        echo 'Bienvenue  ' . $_SESSION["nom_utilisateur"];
    } else {
        require 'templates/accueil.php';

        if (isset($_POST['login'])) {
            require 'templates/formLogin.php';
        }
        if (isset($_POST['signin'])) {
            require 'templates/formsingin.php';
        }

        if (isset($_POST['identifiant'], $_POST['password']) && !empty($_POST['identifiant']) && !empty($_POST['password'])) {
            $valid = LoginUsager::verifierMotDePasse($_POST['identifiant'], $_POST['password']);
            if ($valid) {
                $_SESSION["nom_utilisateur"] = LoginUsager::getNomUtilisateur($_POST['identifiant']);

                echo "<script>window.location.href='index.php'</script>";
            } else {
                echo "Authentification échouée!";
            }
        } else {
            echo "Veuillez remplir toutes les zones du formulaire!";
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
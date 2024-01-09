<?php
require 'templates/formLogin.php';
// récupérer données form connexion 
if (isset($_POST['identifiant'], $_POST['password']) && !empty($_POST['identifiant']) && !empty($_POST['password'])) {
    $valid = LoginUsager::verifierMotDePasse($_POST['identifiant'], $_POST['password']);
    if ($valid) {
        $_SESSION["nom_utilisateur"] = LoginUsager::getNomUtilisateur($_POST['identifiant']);
        $_SESSION["fonction"] = LoginUsager::getFonctionUtilisateur($_POST['identifiant']);
        echo "<script>window.location.href='index.php'</script>";
    } else {
        echo "Authentification échouée!";
    }
} else {
    echo "Veuillez remplir toutes les zones du formulaire!";
}

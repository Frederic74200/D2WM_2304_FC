<?php

require './App/Model/Connexion.php';


class LoginUsager
{

    public static function verifierMotDePasse(string $_identifiant, string $_mdp): bool
    {

        $loginOk = false;
        $requete = "SELECT * FROM usagers WHERE utilisateur_mail =:mail";

        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(":mail", $_identifiant, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }

        $nbLigne = $state->rowCount();

        if ($nbLigne > 0) {
            $ligne = $state->fetch();

            if (password_verify($_mdp, $ligne["utilisateur_mdp"])) {
                $loginOk = true;
                echo 'mdp ok';
            } else {
                echo "Mot de passe erroné!";
            }
        } else {
            echo "Identifiant erroné!";
        }

        return $loginOk;
    }


    public static function getNomUtilisateur(string $_identifiant)
    {

        $userName = '';
        $requete = "SELECT utilisateur_prenom, utilisateur_nom FROM usagers WHERE utilisateur_mail =:mail";

        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(":mail", $_identifiant, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }

        $nbLigne = $state->rowCount();

        if ($nbLigne > 0) {
            $ligne = $state->fetch();
            $userName = $ligne["utilisateur_prenom"] . " " . $ligne["utilisateur_nom"];
        } else {
            echo "Erreur userName!";
        }

        return $userName;
    }

    public static function getFonctionUtilisateur(string $_identifiant)
    {

        $userFonction = '';
        $requete = "SELECT fonctions.fonction_nom FROM fonctions 
        INNER JOIN usagers ON usagers.fonction_id = fonctions.fonction_id
        WHERE usagers.utilisateur_mail =:mail";

        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(":mail", $_identifiant, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }

        $nbLigne = $state->rowCount();

        if ($nbLigne > 0) {
            $ligne = $state->fetch();
            $userFonction = $ligne["fonction_nom"];
        } else {
            echo "Erreur userFonction !";
        }

        return $userFonction;
    }
}

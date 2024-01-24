<?php
require './src/Models/Connexion.php';




class LogClass
{

    public function __construct()
    {
    }





    public static function checkPassWord(string $_identifiant, string $_mdp): bool
    {

        $loginOk = false;
        $requete = "SELECT * FROM utilisateurs WHERE mail_user =:mail";

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

            if (password_verify($_mdp, $ligne["pass_user"])) {
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


    public function userInfos(string $_identifiant): array
    {

        $userInfos = [];
        $requete = "SELECT utilisateurs.firstname_user, utilisateurs.lastname_user, avatars.image_url
        FROM utilisateurs
        INNER JOIN avatars ON utilisateurs.avatar = avatars.id
        WHERE utilisateurs.mail_user =:mail";

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
            $userInfos = $state->fetch();
        }


        return $userInfos;
    }
}

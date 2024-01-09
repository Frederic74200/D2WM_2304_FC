<?php
require './App/Model/Connexion.php';

class SinginUsager
{



    private function __construct()
    {
    }

    public static function verificationCode(string $codeInscr): bool
    {
        $codeOk = false;
        $requete = " SELECT  :code_inscription FROM fonctions";

        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(" :code_inscription", $codeInscr, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }

        $nbLigne = $state->rowCount();

        if ($nbLigne > 0) {
            $ligne = $state->fetch();

            $find = false;

            for ($i = 0; $i < $ligne->count(); $i++) {
                if (password_verify($codeInscr, $ligne[$i])) {
                    $find = true;
                }
            }


            if ($find) {
                $codeOk = true;
            } else {
                echo "Code eronné";
            }
        }

        return $codeOk;
    }



    public static function  verificationNom(string $nom): bool
    {

        $pattern = "/a-zA-Z_àâäçéèêëïîôœùûüÿ";

        return  preg_match($pattern, $nom);
    }



    public static function  verificationPrenom(string $prennom): bool
    {

        $pattern = "/a-zA-Z_àâäçéèêëïîôœùûüÿ";

        return  preg_match($pattern, $prennom);;
    }


    public static function  verificationMail(string $mail): bool
    {

        $pattern = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        return  preg_match($pattern, $mail);;
    }




    public static function  verificationMDP(string $mdp, string $confirmpdp): bool
    {
        $mdpOk = false;

        if ($mdp === $confirmpdp) {

            $pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&*?])[a-zA-Z0-9@#$%^&*?]{12,}$";
            if (preg_match($pattern, $mdp)) {
                $mdpOk = true;
            } else {
                echo 'Le mot de passe doit faire au minimum 12 caractères et contenir au moins une majuscule, une minucule, un chiffre et un caractère spécial.';
            }
        } else {
            echo 'les mots de passes ne corespondents pas ';
        }
        return  $mdpOk;
    }


    public static function  descriptionToString(string $descript): string
    {
        $descri = '';



        $descri = htmlspecialchars(strval($descript));


        return  $descri;
    }
    public static function addUserDB(array $formData): void
    {

        var_export($formData);
    }



    /*
    private static function getFonctionId(string $codeInscr): void
    {

        $requete = " SELECT fonction_id FROM fonctions  WHERE fonction_code_inscription = :code_inscription ";

        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(" :code_inscription", $codeInscr, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }

        $nbLigne = $state->rowCount();

        if ($nbLigne > 0) {
            $ligne = $state->fetch();

            $dataFormInsc['fonction_id'] =  $ligne['fonction_id'];
        }
    }*/
}

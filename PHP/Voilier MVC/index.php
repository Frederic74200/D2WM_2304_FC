<?php

session_start();



if (isset($_SESSION["user"])) {
    require 'src/Vues/listpage.php';

    if (isset($_GET['logout'])) {

        session_destroy();

        echo "<script>window.location.href='index.php'</script>";
    }
} else {
    if ($_GET == null && $_POST == null) {
        require 'src/Vues/homepage.php';
    }

    if (isset($_GET['log'])) {

        require 'src/Vues/logpage.php';
    }
    if (isset($_GET['sing'])) {

        require 'src/Vues/signpage.php';
    }

    if (isset($_POST['logform'])) {
        require 'src/Controllers/LogClass.php';
        $log = new LogClass();
        $logOk = false;
        $logOk = $log->checkPassWord($_POST['email'], $_POST['password']);
        var_dump($logOk);
        if ($logOk == true) {

            $_SESSION['user'] = $_POST['email'];
            $_SESSION['userdata'] = [];
            $_SESSION['userdata'] = $log->userInfos($_POST['email']);


            echo "<script>window.location.href='index.php'</script>";
        } else {

            echo "<script>alert('Erreur de connexion! Veuillez vérifier votre mot de passe.'); window.location.href='index.php?log=log'</script>";
        }
    }

    if (isset($_POST['sigform'])) {


        if ($_POST['password']  === $_POST['prtpassword']) {
            require 'src/Controllers/SignClass.php';
            $user = new SignClass($_POST, $_FILES);

            $idav = 3;
            if (!empty($_FILES)) {
                $adav = 0;
                $adav = $user->addAvatar();

                if ($adav != 0) {

                    $idav = $user->getIdAvatar();
                }
            }




            $signOk = 0;

            $signOk = $user->addUser($idav);


            if ($signOk != 0) {
                session_destroy();
                echo "<script>alert('Inscription réussie. Connectez-vous '); window.location.href='index.php?log=log'</script>";
            } else {

                echo "<script>alert('Erreur inscription. Recommencez ! '); window.location.href='index.php?sing=sing'</script>";
            }
        } else {

            echo "<script>alert('Les mots de passes ne sont pas identiques ! Veuillez recommencer.'); window.location.href='index.php?sing=sing'</script>";
        }
    }
}



/*

$mdp = "Tournedisque";
$hash_mdp =  password_hash($mdp, CRYPT_BLOWFISH);
echo $hash_mdp;
*/

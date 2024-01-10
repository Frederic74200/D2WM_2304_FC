<?php

session_start();



if (isset($_SESSION["user"])) {
    require 'src/Vues/listpage.php';
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
        }
    }
}
/*
if (!isset($_SESSION) && empty($_SESSION)) {

    session_start();
    if (isset($_GET) && !empty($_GET)) {
        var_dump($_GET);
        if (isset($_GET['log'])) {
            require 'src/Vues/logpage.php';
        } elseif (isset($_GET['sing'])) {
            require 'src/Vues/signpage.php';
        }
    } elseif (isset($_POST) && !empty($_POST)) {
        var_dump($_POST);
        if (isset($_POST['logform']) && !empty($_POST['logform'])) {
            require 'src/Controllers/LogClass.php';
            $log = new LogClass();
            $logOk = false;
            $logOk = $log->checkPassWord($_POST['email'], $_POST['password']);
            var_dump($logOk);
            if ($logOk == true) {

                $_SESSION['user'] = "toto";
                unset($_POST);

                echo "<script>window.location.href='index.php'</script>";
            } else {
                require 'src/Vues/logpage.php';
            }
        }
    } else {
        require 'src/Vues/homepage.php';
    }
} else {
    @session_start();
    require 'src/Vues/listpage.php';
}



$mdp = "Tournedisque";
$hash_mdp =  password_hash($mdp, CRYPT_BLOWFISH);
echo $hash_mdp;
*/

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Guide restaurants </title>
</head>

<body>
    <h1>Guide des restaurants </h1>

    <?php
    require 'assets/php/Connexion.php';

    $maConnexion = Connexion::getInstance();

    $rqt = "SELECT * FROM restaurants";

    $state = $maConnexion->prepare($rqt);

    $state->execute();

    $tableau = [];

    while ($ligne = $state->fetch()) {
        array_push($tableau, $ligne);
    }


    foreach ($tableau as $key => $value) {
    }


    ?>




</body>

</html>
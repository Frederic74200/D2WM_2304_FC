<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tests Utilisateurs</title>
</head>

<body>

    <?php

    $mdp = "123456789";
    $mdp2 = "azertyUiop30£123Frl_";
    $hash_mdp =  password_hash($mdp, PASSWORD_DEFAULT);
    $hash_mdp2 =  password_hash($mdp2, PASSWORD_DEFAULT);

    echo $hash_mdp;
    echo '<br/>';
    echo $hash_mdp2;
    echo '<br/>';

    if (password_verify($mdp, $hash_mdp)) {
        echo "MDP CORRECT";
    }

    echo '<br/>';

    if (password_verify($mdp2, $hash_mdp2)) {
        echo "MDP CORRECT";
    } else {
        echo "Raté !";
    }



    ?>




</body>

</html>
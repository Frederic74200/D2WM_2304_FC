<?php
require 'Emprunt.php';

if (!empty($_POST['capital']) && !empty($_POST['taux'])  && !empty($_POST["duree"])) {
    $emprunt = new Emprunt($_POST['capital'], $_POST['taux'], $_POST["duree"]);
    $resultat = $emprunt->calculerMensualité();
    $tableau = $emprunt->revoyertablea();
} else {
    $resultat = 1234;
}


?>

<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mensualité d'un prêt</title>
</head>

<body>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        <label for="capital">Capital emprunté</label>
        <input type="number" name="capital" id="capital">
        <label for="taux">taux en % </label>
        <input type="taux" name="taux" id="taux">
        <label for="duree">Durée de remboursement en années</label>
        <input type="number" name="duree" id="duree">
        <button type="submit">Valider</button>
        <label for="mensualite">Mensualité :</label>
        <input type="text" name="mensualite" id="mensualité" readonly value="<?php echo $resultat;  ?>">






    </form>

    <h2>Tableau de remboursement d'amorissment du pret </h2>

    <table>
        <?php

        echo $tableau;

        ?>

    </table>


</body>

</html>
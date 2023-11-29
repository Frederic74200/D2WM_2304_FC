<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mensualité d'un prêt</title>
</head>

<body>

    <form action="index.php" method="get">
        <label for="capital">Capital emprunté</label>
        <input type="number" name="capital" id="capital">
        <label for="taux">taux en % </label>
        <input type="taux" name="taux" id="taux">
        <label for="duree">Durée de remboursement en années</label>
        <input type="number" name="duree" id="duree">
        <input type="submit" name="valider" id="valider" value="valider">

        <label for="mensualite">Mensualité :</label>

        <?php
        require_once('Emprunt.php');

        $capital = $_GET["capital"];
        $taux = $_GET['taux'];
        $duree = $_GET['duree'];
        $emprunt = new Emprunt($capital, $taux, $duree);
        $mensualite = $emprunt->calculerMensualité();
        echo  '<input type=\"number\" name=\"mensualite\" id=\"mensualite\" value=\"' . $mensualite . '\">';
        ?>




    </form>

    <h2>Tableau de remboursement d'amorissment du pret </h2>


</body>

</html>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Modifier la fiche Restaurant</title>
</head>

<body>
    <?php

    $nomResto = $_POST["nomResto"];
    $adreseeResto = $_POST['adresseResto'];
    $prixResto = $_POST["prixResto"];
    $commentResto = $_POST["commentResto"];
    $noteResto = $_POST["noteResto"];
    $visiteResto = $_POST["visiteResto"];
    ?>


    <form action="" method="$_POST">


        <div>
            <label for="nom">Nom du resaturant : </label>
            <input type="text" name="nom" id="nom" value=<? $nomResto  ?>>
        </div>
        <div>
            <label for="adresse">Adresse du resaturant : </label>
            <input type="text" name="adresse" id="adresse">
        </div>
        <div>
            <label for="prix">prix : </label>
            <input type="number" name="prix" id="prix">
        </div>
        <div>
            <label for="commentaire">Commentaire : </label>
            <textarea name="commentaire" id="" cols="30" rows="10"></textarea>
        </div>
        <div>
            <label for="note">Note : </label>
            <input type="number" name="note" id="note">
        </div>
        <div>
            <label for="visite">prix : </label>
            <input type="date" name="visite" id="visite">
        </div>
        <input type="submit" value="Modifier" id="modifier">
    </form>







</body>

</html>
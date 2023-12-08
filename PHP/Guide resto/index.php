<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Guide restaurants </title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <!--
    <script src="https://unpkg.com/vue@3/dist/vue.global.js"></script>
    <script src="assets/js/main.js" type="module"></script>
-->
</head>

<body>
    <h1>Guide des restaurants </h1>



    <?php

    /*
    require 'assets/php/Connexion.php';

    $maConnexion = Connexion::getInstance();

    $rqt = "SELECT * FROM restaurants";

    $state = $maConnexion->prepare($rqt);

    $state->execute();

    $tableau = [];
    while ($ligne = $state->fetch()) {
        array_push($tableau, $ligne);
    }
   
    $json = json_encode($tableau, JSON_PRETTY_PRINT);
    if (!is_dir('data/')) {
        // dir doesn't exist, make it
        mkdir('data/');
    }

    file_put_contents("data/restaurants.json", $json);

*/

    require "./assets/php/MyTable.php";

    $maTable = new MyTable("restaurants");

    $mesDonnees = $maTable->readTable();
    /*  var_dump($mesDonnees[0]);

    $flags = array();
    $flags = $maTable->getFlags();



    foreach ($flags as $value) {
        foreach ($value as $val) {
            echo "<br/>" . $val;
        }
    }

    // echo "<p> clé primare : "  . "</p><br/>";

*/
    echo $maTable->rendreHTML();






    /*
$nomResto = $_POST["nomResto"];
    $adreseeResto = $_POST['adresseResto'];
    $prixResto = $_POST["prixResto"];
    $commentResto = $_POST["commentResto"];
    $noteResto = $_POST["noteResto"];
    $visiteResto = $_POST["visiteResto"];

    */

    /*
    echo "<table class='table table-dark table-hover'><thead><tr>  <th>Modifier</th>";
    foreach ($mesDonnees[1] as $value) {

        echo "<th>$value</th>";
    }

    echo "  <th>Supprimer</th></tr></thead><tbody>";
    for ($i = 2; $i < count($mesDonnees); $i++) {

        echo "<tr>";
        echo '<td><button type="button" name="bouton" id="' . $mesDonnees[$i][0] . '">Modifier</button></td>';
        for ($j = 0; $j < count($mesDonnees[$i]); $j++) {
            echo "<td>" . $mesDonnees[$i][$j] . "</td>";
        }
        echo '<td><button type="button" class="btnSupp" id="' . $mesDonnees[$i][0] . '">Suppr</button></td>';
        echo "</tr>";
    }
    echo "</tbody></table>";




*/




    ?>

    <form action="detail.php" method="post">

    </form>



    <a href="detail.php">Formulaire</a>



    <!--    

    <div id="app">



        <p>{{toto}}</p>

        <section vfor=" resto of guideResto ">
            <h2> {{ resto.nom }} </h2>
            <p>Adresse : {{ resto.adresse }}</p>
            <p>Prix : {{ resto.prix }}</p>
            <p>Commentaire : {{ resto.commentaire }} </p>
            <p>{{ resto.note }}/10</p>
            <label for="visite">Date de visite</label>
            <input type="date" name="visite" id="visite" readonly :value="resto.visite">

        </section>





    </div>

-->
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>

</body>

</html>
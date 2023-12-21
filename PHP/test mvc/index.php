<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>valeur check</title>
</head>

<body>


    <form action="index.php" method="POST" enctype="multipart/form-data">
        <input type="checkbox" name="check" id="check" value="value check"> check
        <input type="submit" value="valider">
    </form>

    <?php

    if (isset($_POST['check']) && !empty($_POST['check'])) {
        var_dump($_POST['check']);
    } else {
        echo 'remplir formulaire';
    }


    ?>

</body>

</html>
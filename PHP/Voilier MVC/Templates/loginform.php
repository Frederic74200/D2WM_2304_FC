<form name='login' action="<?php echo $_SERVER["PHP_SELF"] ?>" method="POST" enctype="multipart/form-data">

    <fieldset> Accès Membres
        <input type="hidden" name="logform" value="0">
        <label for="email">E Mail : </label>
        <input type="email" name="email" id="email">
        <label for="password">Mot de passe : </label>
        <input type="password" name="password" id="password">
        <input type="submit" value="Valider" id="login">

    </fieldset>





</form>
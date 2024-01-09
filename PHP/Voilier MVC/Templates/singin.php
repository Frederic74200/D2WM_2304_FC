<form name='singin' action="<?php echo $_SERVER["PHP_SELF"] ?>" method="POST" enctype="multipart/form-data">

    <fieldset> Inscription

        <label for="lastname">Nom :</label>
        <input type="text" name="lastname" id='lastname'>
        <label for="firstname">Prénom : </label>
        <input type="text" name="firstname" id='firstname'>
        <label for="email">E Mail : </label>
        <input type="email" name="email" id="email">
        <label for="password">Mot de passe : </label>
        <input type="password" name="password" id="password">
        <label for="rptpassword">Répéter mot de passe : </label>
        <input type="password" name="prtpassword" id="rptpassword">

        <fieldset>Choissiez votre avatar :
            <input type="file" id="avatar" name="avatar" accept="image/png, image/jpeg" />
        </fieldset>


        <input type="submit" value="Soumettre" id="singin">

    </fieldset>





</form>
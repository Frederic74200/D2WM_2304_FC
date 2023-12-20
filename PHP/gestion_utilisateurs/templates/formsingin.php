<form action="index.php" method="POST" enctype="multipart/form-data">
    <fieldset>Inscription
        <label for="codeIns">Code d'inscription : </label>
        <input type="text" name="codeIns" id="codeIns">
        <label for="nom">Nom : </label>
        <input type="text" name="nom" id="nom">
        <label for="prenom">Prénom : </label>
        <input type="text" name="prenom" id="prenom">
        <label for="email">Email : : </label>
        <input type="email" name="email" id="email">
        <label for="choisePassword">Choisissez vote mot de passe : </label>
        <input type="text" name="choisePassword" id="choisePassword">
        <label for="confirmPassword">Confirmer le mot de passe : </label>
        <input type="text" name="confirmPassword" id="confirmPassword">
        <label for="description">Description</label>
        <textarea name="description" id="description" cols="30" rows="10"></textarea>
        <input type="submit" value="Envoyer">
        <input type="reset" value="Réinitialiser">
    </fieldset>
</form>
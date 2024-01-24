<main>

    <h2>Ajouter un nouveau micro-processeur</h2>


    <form action="index.php" method="post">

        <fieldset>
            <div>
                <label for="Famille">Famille du processeur</label>
                <input type="text" name="famille" id="famille" pattern="^[a-zA-Z0-9]{2}$" required>
            </div>
            <div>
                <label for="modele">Modéle du processeur</label>
                <input type="text" name="modele" id="modele" pattern="^[A-Z0-9]{6,7}$" required>
            </div>
            <div>
                <label for="frequence">Fréquence du processeur</label>
                <input type="number" name="frequence" id="frequence" pattern="^[0-9]{4}$" min="1600" max="5000" required>
            </div>
            <div>
                <input type="submit" value="Ajouter">
            </div>

            <?php if ($inputOk = false) : ?>
                <p>Vérifiez la siaise ! </p>
            <?php endif ?>

        </fieldset>

    </form>
<form action="index.php" method="post" enctype="multipart/form-data">
    <fieldset id="choixDpt">
        <label for="dept">Choisissez votre département </label>
        <div>
            <input type="number" name="dept" id="dept">
            <select name="dept" id="selectDept">
                <option value="73">73</option>
                <option value="74">74</option>
            </select>
        </div>
    </fieldset>
    <fieldset id="choixEts">
        <label for="typeEts">Choisissez votre type d'établissment </label>
        <div>
            <input type="checkbox" name="typeEts" id="dept" value="TPE">TPE
            <input type="checkbox" name="typeEts" id="dept" value="PME">PME
            <input type="checkbox" name="typeEts" id="dept" value="GD">Grande Entreprise
        </div>
        <div>
            <input type="checkbox" name="typeEts" id="dept" value="GD">Collectivité terriroriale
            <input type="checkbox" name="typeEts" id="dept" value="GD">Association
            <input type="checkbox" name="typeEts" id="dept" value="GD">Autres
        </div>
    </fieldset>
    <input type="submit" value="Valider">
</form>

<h1>Le tableau</h1>
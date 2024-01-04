<?php
require './App/vue/ViewToTemplate.php';
$numDept = [];
$view = new ViewToTemplate();
$numDept = $view->getDeptNum();
?>
<form action="index.php" method="POST" enctype="multipart/form-data">
    <fieldset id="choixDpt">
        <label for="dept">Choisissez votre département </label>
        <div>
            <select name="dept" id="selectDept">
                <option value="">Choisir un département</option>

                <?php
                /*
                // $numDept = [1, 2, 3, 4, 5, 66];

                for ($i = 0; $i < count($numDept); $i++) {


                    echo ' <option value="' . $numDept[$i]->id_dept . ' >' . $numDept[$i]->name . '</option>';
                }
*/
                foreach ($numDept as $key => $value) : ?>
                    <option value="<?php echo $key ?>"><?php echo $value ?></option>

                <?php endforeach ?>



            </select>
        </div>
    </fieldset>
    <fieldset id="choixEts">
        <label for="typeEts">Choisissez votre type d'établissment </label>
        <div>
            <input type="checkbox" name="typeEts[]" id="dept" value="TPE">TPE
            <input type="checkbox" name="typeEts[]" id="dept" value="PME">PME
            <input type="checkbox" name="typeEts[]" id="dept" value="GE">Grande Entreprise
        </div>
        <div>
            <input type="checkbox" name="typeEts[]" id="dept" value="CT">Collectivité terriroriale
            <input type="checkbox" name="typeEts[]" id="dept" value="ASSOC">Association
            <input type="checkbox" name="typeEts[]" id="dept" value="AUTRES">Autres
        </div>
    </fieldset>

    <input type="submit" value="Valider" id="valider">

</form>
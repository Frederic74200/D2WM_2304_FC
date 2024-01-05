<?php
require './App/Controllers/ViewToTemplate.php';
$numDept = [];
$view = new ViewToTemplate();
$numDept = $view->getDeptNum();
$inputEts = [];
!empty($view->getValuesEts()) ? $inputEts = $view->getValuesEts()   : $inputEts = [];





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
            <input type="checkbox" name="typeEts[]" id="dept" value="TPE" <?php
                                                                            if (!empty($inputEts)) {
                                                                                foreach ($inputEts as $value) {
                                                                                    if ($value == "TPE") {
                                                                                        echo "checked='true'";
                                                                                    }
                                                                                }
                                                                            }
                                                                            ?>>TPE
            <input type="checkbox" name="typeEts[]" id="dept" value="PME" <?php
                                                                            if (!empty($inputEts)) {
                                                                                foreach ($inputEts as $value) {
                                                                                    if ($value == "PME") {
                                                                                        echo "checked='true'";
                                                                                    }
                                                                                }
                                                                            }
                                                                            ?>>PME
            <input type="checkbox" name="typeEts[]" id="dept" value="GE" <?php
                                                                            if (!empty($inputEts)) {
                                                                                foreach ($inputEts as $value) {
                                                                                    if ($value == "GE") {
                                                                                        echo "checked='true'";
                                                                                    }
                                                                                }
                                                                            }
                                                                            ?>>Grande Entreprise
        </div>
        <div>
            <input type="checkbox" name="typeEts[]" id="dept" value="CT" <?php
                                                                            if (!empty($inputEts)) {
                                                                                foreach ($inputEts as $value) {
                                                                                    if ($value == "CT") {
                                                                                        echo "checked='true'";
                                                                                    }
                                                                                }
                                                                            }
                                                                            ?>>Collectivité terriroriale
            <input type="checkbox" name="typeEts[]" id="dept" value="ASSOC" <?php
                                                                            if (!empty($inputEts)) {
                                                                                foreach ($inputEts as $value) {
                                                                                    if ($value == "ASSOC") {
                                                                                        echo "checked='true'";
                                                                                    }
                                                                                }
                                                                            }
                                                                            ?>>Association
            <input type="checkbox" name="typeEts[]" id="dept" value="AUTRES" <?php
                                                                                if (!empty($inputEts)) {
                                                                                    foreach ($inputEts as $value) {
                                                                                        if ($value == "AUTRES") {
                                                                                            echo "checked='true'";
                                                                                        }
                                                                                    }
                                                                                }
                                                                                ?>>Autres
        </div>
    </fieldset>

    <input type="submit" value="Valider" id="valider">

</form>
<?php
require './App/Controllers/ViewToTemplate.php';
$numDept = [];
$view = new ViewToTemplate();
$numDept = $view->getDeptNum();
$inputEts = [];
!empty($view->getValuesEts()) ? $inputEts = $view->getValuesEts()   : $inputEts = [];

$values = ["TPE", "PME", "GE", "CT", "ASSOC", "AUTRES"];

$deptInput = null;
$view->getdeptInput() != null ?  $deptInput = $view->getdeptInput() : $deptInput = null;

?>
<form action="index.php" method="POST" enctype="multipart/form-data">
    <fieldset id="choixDpt">
        <label for="dept">Choisissez votre département </label>
        <div>
            <select name="dept" id="selectDept">
                <option value="">Choisir un département</option>

                <?php
                foreach ($numDept as $key => $value) : ?>
                    <option value="<?php echo $key ?>" <?php
                                                        if ($deptInput != null && $deptInput == $key) {
                                                            echo '" selected="true"';
                                                        }
                                                        ?>><?php echo $value;
                                                            ?></option>
                <?php endforeach ?>

            </select>
        </div>
    </fieldset>
    <fieldset id="choixEts">
        <label for="typeEts">Choisissez votre type d'établissment </label>
        <div>
            <?PHP foreach ($values as $key) : ?>
                <input type="checkbox" name="typeEts[]" class="typeEts" value="<?PHP echo $key ?>" <?PHP foreach ($inputEts as $value)
                                                                                                        if ($value === $key) {
                                                                                                            echo 'checked="true"';
                                                                                                        }
                                                                                                    ?>>
                <label for="typeEts"> <?PHP echo $key ?></label>

            <?php endforeach ?>

        </div>
    </fieldset>

    <input type="submit" value="Valider" id="valider">


</form>
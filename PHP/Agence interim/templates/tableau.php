<?php

$reesult = [];
$view = new ViewToTemplate();
$reesult = $view->sortToForm();
$nbLignes = 0;


?>

<table id="tableau">
    <thead>
        <th>Nom de l'établissment</th>
        <th>Type</th>
        <th>Nom du responsable</th>
        <th>adresse</th>
        <th>Code postal</th>
        <th>Ville</th>
        <th>Téléphone</th>
        <th>E-mail</th>
    </thead>
    <tbody>
        <?php foreach ($reesult as $key) : ?>
            <tr>
                <?php foreach ($key as $value) : ?>
                    <td><?php echo $value ?></td>
                <?php endforeach ?>

                <?php $nbLignes++ ?>
            </tr>
        <?php endforeach ?>
    </tbody>

    <?php if ($nbLignes > 0) : ?>
        <tfoot>
            <tr>
                <td>
                    Resultats de la recherche :
                </td>
                <td>
                    <?php echo $nbLignes ?>
                </td>

                <td>
                    <button type="button" onclick="window.print()" id="printBtn">Imprimer</button>
                </td>
                <td>
                    <button type="button" onclick="convertirEnPDF()" id="printBtn">Convertir en PDF</button>
                </td>

            </tr>
        </tfoot>
    <?php endif; ?>

</table>

<script>
    function convertirEnPDF() {
        // Obtenez le tableau à convertir
        const tableau = document.getElementById("tableau").innerHTML;

        // Définissez les paramètres de conversion
        const orientation = "landscape";

        // Enregistrez le tableau au format PDF
        const blob = new Blob([tableau], {
            type: "application/pdf"
        });
        const url = window.URL.createObjectURL(blob);
        const link = document.createElement("a");
        link.href = url;
        link.download = "tableau.pdf";
        link.click();
    }
</script>
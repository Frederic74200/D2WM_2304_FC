<?php
$reesult = [];
$view = new ViewToTemplate();
$reesult = $view->sortToForm();
?>

<table>
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
            </tr>
        <?php endforeach ?>
    </tbody>

</table>
<?php
require 'vendor/autoload.php';

use App\Controllers\GetCPUList;


$liste = [];
$get = new GetCPUList();
$liste = $get->getList();
?>

<h2>Liste des micro-processeurs disponibles</h2>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Famille</th>
            <th>Modèle</th>
            <th>Fréquence de base</th>
        </tr>
    </thead>
    <tbody>
        <?php foreach ($liste as $key) : ?>
            <tr>
                <?php foreach ($key as $value) : ?>
                    <td><?php echo $value ?></td>
                <?php endforeach ?>
            </tr>
        <?php endforeach ?>

    </tbody>
</table>

</main>
<?php
@session_start();

require './App/Controllers/interim.php';
$inputForm = array();
$input = new interim();







if (!empty($_SESSION['array'])) {


    $inputForm = $input->resultats($_SESSION['array']);
} else {

    $inputForm = $input->allData();
}


?>



<table>
    <thead>
        <th>Nom de l'établissment</th>
        <th>Type</th>
        <th>Nom du responsable</th>
        <th>Lieu</th>
        <th>Téléphone</th>
        <th>E-mail</th>
    </thead>
    <tbody>
        <tr>
            <td>A</td>
            <td>Z</td>
            <td>E</td>
            <td>R</td>
            <td>T</td>
            <td>Y</td>
        </tr>
    </tbody>

</table>
<br />
<p>Le tableau</p>
<?php
echo "rien";

?>
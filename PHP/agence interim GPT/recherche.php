<?php
// Connexion à la base de données
$servername = "votre_serveur";
$username = "votre_nom_utilisateur";
$password = "votre_mot_de_passe";
$dbname = "votre_base_de_donnees";

$conn = new mysqli($servername, $username, $password, $dbname);

// Vérification de la connexion
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Traitement du formulaire
if (isset($_POST['search'])) {
    $departement = $_POST['departement'];
    $type_etablissement = isset($_POST['type_etablissement']) ? $_POST['type_etablissement'] : [];

    // Construire la requête SQL en fonction des critères de recherche
    $sql = "SELECT * FROM listing WHERE departement = '$departement'";

    if (!empty($type_etablissement)) {
        $types = implode("','", $type_etablissement);
        $sql .= " AND type_etablissement IN ('$types')";
    }

    // Exécuter la requête
    $result = $conn->query($sql);

    // Afficher les résultats
    if ($result->num_rows > 0) {
        echo "<table>";
        while ($row = $result->fetch_assoc()) {
            echo "<tr><td>" . $row['nom'] . "</td><td>" . $row['adresse'] . "</td></tr>";
        }
        echo "</table>";
    } else {
        echo "Aucun résultat trouvé.";
    }
}

// Fermer la connexion
$conn->close();

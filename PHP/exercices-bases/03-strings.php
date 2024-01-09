<?php

function getMC2() {
    return "Albert Einstein"; 
}

function  getUserName( string $nom , string $prenom) : string {
    if ( gettype($nom ) == "string" && gettype($prenom ) == "string"   ) {
        return $nom.$prenom;
    }
    else {
        return "Erreur saisie !"; 
    }
}


function  getFullName( string $nom , string $prenom) : string {
    if ( gettype($nom ) == "string" && gettype($prenom ) == "string"   ) {
        return       mb_convert_case($prenom,  MB_CASE_LOWER, "UTF-8"). " " .  mb_convert_case($nom, MB_CASE_UPPER, "UTF-8") ;
    }
    else {
        return "Erreur saisie !"; 
    }
}

function askUser(string $nom , string $prenom) : string {

return "Bonjour ". getFullName($nom, $prenom) . " Connaissez-vous ".getMC2()." ?" ;
}


echo " - M=MC2 : " .  getMC2(); 
echo ' - getUserName  ' . getUserName("Dupont", "michel"); 
echo '- getFullName  ' . getFullName("Dupont", "michel"); 
echo ' - askUser  ' . askUser("Dupont", "michel"); 

?>
<?php

function getToday() {
    // Récupère la date actuelle
    $today = new DateTime();
  
    // Formate la date
    $formattedDate = $today->format('d/m/y');
  
    // Renvoie la date formatée
    return $formattedDate;
  }

/*
function  getTimeLeft(string $date ) : string {

if(!DateTime::createFromFormat('Y-m-d', $date)) {
    return "Date invalide";
  }
  
 $today = new DateTime();

 $inputDate = new DateTime ( $date );

// echo " --test date input" . $inputDate->format('y/m/d'); 
// echo " --test date input" . $today->format('y/m/d'); 
 $difference = $today->diff($inputDate); 

// return $difference < $imnputDate ? " Évènement passé" : $difeerence == $inputDate ? " Aujourd\'hui" : ($difference->y, $difference->m, $difference->d);


if (  $inputDate < $today   ) {

    return "Évènement passé" ; 
}
elseif ( $today <$inputDate  ) {
    return $difference->y . $difference->m . $difference->d;
}
else {
    return " Aujourd\'hui" ; 
}


}

*/

function getTimeLeft(string $date): string
{
    
 
    if (DateTime::createFromFormat('y/m/d', $date)) {
        return 'Format de date invalide';
    }

    $dateActuelle = new DateTime();
    $dateDonnee = New DateTime($date); 
    $intervalle = $dateDonnee ->diff($dateActuelle) ; // (->)???  fonction pour trouver la differeence
 
   if ($dateDonnee > $dateActuelle) {

        $intervalle->y > 0 ? $years = ($intervalle->y . " ans ")  : $years = "" ;
        $intervalle->m > 0 ? $mounths  = ($intervalle->m . " mois ")  : $mounths = "" ;
        $intervalle->d > 0 ? $days  = ($intervalle->d . " Jours ")  : $days = "" ;
      //   $days =  $intervalle->d . " jours"; 

        return $years.$mounths.$days; 
  
    } else if (  $intervalle->y == 0 &&  $intervalle->m == 0 &&  $intervalle->d == 0 ) {
        return "Aujourd'hui";
    }
    else { 
        return " Évènement passé"; 

    }


}





echo "today " . getToday(); 

echo "\n  date test 1 : " . getTimeLeft ("2019-09-29"); // retourne « Évènement passé »
echo "\n date test 2 : " .getTimeLeft ("2023-11-20"); // retourne « Aujourd'hui »
echo "\n  date test 3 : " . getTimeLeft ("2023-12-06"); // retourne « Dans 16 jours »
echo "\n date test 4 : " . getTimeLeft ("2024-04-07"); // retourne « Dans 4 mois et 17 jours »
echo "\n  date test 5 : " . getTimeLeft ("2025-03-20"); // retourne « Dans 1 an et 4 mois »
echo "\n  date test 6 : " . getTimeLeft ("2026-08-20"); // retourne « Dans 2 ans et 9 mois »



?>
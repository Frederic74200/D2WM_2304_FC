<?php
$names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo' ];

function firstItem( array $tableau) 
{
    $temp = $tableau[0]; 
   return $temp == null ? null : $temp; 
}

//-------------------------------------

function lastItem( array $tableau) 
{
    $end = count($tableau) -1; 
    $temp = $tableau[$end]; 
   return $temp == null ? null : $temp; 
}

//-------------------------------------
/*function sortItems(array $tableau) {
    return implode(", ", array_sort($tableau));
}


*/

function stringItems(array $array) {
    // Vérifie si le tableau est vide
    if (empty($array)) {
      return "Nothing to display";
    }
  
    // Tri le tableau
    $array = array_sort($array);
  
    // Convertit le tableau en chaîne de caractères
    $string = implode(", ", $array);
  
    return $string;
  }


echo "first item : ".firstItem ($names); // retourne « Joe »
echo "\n last item : ".lastItem ($names); // retourne « Néo »
echo "\n string item : ".stringItems($names); // retourne « Jack, Joe, Léa, Néo, Zoé »

?>
<?php

function  stringLength(string $input ) : bool {

$lenght = strlen($input);
return  $lenght > 8 ? true : false;

}

function passwordCheck(string $password) {
    // Vérifie la longueur du mot de passe
    if (strlen($password) < 9) {
      return false;
    }
  
    // Vérifie la présence d'un chiffre
    if (!preg_match('/[0-9]/', $password)) {
      return false;
    }
  
    // Vérifie la présence d'une majuscule
    if (!preg_match('/[A-Z]/', $password)) {
      return false;
    }
  
    // Vérifie la présence d'une minuscule
    if (!preg_match('/[a-z]/', $password)) {
      return false;
    }
  
    // Vérifie la présence d'un caractère non alphanumérique
    if (!preg_match('/[^a-zA-Z0-9]/', $password)) {
      return false;
    }
  
    // Le mot de passe respecte toutes les règles
    return true;
  }

  $users = [
    'joe' => 'Azer1234!',
    'jack' => 'Azer-4321',
    'admin' => '1234_Azer',
  ]; 

/*
  function userLogin(string $userName, string $password, array $usersListe   )   {
    $loginok = false ; 
   
    foreach ( $usersListe as $key => $userName) {
      if ( $keys == $userName) {
        if ( current($usersListe) == $password ) {
          $loginok = true; 
          }
        }
    } 
     return $loginok; 
  }

*/

function userLogin($username, $password, $users)
{
    // Vérifie si l'utilisateur existe
    if (!array_key_exists($username, $users)) {
      echo " User Name"; 
        return false;
    }

    // Vérifie si le mot de passe correspond
    $hash = $users[$username];
    if (!password_verify($password, $hash)) {
      echo "passWord "; 
        return false;
    }

    // L'utilisateur a été identifié
    return true;
}



  
echo "stringLength 1 :".stringLength("motDePasse"); // retourne « true »
echo "\n stringLength 2 :".stringLength("azer"); // retourne « false »

echo "\n userLogin ".userLogin(  "joe", "Azer1234!" , $users ); 

?>
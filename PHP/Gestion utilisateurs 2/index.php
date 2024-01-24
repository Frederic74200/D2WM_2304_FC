<?php


$Usager = "Usager";
$Encadrant = "Encardrant";
$Responsable =  "Responsable";
$Administrateur =  "Administrateur";




$hash_Usager =  password_hash($Usager, CRYPT_BLOWFISH);
echo $hash_Usager;
echo "<br/>";

$hash_Encadrant =  password_hash($Encadrant, CRYPT_BLOWFISH);
echo $hash_Encadrant;
echo "<br/>";
$hash_Responsable =  password_hash($Responsable, CRYPT_BLOWFISH);
echo $hash_Responsable;
echo "<br/>";
$hash_Administrateur =  password_hash($Administrateur, CRYPT_BLOWFISH);
echo $hash_Administrateur;
echo "<br/>";

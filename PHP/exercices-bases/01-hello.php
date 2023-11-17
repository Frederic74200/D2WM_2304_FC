<?php


echo "Hello word !";

echo "<p> Hello word !</p>";



$prenom = 'Fred';

echo '<p> Hello ' . $prenom . ' !</p>';



function helloWord() : void
{
echo "Hello function !";
}

helloWord();


function hello( string $name) : string 
{
    if ( $name === "") {
        return "nobody";
    }
    else {
        return "hello ".$name; 
    }
}

$name = "Chaput"; 

echo hello($name); 

?>
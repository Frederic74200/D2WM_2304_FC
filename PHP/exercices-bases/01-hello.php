<?php


echo "Hello word !";

echo "<p> Hello word !</p>";



$prenom = 'Fred';

echo '<p> Hello ' . $prenom . ' !</p>';



function helloWord(): void
{
    echo "Hello function !";
}

helloWord();


function hello(string $name): string
{
    /*   $chaine = "";
    if ($name === "") {
        $chaine = "nobody";
    } else {
        $chaine = "hello " . $name;
    }

    return $chaine;*/

    return $name == "" ? "nobody " : "hello " . $name;
}

$name = "franck";

echo hello($name);

<?php

require('Client.php');
require('Intervenent.php');
require('Intervention.php');

use Client;
use Intervenent;
use Intervention;

$client1 = new Client("Dupont", "Paul", "1993-11-29",  12345, "rue des lilas");
$client2 = new Client("Dubois", "Lydia", "1963-07-23",  12356, "rue des tulipes");
$inter1 = new Intervenent("Ledoux", "Simone", "1988-12-11", 10000, 1000);
$inter2 = new Intervenent("Tirand", "jacques", "1967-04-05", 10000, 1000);
$seance1 = new Intervention('2023-11-28 15:00', "description de l'intrevention", $client1, $inter1);
$seance2 = new Intervention('2023-12-08 15:00', "description de l'intrevention", $client2, $inter2);

echo '\n client 1 ' . var_dump($client1);
echo '<br/><br/>';
echo '\n client 2 ' . var_dump($client2);
echo '<br/><br/>';
echo '\n inter 1 ' . var_dump($inter1);
echo '<br/><br/>';
echo '\n inter 2 ' . var_dump($inter2);
echo '<br/><br/>';
echo '\n seance 1 ' . var_dump($seance1);
echo '<br/><br/>';
echo '\n seance 2 ' . var_dump($seance2);
// calculerCherges()   interventionToString
echo '<br/><br/>';
echo '\n charges 1 ' . $inter1->calculerCherges();
echo '<br/><br/>';
echo '\n charges 2 ' . $inter2->calculerCherges();
echo '<br/><br/>';
echo '\n séance 1 to string :  ' .  $seance1->interventionToString();
echo '<br/><br/>';
echo '\n séance 2 to string :  ' . $seance2->interventionToString();

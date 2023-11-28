<?php

require_once('Client.php');
require_once('Intervenent.php');

use Client;
use Intervenent;

class Intervention
{

    private DateTime $dateHeure;
    private string $description;
    private Client $client;
    private Intervenent $intervenent;

    public function __construct($dateHeure, $description, $client, $intervenent)
    {
        $this->dateHeure = new DateTime($dateHeure);
        $this->description = $description;
        $this->client = $client;
        $this->intervenent = $intervenent;
    }

    public function interventionToString()
    {

        return "<br/> Client ----------------------- <br/> nom : " . $this->client->getNom() . " <br/> Prénom : " . $this->client->getPrenom() . " <br/> age : " . $this->client->getAge() . " <br/> adresse : " . $this->client->getAdresse() . "<br/> Interveent ----------------------- <br/> nom : " . $this->intervenent->getNom() . " <br/> Prénom : " . $this->intervenent->getPrenom() . " <br/> age : " . $this->intervenent->getAge() . " <br/> Charges : " . $this->intervenent->calculerCherges() . "<br/> Intervention ----------------------- <br/> date Heure : " .    $this->dateHeure->format('Y-m-d H:i:s')    . " <br/> Description : " . $this->description;
    }
}

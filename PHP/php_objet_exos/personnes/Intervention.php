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
}

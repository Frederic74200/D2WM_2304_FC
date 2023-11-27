<?php
class Personne
{
    private string $nom;
    private string $prenom;
    private int $age;

    public function __construct(string $nom, string $prenom, int $age)
    {
        $this->nom = $nom;
        $this->prenom = $prenom;
        $this->age = $age;
    }

    public function getNom()
    {
        return  $this->nom;
    }

    public function getPrennom()
    {
        return  $this->prenom;
    }

    public function getAge()
    {
        return  $this->age;
    }

    public function setNom($nom)
    {
        $this->nom = $nom;
    }
}

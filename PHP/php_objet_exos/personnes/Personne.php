<?php
class Personne
{
    private string $nom;
    private string $prenom;
    private int $age;

    public function __construct(string $nom, string $prenom, string $dateDeNaissance)
    {
        $this->nom = $nom;
        $this->prenom = $prenom;
        $dateDuJour = new DateTime();
        $dateDeNaissance = new DateTime($dateDeNaissance);
        $interval = $dateDuJour->diff($dateDeNaissance);
        $this->age = $interval->y;
    }

    public function getNom()
    {
        return  $this->nom;
    }

    public function getPrenom()
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

<?php
@session_start();


require './App/Controllers/interim.php';


class ViewToTemplate
{


    private $interim;

    private $tab = [];

    public function __construct()
    {
        $this->interim = new Interim();

        !empty($_SESSION['array']) ?  $this->tab = $_SESSION['array']  :  $this->tab  = [];
    }


    public function sortToForm(): array
    {
        $inputForm = array();


        if (!empty($this->tab)) {


            $inputForm = $this->interim->resultats($this->tab);
        } else {

            $inputForm = $this->interim->allData();
        }

        return $inputForm;
    }


    public function getValuesEts(): array
    {

        return $this->interim->getValuesEts($this->tab);
    }

    public function getDeptNum()
    {
        return $this->interim->getNumDpts();
    }


    public function getNbLignes(): int
    {
        return   $this->interim->getNbLignes();
    }

    public function getdeptInput()
    {
        return $this->interim->getdeptInput($this->tab);
    }
}

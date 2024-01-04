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

    public function getDeptNum()
    {
        return $this->interim->getNumDpts();
    }


    public function resetForm()
    {
        return session_destroy();
    }
}

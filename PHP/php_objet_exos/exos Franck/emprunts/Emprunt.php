<?php

class Emprunt
{

    private int $capital = 120000000000;
    private float $taux = 55.0;
    private int $duree = 2;
    private   $array = array();

    public function __construct($_capital, $_taux, $_duree)
    {
        $this->capital = $_capital;
        $this->taux = $_taux;
        $this->duree = $_duree;
    }


    // calcul mesualité 

    public function calculerMensualité(): float
    {

        return  round($this->capital * ($this->taux / 1200) / (1 - pow(1 + ($this->taux / 1200), (-1 * $this->duree * 12))), 2);
    }


    public function partInterets($capital)
    {
        return $capital * ($this->taux / 12);
    }

    public function partAmort($partInteret)
    {
        return $this->calculerMensualité() - $partInteret;
    }

    public function capitalDu($capital, $amort)
    {
        return $capital - $amort;
    }


    public function genererTableau()
    {

        $capitalDumois = 0.0;
        $partAmortMois = 0.0;
        $interetsMois = 0.0;
        $capitalDuMoisPrec = 0.0;



        for ($i = 0; $i < $this->duree * 12; $i++) {
            if ($i == 0) {

                $this->array['mois'] = $i + 1;
                $capitalDuMois = $this->capital;
                $this->array['capital'] = $capitalDuMois;
                $interetsMois = $this->partInterets($capitalDuMois);
                $this->array["interets"] = $interetsMois;
                $partAmortmois = $this->partAmort($interetsMois);
                $this->array["amort"] = $partAmortmois;
                $capitalDuMoisPrec = $capitalDuMois;
            } else {

                $this->array['mois'] = $i + 1;
                $capitalDuMois = $this->capitalDu($capitalDuMoisPrec, $partAmortMois);
                $this->array['capital'] = $capitalDuMois;
                $interetsMois = $this->partInterets($capitalDuMois);
                $this->array["interets"] = $interetsMois;
                $partAmortmois = $this->partAmort($interetsMois);
                $this->array["amort"] = $partAmortMois;
                $capitalDuMoisPrec = $capitalDuMois;
            }
        }

        return $this->array;
    }





    /*
    public function revoyertablea()
    {

        $tableauTest = " <thead><th>Numero de mois</th><th>Intérêts</th><th>Part amortissment</th><th>Capital restant dû</th></thead>";
        $mensualite = $this->calculerMensualité();
        $capitalRestant = $this->capital;
        $interets = 0;


        for ($i = 0; $i < 12; $i++) {


            $tableauTest .= "<tr><td>" . $i . "<td/><td>" . ($i + 1) . "<td/><td>" . ($i * 10) . "<td/><td>" . ($i * 20) . "<td/><tr/>";
        }

        return $tableauTest;
    }
    
  public void remplirColonnesIndex_1_2_3()
        {


            for (int i = 0; i < getMois() + 1; i++)
            {

                if (i == 0)
                {
                    double j = 0;
                    this.tableau[4].Add(j);
                    this.tableau[3].Add(this.capitalEmprunte);
                    this.tableau[2].Add(j);
                    this.tableau[1].Add(j);
                    this.tableau[0].Add(j);

                }

                else
                {
                    this.tableau[0].Add(i);


                    double interetsMensuel = this.tableau[3][i - 1] * getTauxMensuel();
                    this.tableau[1].Add(interetsMensuel);

                    double amortissementMois = calculerMensualite() - this.tableau[1][i];
                    this.tableau[2].Add(amortissementMois);


                    double capitalRestantDu = this.tableau[3][i - 1] - this.tableau[2][i];
                    this.tableau[3].Add(capitalRestantDu);

                    this.tableau[4].Add(calculerMensualite());
                }

            }
        }
*/
}

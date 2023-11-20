<?php


function getSum(int $a, int $b) : int {
    return $a + $b; 
}


function getSub(int $a, int $b) : int {
    return $a - $b; 
}



function getMulti(float $a, float $b) : float {
    return $a * $b; 
}


function getDiv(int $a, int $b) : float {

    if ( $b === 0) {
         return 0.0; 
    }
   else {
        $div = $a / $b; 
        return  round($div, 2);  
   }
}


$a = 3; 
$b = 5; 
$c = 5.6;
$d = -3.7;
$e = 20;
$f = 0; 

echo "sum : " . getSum($a,$b); 
echo " sub : " . getSub($a,$b); 
echo " multi 1 : " . getMulti($c,$a); 
echo " multi 2 : " . getMulti($c,$d); 
echo " div 1 : " . getDiv($e,$a); 
echo " div 2 : " . getDiv($e,$f); 




?>
<?php
$gewerkteuren = 40;
$uurtarief = 15.00;
$bonus = 100.00;
$bruto = $gewerkteuren * $uurtarief;
$belasting = 0.40 * $bruto;
if ($gewerkteuren <= 40){
    echo "Uw basissalaris is: € ". $bruto;
    echo "<br> Uw belasting is: € ". 0.40 * $bruto;
    echo "<br> Uw nettobedrag is: € ". 0.60 * $bruto;

}

elseif ($gewerkteuren > 40){
    echo "<br> Uw basissalaris is: € ". ($gewerkteuren + $bruto + $bonus);
    echo "<br> Uw belasting is: € ". 0.40 * $bruto;
    echo "<br> Uw nettobedrag is: € ". 0.60 * $bruto;

}
?>
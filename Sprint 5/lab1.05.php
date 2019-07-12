<?php
$array = [];
$array[0] = "een";
$array[1] = "twee";
$array[2] = 3;
$array[3] = "vier";
echo"<br>Stap 3 ";
array_push($array, 5);
print_r($array);
echo"<Br>Stap 4. Datatype is: ";
$type = gettype($array [4]);
print_r($type);
echo"<Br>Stap 6.";
unset($array[4]);
print_r($array);
echo"<Br> Stap 8.";
array_unshift($array,"nul");
print_r($array);
echo"<br> Stap 12.";
unset($array[0]);
unset($array[2]);
print_r($array);
echo"<br> Stap 14.";
unset($array[3]);
print_r($array);

 
<form>
    <h1>Stand eredivisie 18-19  </h1>
    <h3>Team</h3>
</form>
<?php



$club = Array(
    array("positie" => 1, "naam" => "Ajax", "gespeelde" => 34, "gewonnen" => 28, "gelijk" => 2, "verloren" => 4),
    array("positie" => 2, "naam" => "PSV", "gespeelde" => 34, "gewonnen" => 26, "gelijk" => 5, "verloren" => 3),
    array("positie" => 3, "naam" => "Feyenoord",  "gespeelde" => 34, "gewonnen" => 20, "gelijk" => 5, "verloren" => 9),
    array("positie" => 4, "naam" => "AZ",  "gespeelde" => 34, "gewonnen" => 17, "gelijk" => 7, "verloren" => 10),
    array("positie" => 5, "naam" => "Vitesse", "gespeelde" => 34, "gewonnen" => 14, "gelijk" => 11, "verloren" => 9),
    array("positie" => 6, "naam" => "Utrecht", "gespeelde" => 34, "gewonnen" => 15, "gelijk" => 8, "verloren" => 11),
    array("positie" => 7, "naam" => "Heracles",  "gespeelde" => 34, "gewonnen" => 15, "gelijk" => 3, "verloren" => 16),
    array("positie" => 8, "naam" => "Groningen", "gespeelde" => 34, "gewonnen" => 13, "gelijk" => 6, "verloren" => 15),
    array("positie" => 9, "naam" => "ADO", "gespeelde" => 34, "gewonnen" => 12, "gelijk" => 9, "verloren" => 13),
    array("positie" => 10, "naam" => "WillemII", "gespeelde" => 34, "gewonnen" => 13, "gelijk" => 5, "verloren" => 16),
    array("positie" => 11, "naam" => "Heerenveen",  "gespeelde" => 34, "gewonnen" => 10, "gelijk" => 11, "verloren" => 13),
    array("positie" => 12, "naam" => "VVV", "gespeelde" => 34, "gewonnen" => 11, "gelijk" => 8, "verloren" => 15),
    array("positie" => 13, "naam" => "PEC", "gespeelde" => 34, "gewonnen" => 11, "gelijk" => 5, "verloren" => 17),
    array("positie" => 14, "naam" => "Emmen", "gespeelde" => 34, "gewonnen" => 10, "gelijk" => 8, "verloren" => 16),
    array("positie" => 15, "naam" => "Fortuna",  "gespeelde" => 34, "gewonnen" => 9, "gelijk" => 7, "verloren" => 18),
    array("positie" => 16, "naam" => "Excelsior",  "gespeelde" => 34, "gewonnen" => 9, "gelijk" => 6, "verloren" => 19),
    array("positie" => 17, "naam" => "Graafschap", "gespeelde" => 34, "gewonnen" => 8, "gelijk" => 5, "verloren" => 21),
    array("positie" => 18, "naam" => "NAC",  "gespeelde" => 34, "gewonnen" => 5, "gelijk" => 8, "verloren" => 21),
);
array_walk_recursive($club, "printTracks");
function printTracks($club, $item)
{
    if ($item == "naam"){
        echo "<i><img width = 40px height = 40px src=\"clubs/".$club.".png\"/>"."</i>"."|";
    }
    print_r("$club<br>");
}


$arrayslie1 = array_slice($club, 0, 1  );
array_walk_recursive($arrayslice1, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 1, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 2, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice1 = array_slice($club, 3, 1);
array_walk_recursive($arrayslice1, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 4, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 5, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 6, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice1 = array_slice($club, 7, 1);
array_walk_recursive($arrayslice1, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 8, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 9, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 10, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice1 = array_slice($club, 11, 1);
array_walk_recursive($arrayslice1, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 12, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 13, 1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 14,  1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 15,  1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 16,  1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";
$arrayslice2 = array_slice($club, 17,  1);
array_walk_recursive($arrayslice2, "printTracks");
echo "<br>";

?>
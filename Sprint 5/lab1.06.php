<?php


$playlist = array (array("genre" => "Hiphop", "auteur" => "John Williams", "titel" => "My Girl"),
    array("genre" => "Jazz", "auteur" => "John Coltrane", "titel" => "New York"),
    array("genre" => "Hiphop", "auteur" => "Shakira", "titel" => "Obsession")
);
function printTracks($playlist){
    echo "<i> $playlist "."|"."</i>";
}
echo "<br>Track 0: ";
$arrayslice = array_slice($playlist, 0,1);
array_walk_recursive($arrayslice, "printTracks");
echo "<br>Track 1: ";
$arrayslice = array_slice($playlist, 1,1);
array_walk_recursive($arrayslice, "printTracks");
echo "<br>Track 2: ";
$arrayslice = array_slice($playlist, 2,2);
array_walk_recursive($arrayslice, "printTracks");
echo "<br>Track 3: ";
$newdata =  array (
    'genre' => 'latin',
    'auteur' => 'Caetano Veloso',
    'titel' => 'Cafe Atlantico'
);
array_push($playlist, $newdata);
$arrayslice = array_slice($playlist, 3,3);
array_walk_recursive($arrayslice, "printTracks");

?>
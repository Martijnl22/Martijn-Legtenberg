<?php
$user = array(
    "naam" => "Shyam",
    "e-mail" => "shyan@nu.nl",
    "wachtwoord" => "",
    "photo" => "shyan.jpg"
);
echo "<br> userArray<br>";
var_dump($user,true);
$userJsonString = json_encode($user);
echo "<br>userJsonLitral: <br>" .$userJsonString;

$boekenJsonLiteral = '[
{"titel":"Stoner","auteur":"John Williams",
"genre":"Fictie","prijs":19.99},
{"titel":"De cirkel","auteur":"Dave Eggers",
"genre":"Fictie","prijs":22.5},
{"titel":"Rayuela","auteur":"Julio Cortazat",
"genre":"Fictie","prijs":25.5}]';
$boeken = json_decode($boekenJsonLiteral,true);
foreach ($boeken as $boek){
    echo "<br>titel: ".$boek["titel"];
    echo "<br>auteur: ".$boek["auteur"];
    echo "<br>genre: ".$boek["genre"];
    echo "<br>prijs: ".$boek["prijs"];
}

echo "<b>------Opdracht 67";
$boeken0bj = json_decode($boekenJsonLiteral,true);
foreach ($boeken0bj as $boek){
    echo "<br>titel: ".$boek["titel"];
    echo "<br>auteur: ".$boek["auteur"];
    echo "<br>genre: ".$boek["genre"];
    echo "<br>prijs: ".$boek["prijs"];
?>
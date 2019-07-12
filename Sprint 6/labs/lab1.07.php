<?php
$boeken = array(
    array("titel" => "Stoner","auteur" => "John Williams",
        "genre" => "Fictie", "prijs" => 19.90),
    array("titel" => "De cirkel", "auteur" => "Dave Eggers",
        "genre" => "Fictie", "prijs" => 22.50),
    array("titel" => "Rayuela", "auteur" =>  "Cortázar",
        "genre" => "Fictie", "prijs" => 25.50)
);

array_walk($boeken, "prijslijst");

<!DOCTYPE html>
<html lang="nl">
<head>
    <meta http-equiv="Content-Type"
          content="text/html;
        charset=UTF-8" />
    <style>
        .album{clear: left; width: 100%;}
        .omslag{float: left;}
        .gegevens{float: left; padding-left: 20px;}
        .korting{clear: left;}
        .naam{background-color: #f8ce6c;}
    </style>
    <title>Mijn winkelmandje</title>
</head>
<body style="font-family: Verdana; font-size: 9px;">
<h3>Mijn winkelmandje</h3>
<form name="albums" action="" method="post">
    <div class="album">
        <div class="omslag">
            <img src="../evora.jpg" width="50px" alt="X" />
        </div>
        <div class="gegevens">
            Cesaria Evora "Em Um Concerto" prijs: $9
            <input type="hidden" name="albumcode[0]" value="001" >
            <input type="hidden" name="artiest[0]" value="Cesaria Evora " >
            <input type="hidden" name="album[0]" value="Em Um Concerto" >
            <input type="hidden" name="prijs[0]" value="9" >
            <input type="hidden" name="genre[0]" value="World" >
            <br />Aantal:
            <input type="text" size=2 maxlength=3 name="naam" class="naam" value="0" >
        </div>
    </div>
    <div class="korting">
        <br><hr />Korting:<br />
        <input type="checkbox" name="student" value="15" />
        Student: 15%<br />
        <input type="checkbox" name="klant" value="10" />
        Klant: 10%<br />
        <input type="submit" width="300px" name="submit" value=" Bestellen" />
    </div>
    <form name="order"
          action=""
          method="post">
        <p>Selecteer een betaalwijze:</p>
        <select name="land" value="true">
            <option value=""></option>
            <option value="vi">Vista</option>
            <option value="mc">MasterCard</option>
            <option value="pp">PayPal</option>
            <option value="id">Ideal</option>
            <input type="submit" width="300px" name="Verzenden" value=" Bestellen" />
        </select>
    </form>
</body>
</html>

<?php
$korting = 0;
if(isset($_POST["submit"])) {
    if (isset($_POST["student"]) && isset($_POST["klant"])) {
        $korting = $korting + 25;
    } elseif (isset($_POST["student"])) $korting = $korting + 15;
    elseif (isset($_POST["klant"])) $korting = $korting + 10;
    echo "Korting is: " . $korting . "%";
    $naam = $_POST["naam"];
    echo"<br> aantal is: " . $naam;
}
if (isset($_POST["verzenden"]))
{
    switch ($_POST["Verzenden"]) {
        case "vi" :
            echo "<p>U wilt betalen met Vista.</p>";
            break;
        case "mc" :
            echo "<p>U wilt betalen met MasterCard.</p>";
            break;
        case "pp" :
            echo "<p>U wilt betalen met PayPal.</p>";
            break;
        case "id" :
            echo "<p>U wilt betalen met Ideal.</p>";
            break;
        default:
            echo "<p>U heeft geen betaalwijze gekozen... S.V.P een betaalwijze selecteren!</p>";
    }
}
include_once("externe_functions.php");
echo "<br>De korting()-function: " .korting()."%";
$betalingswijze = $_POST['betalingswijze'];
$serviceKosten = servicekosten($betalingswijze);
echo"<br>Servicekosten zijn: " . $serviceKosten;
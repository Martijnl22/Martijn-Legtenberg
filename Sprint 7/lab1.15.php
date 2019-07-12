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
        .aantal{background-color: #f8ce6c;}
    </style>
    <title>Mijn winkelmandje</title>
</head>
<body style="font-family: Verdana; font-size: 9px;">
<h3>Mijn winkelmandje</h3>
<form name="albums" action="" method="post">
    <div class="album">
        <div class="omslag">
            <img src="img/evora.jpg" width="50px" alt="X" />
        </div>
        <div class="gegevens">
            Cesaria Evora "Em Um Concerto" prijs: $9
            <input type="hidden" name="albumcode[0]" value="001" >
            <input type="hidden" name="artiest[0]" value="Cesaria Evora " >
            <input type="hidden" name="album[0]" value="Em Um Concerto" >
            <input type="hidden" name="prijs[0]" value="9" >
            <input type="hidden" name="genre[0]" value="World" >
            <br />Aantal:
            <input type="text" size=2 maxlength=3 name="aantal" class="aantal" value="0" >
        </div>
        <div class="album">
            <div class="omslag">
                <img src="img/clandestino.jpg" width="50px" alt="X" />
            </div>
            <div class="gegevens">
                Manu Chao "Clandestino" prijs: $5
                <input type="hidden" name="albumcode[1]" value="002" >
                <input type="hidden" name="artiest[1]" value="Manu Chao" >
                <input type="hidden" name="album[1]" value="Clandestino" >
                <input type="hidden" name="prijs[1]" value="5" >
                <input type="hidden" name="genre[1]" value="World" >
                <br />Aantal:
                <input type="text" size=2 maxlength=3 name="aantal" class="aantal" value="0" >
            </div>
        </div>
        <div class="album">
            <div class="omslag">
                <img src="img/snelle.jpg" width="50px" alt="X" />
            </div>
            <div class="gegevens">
                Snelle "Beetje bij beetje" prijs: $20
                <input type="hidden" name="albumcode[2]" value="002" >
                <input type="hidden" name="artiest[2]" value="Snelle" >
                <input type="hidden" name="album[2]" value="Beetje bij beetje" >
                <input type="hidden" name="prijs[2]" value="20" >
                <input type="hidden" name="genre[2]" value="World" >
                <br />Aantal:
                <input type="text" size=2 maxlength=3 name="aantal" class="aantal" value="0" >
            </div>
        </div>
        <div class="korting">
            <br><hr />Korting:<br />
            <input type="checkbox" name="student" value="15" />
            Student: 15%<br />
            <input type="checkbox" name="klant" value="10" />
            Klant: 10%<br />
        </div>
        <form name="order"
              action=""
              method="post">
            <p>Selecteer een betaalwijze:</p>
            <select name="betaalmiddel" value="true">
                <option value=""></option>
                <option value="vi">Vista</option>
                <option value="mc">MasterCard</option>
                <option value="pp">PayPal</option>
                <option value="id">Ideal</option>
                <input type="submit" width="300px" name="Verzenden" value="Bestellen" />
            </select>
        </form>
</body>
</html>

<?php
if (isset($_POST["Verzeden"])) {
    $Aantal = $_POST["aantal"];
    $Korting = 0;
    if (isset($_POST["student"])) {
        $Korting = ($Korting + 15);
    }
    if (isset($_POST["klant"])) {
        $Korting = ($Korting + 10);
    }
    echo "<Br>Bestelde albums is: $Aantal";
    echo "<Br>Korting is: $Korting";
}
if(isset($_POST["Verzenden"])){
    include_once("externe_functions.php");
    echo "<br>De korting()-function: " . korting() . "%";
    $betalingswijze = $_POST['betaalmiddel'];
    $serviceKosten = serviceKosten($betalingswijze);
    echo "<br>Servicekosten zijn: " . $serviceKosten;
    switch ($_POST['betaalmiddel'])
    {
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

?>
<div>
    <br><hr /><h3>Factuur</h3><br/>
</div>
<body>
<form>
    <table>
        <tr class="aantal">
            <th>Genre</th>
            <th>Artiest</th>
            <th>Album</th>
            <th>Aantal</th>
            <th>Prijs</th>
            <th>Bedrag</th>
        </tr>
        <tr>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
        </tr>

        <tr>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
        </tr>
        <tr>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
        </tr>
        <tr>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
            <td>.</td>
        </tr>
        <tr>
            <td>Servicekosten</td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>.</td>
        </tr>
        <tr>
            <td>Te betalen</td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>.</td>
        </tr>


</body>

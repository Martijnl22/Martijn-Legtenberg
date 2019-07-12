<?php
ob_start();
echo "Maak een cookie";
setcookie("gebruiker", "Sanskriet", mktime(0,0,0,1,1,1,2050));
$gebruier = $_COOKIE["gebruiker"];
echo "<br>Gebruikersnaam is: $gebruier <br>";
print_r($_COOKIE);
ob_end_flush();
//cookies verwijderen
setcookie("user", "" ,time()-3600);
if (isset($_COOKIE["user"]))
{
    echo $_COOKIE["user"];
}else{
    echo "<br>Cookie is verwijdered.";
}
?>


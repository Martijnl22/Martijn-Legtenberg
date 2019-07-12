<?php
function korting()
{
    $korting = 0;
    if (isset($_POST['student'])) $korting = $korting + 15;
    if (isset($_POST['klant'])) $korting = $korting + 10;
    return ($korting);
}
function serviceKosten()
{
    $serviceKosten = 0;
    if ($_POST['betaalmiddel'] == 'vi') $serviceKosten = $serviceKosten = 2;
    if ($_POST['betaalmiddel'] == 'mc') $serviceKosten = $serviceKosten = 2.5;
    if ($_POST['betaalmiddel'] == 'pp') $serviceKosten = $serviceKosten = 1.5;
    if ($_POST['betaalmiddel'] == 'id') $serviceKosten = $serviceKosten = 1;
    return($serviceKosten);
}
function facturering()
{
    for ($x=0; $x < sizeof($_POST["albumcode"]); $x++) {}
}
?>


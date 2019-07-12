<!DOCTYPE html>
<html lang="nl">
<head>
    <meta http-equiv="Content-Type"
          content="text/html";
          charset="UFT-8" />
    <h4>Reiskosten berekenen </h4>
</head>
<body>
<form name="order"
      action=""
      method="post">
    <p>Vertrek</p>
    <select name="land" value="true">
        <option value="ad">Amsterdam</option>
        <option value="ut">Utrecht</option>
        <option value="dh">Den Haag</option>
        <option value="rd">Rotterdam</option>
    </select>
    <p>Bestemming</p>
    <select name="land" value="true">
        <option value="ad">Amsterdam</option>
        <option value="ut">Utrecht</option>
        <option value="dh">Den Haag</option>
        <option value="rd">Rotterdam</option>
    </select>
    <input type="submit" name="submit"
           value="Berekenen">
    <p>---------------------------------------------------</p>
</form>

<?php
function reiskosten($vertrek,$bestemming){
    $reiskosten = array();
    $reiskosten[1] = array();
    $reiskosten[2] = array();
    $reiskosten[3] = array();
    $reiskosten[4] = array();
    $reiskosten[1][1] = 0;
    $reiskosten[1][2] = 30;
    $reiskosten[1][3] = 60;
    $reiskosten[1][4] = 90;
    $reiskosten[2][1] = 30;
    $reiskosten[2][2] = 0;
    $reiskosten[2][3] = 40;
    $reiskosten[2][4] = 20;
    $reiskosten[3][1] = 60;
    $reiskosten[3][2] = 40;
    $reiskosten[3][3] = 0;
    $reiskosten[3][4] = 10;
    $reiskosten[4][1] = 90;
    $reiskosten[4][2] = 20;
    $reiskosten[4][3] = 10;
    $reiskosten[4][4] = 0;

    return($reiskosten[$vertrek][$bestemming]);




}
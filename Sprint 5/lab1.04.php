<h3>php lab 1.4</h3>
<?php
$naam = "Karim";
$nederlands = "8.5";
$engels = "7.7";
$rekenen = "6.7";
$progammeren = "8.5";
$databases = "9.4";
$gemiddeld = (($nederlands + $engels + $rekenen + $progammeren + $databases)/ 5);

$naam2 = "Sophie";
$nederlands2 = "8.9";
$engels2 = "8.7";
$rekenen2 = "9.5";
$progammeren2 = "9.5";
$databases2 = "9.2";
$gemiddeld2 = (($nederlands2 + $engels2 + $rekenen2 + $progammeren2 + $databases2)/ 5);

echo "<table border ='1'>
   <caption>
    <strong>Rapport</strong>
   </caption>
    <thead>
    <tr>
        <th>Naam</th><th>Nederlands</th><th>Engels</th><th>Rekenen</<th><th>Progammeren</th><th>Databases</th><th>Gemiddeld</th>
        </tr>
                <td>$naam</td><td>$nederlands</td><td>$engels</td><td>$rekenen</td><td>$progammeren</td><td>$databases</td><td>$gemiddeld</td> 
                 <tr></tr>   
                <td>$naam2</td><td>$nederlands2</td><td>$engels2</td><td>$rekenen2</td><td>$progammeren2</td><td>$databases2</td><td>$gemiddeld2</td> 
        </tr>
        </tbody>
        <tfoot>
            <tr>
                <td colspan='6'>Groep gemideld</td><td>------------</td>
             </tr>
           </tfoot>
        </table>";
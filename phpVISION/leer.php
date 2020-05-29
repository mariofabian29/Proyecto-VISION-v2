<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables
$apellido = $_REQUEST['ape'];


//pregunto si el id de usuario ya esta en la tabla
$IDexistente = mysqli_query($conect, "SELECT * FROM test WHERE lastName='$apellido' ");


//se obtienen todos los datos del usuario idUser
while($row = mysqli_fetch_array($IDexistente))
{
    $usuarioID = $row['id'];
    $usuarioIDuser = $row['IdUser_FK'];
    $usuarioNombre = $row['name'];
    $usuarioApellido = $row['lastName'];
    $usuarioEdad = $row['edad'];

    echo $usuarioNombre;


}



//http://tadeolabhack.com:8081/test/Datos/leer.php?ape=pso


?>


<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables
$NombreVISION = $_REQUEST['nombre'];
$LicenciaVISION = $_REQUEST['licencia'];


  //insertar Valores en la base de datos Bonotes
  $adicionarDatos = mysqli_query($conect, "INSERT INTO VISIONUsuarios(NombreVISION,LicenciaVISION) VALUES('$NombreVISION','$LicenciaVISION')");

  echo "adicionado";

  //$IDConexionTabla = mysqli_query($conect, "SELECT * FROM VISIONAcciones WHERE descripcion="'a')

//http://tadeolabhack.com:8081/test/Datos/phpVISION/escribir.php?nombre=Radamel&licencia=B1


?>


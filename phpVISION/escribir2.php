<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);
//s

//recibe los datos de unity, usamos el valor de estas variables
$idVISION = $_REQUEST['id'];
$Nivel = $_REQUEST['niv'];
$Errores = $_REQUEST['err'];

$IDConexionTabla = mysqli_query($conect, "SELECT * FROM VISIONAcciones WHERE idVISION_FK='$idVISION')

while($row = mysqli_fetch_array($IDexistente))
{
	$usuario = $row['idVISION_FK'];
    $NivelVIS = $row['NivelVISION'];
    $ErroresVIS = $row['ErroresVISION'];

}

if($usuario == $idVISION){
	$Sumar=$NivelVIS + 1;
	$actualizaBtn1 = mysqli_query($conect, "UPDATE VISIONAcciones SET NivelVISION=$Sumar  WHERE idVISION_FK='$usuario' ");

}

else{
	
  //insertar Valores en la base de datos Bonotes
  $adicionarDatos = mysqli_query($conect, "INSERT INTO VISIONAcciones(idVISION_FK,NivelVISION,ErroresVISION) VALUES('$idVISION','$Nivel','$Errores')");

  echo "adicionado";



}

  

//$IDConexionTabla = mysqli_query($conect, "SELECT * FROM VISIONAcciones WHERE descripcion="'a')

//http://tadeolabhack.com:8081/test/Datos/phpVISION/escribir2.php?nombre=Radamel&licencia=B1  INSERT Y UPDATE - VIDEO DEL OS BOTONES


?>


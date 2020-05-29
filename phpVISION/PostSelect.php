<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables
$userID = $_REQUEST['userID'];
$itemID = $_REQUEST['itemID'];


//pregunto si el id de usuario ya esta en la tabla
$IDexistente = mysqli_query($conect, "SELECT * FROM Botones WHERE idUser='$userID' ");


//se obtienen todos los datos del usuario idUser
while($row = mysqli_fetch_array($IDexistente))
{
	$usuario = $row['idUser'];
    $idSelect = $row['idSelect'];
    $boton1 = $row['btn1'];
	$boton2 = $row['btn2'];
	$boton3 = $row['btn3'];
	$boton4 = $row['btn4'];
}



//si no hay idSelect, significa que el usuario no existe
if($idSelect == null && $usuario != $userID)
{
	
	if($itemID == 1)
	{
		//en el php le adiciono +1 al btn1
		$variableBtn1 = 1;
	}
	else
	{
		$variableBtn1 = 0;
	}

	if($itemID == 2)
	{
		//en el php le adiciono +1 al btn2
		$variableBtn2 = 1;
	}
	else
	{
		$variableBtn2 = 0;
	}

	if($itemID == 3)
	{
		//en el php le adiciono +1 al btn3
		$variableBtn3 = 1;
	}
	else
	{
		$variableBtn3 = 0;
	}

	if($itemID == 4)
	{
		//en el php le adiciono +1 al btn4
		$variableBtn4 = 1;
	}
	else
	{
		$variableBtn4 = 0;
	}

	//insertar Valores en la base de datos Bonotes
	$adicionarDatos = mysqli_query($conect, "INSERT INTO Botones(idUser,btn1,btn2,btn3,btn4) VALUES('$userID','$variableBtn1','$variableBtn2','$variableBtn3','$variableBtn4')");

	echo "adicionado";
}
//si el id de usuario si esta en la tabla entonces cambie los valores 
else
{
	if($itemID == 1)
	{
		//en el php le adiciono +1 al btn1
		$variableBtn1 = $boton1+1;

		$actualizaBtn1 = mysqli_query($conect, "UPDATE Botones SET btn1=$variableBtn1  WHERE idUser='$userID' ");
	}	

	if($itemID == 2)
	{
		//en el php le adiciono +1 al btn2
		$variableBtn2 = $boton2+1;

		$actualizaBtn2 = mysqli_query($conect, "UPDATE Botones SET btn2=$variableBtn2  WHERE idUser='$userID' ");

	}

	if($itemID == 3)
	{
		//en el php le adiciono +1 al btn3
		$variableBtn3 = $boton3+1;

		$actualizaBtn3 = mysqli_query($conect, "UPDATE Botones SET btn3=$variableBtn3  WHERE idUser='$userID' ");
	}

	if($itemID == 4)
	{
		//en el php le adiciono +1 al btn4
		$variableBtn4 = $boton4+1;

		$actualizaBtn4 = mysqli_query($conect, "UPDATE Botones SET btn4=$variableBtn4  WHERE idUser='$userID' ");
	}


	echo "cambiado";

}







//http://tadeolabhack.com:8081/test/Datos/PostSelect.php?userID=0&itemID=2




?>


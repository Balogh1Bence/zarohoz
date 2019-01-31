<?php
require_once("connect.php");
if (isset($_GET['q'])){
	$sql = "SELECT * FROM person";
	$res = $connect -> query($sql);
	$table = "<table><tr><th>Sorszám</th><th>Vezetéknév</th><th>Keresztnév</th><th>művelet</th></tr>";
	$number=1;
	if ($res){
		while ($row = $res -> fetch_assoc()){
			$table .= "<tr> <td>{$number}</td><td>{$row['veznev']} </td> <td>{$row['kernev']} </td> <td><button id='{$row['ID']}' onclick = 'delet(this.id)' data-id='{$row['ID']}' ><font size='5px'>
			&#128465;
			</font></button></td></tr>";
			$number++;
		}
		$table .= "<tr><td> </td><td id = 'vnev' contenteditable> </td><td id = 'knev' contenteditable> </td><td><button id='save' onclick='save()' >+</button> </td></tr></table>";
		
		
	}
	echo $table;
}

$connect -> close();
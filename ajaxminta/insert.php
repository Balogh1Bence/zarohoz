<?php
require_once("connect.php");

if(isset($_GET['vnev']))
{
		$vnev=$_GET['vnev'];
		$knev=$_GET['knev'];
		$sql="insert into person(veznev, kernev) values ('$vnev', '$knev')";
		$connect->query($sql);
}

$connect -> close();

<?php
require_once("connect.php");
if(isset($_GET['id']))
{
	$id=$_GET['id'];
	$sql="delete FROM person WHERE ID='$id'";
$connect->query($sql);
echo $id;
echo "jo";
}

$connect -> close();



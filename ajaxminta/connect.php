<?php
$host = "localhost";
$user = "root";
$pwd = "";
$db = "ajax";
$port = 3306;

$connect = new mysqli($host, $user, $pwd, $db, $port);

if ($connect -> connect_error){
	die("Sikertelen csatlakozás!");
}

$connect -> set_charset("utf8");
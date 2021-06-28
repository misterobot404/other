<?php require "bd.php";
unset($_SESSION['logged_user']);
header("Location: ".$_SERVER['HTTP_REFERER']);
?>
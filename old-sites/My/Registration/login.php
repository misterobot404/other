<?php require "../defolt/defolthead.php";?>

<h2>Авторизация</h2>
<hr class="line">
<?php
$data = $_POST;
if(isset($data['do_login']))
{
	$errors=array();
	$user = R::findOne('users', 'login = ?', array($data['login']
));
	if($user)
	{
			//логин существует
		if(password_verify($data['password'],$user->password))
		{
				//всё хорошо, логиним пользователя
			$_SESSION['logged_user'] = $user;
			$_SESSION['Monitors'] = 0;
			$_SESSION['Netbooks'] = 0;
			$_SESSION['Sistem_block'] = 0;
			$_SESSION['Accessories'] = 0;
			header('Location:../Main/Main.php');
		} else
		{			$errors[] = 'Пароль введён не правильно!';
	}
} else
{
	$errors[] = 'Пользователь с таким логином не найден!';
}
}
?>
<form action="login.php" method="POST">
	<?php 
	if( ! empty($errors))
	{
		echo '<div class="error"><img src="../images/errorimg.png">'.array_shift($errors).'</div>';
	}
	?>
	<p><strong>Логин</strong>:</p>
	<input type="text" name="login" value="<?php echo @$data["login"];?>">
	<p><strong>Пароль</strong>:</p>
	<input type="password" name="password" value="<?php echo @$data["password"];?>">
	<p><button type="sumbit" name="do_login">Войти</button></p>
</form>

<?php require "../defolt/defoltfooter.php";?>




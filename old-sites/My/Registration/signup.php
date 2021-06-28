<?php require "../defolt/defolthead.php";?>

<?php
$data = $_POST;
if(isset($data['do_signup']))
{
	$errors=array();
		//здась регистрируем
	if(trim($data['login'])=='')
	{
		$errors[]='Введите логин!';
	}
	if(trim($data['name'])=='')
	{
		$errors[]='Введите имя!';
	}

	if(trim($data['number'])=='')
	{
		$errors[]='Введите номер!';
	}
	if(trim($data['Email'])=='')
	{
		$errors[]='Введите Email!';
	}

	if($data['password']=='')
	{
		$errors[]='Введите пароль!';
	}

	if($data['password_2']!=$data['password'])
	{
		$errors[]='Повторный пароль введён неверно!';
	}
	if( R::count('users',"login = ?", array($data['login']))
		> 0)
	{
		$errors[] = 'Пользователь с таким логином уже существует!';
	}
	if( R::count('users',"number = ?", array($data['number']))
		> 0)
	{
		$errors[] = 'Пользователь с таким номером телефона уже существует!';
	}
	if( R::count('users',"_email = ?", array($data['Email']))
		> 0)
	{
		$errors[] = 'Пользователь с таким Email уже существует!';
	}
	if(empty($errors))
	{
		//REGESTRISION
		$user = R::dispense('users');
		$user->name=$data['name'];
		$user->number=$data['number'];
		$user->login=$data['login'];
		$user->Email=$data['Email'];
		$user->password = password_hash($data['password'],PASSWORD_DEFAULT);
		R::store($user);
		?>
		<div id="block_my_room1">
			Вы успешно зарегестрировались!<button type="sumbit" class="button-window1" onclick="toggle(block_my_room1)">OK</button>
		</div>
		<script>
			function toggle(el) {
				el.style.display = (el.style.display == 'none') ? '' : 'none'
			}
		</script>
		<?php
	}
}
?>

<h2>Регистрация нового пользователя</h2>
<hr class="line">
<form action="signup.php" method="POST">
	<p>
		<?php 
		if( ! empty($errors))
		{
			echo '<div class="error"><img src="../images/errorimg.png">'.array_shift($errors).'</div>';
		}
		?>
		<p><strong>Ваш Логин</strong>:</p>
		<input type="text" name="login" value="<?php echo @$data["login"];?>">
	</p>
	<p><strong>Ваше Имя</strong>:</p>
	<input type="name" name="name" value="<?php echo @$data["name"];?>">
</p>
<p><strong>Ваш номер</strong>:</p>
<input type="number" name="number" value="<?php echo @$data["number"];?>">
</p>
<p>
	<p><strong>Email</strong>:</p>
	<input type="Email" name="Email" value="<?php echo @$data["Email"];?>">
</p>
<p>
	<p><strong>Ваш пароль</strong>:</p>
	<input type="password" name="password" value="<?php echo @$data["password"];?>">
</p>
<p>
	<p><strong>Повторите пароль</strong>:</p>
	<input type="password" name="password_2" value="<?php echo @$data["password_2"];?>">
</p>
<p>
	<button type="sumbit" name="do_signup">Зарегистрироваться</button>
</p>
</form>

<?php require "../defolt/defoltfooter.php";?>

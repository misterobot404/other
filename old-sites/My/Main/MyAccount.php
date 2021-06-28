<?php require "../defolt/defolthead.php";?>

<?php
$data = $_POST;
if(isset($data['do_login']))
{
	$errors=array();
	$user = R::load('users', $_SESSION['logged_user']->id);
	if(password_verify($data['password'],$user->password))
	{
		$name = R::load('users', $_SESSION['logged_user']->id);
		$name->password=password_hash($data["password_new"],PASSWORD_DEFAULT);
		R::store($name);
	} else
	{			
		$errors[] = 'Старый пароль введён не правильно!';
	}
}
?>

<h2 id="privat-room">Личный кабинет</h2>
<button type="sumbit" class="button-edit" onclick="toggle(redact_password)">Изменить пароль</button>
<button type="sumbit" class="button-edit" onclick="window.location.href='Basket.php'">Корзина</button>
<?php if(!empty($errors)): ?>			
	<div id="redact_password" style="text-align: center;">
	<?php else: ?>
		<div id="redact_password" style="display: none;">
		<?php endif; ?>
		<?php 
		if(!empty($errors))
		{
			echo '<div class="error"><img src="../images/errorimg.png">'.array_shift($errors).'</div>';
		}
		?>
		<form action="MyAccount.php" method="POST">
			<?php 
			if(!empty($errors))
			{
				echo '<div class="error"><img src="../images/errorimg.png">'.array_shift($errors).'</div>';
			}
			?>
			<p><strong>Старый пароль</strong>:</p>
			<input type="text" name="password" value="<?php echo @$data["password"];?>">
			<p><strong>Новый пароль</strong>:</p>
			<input type="text" name="password_new" value="<?php echo @$data["password_new"];?>">
			<p><button type="sumbit" name="do_login">Изменить</button></p>
		</form>
	</div>
	<hr class="line">
	<table class="privat-room-output">
		<tr>
			<td><strong>Ваш логин</strong></td>
			<td>
				<?php
				echo $_SESSION['logged_user']->login;
				?>
			</td>
		</tr>
		<tr>
			<td><strong>Ваше Имя</strong></td>
			<td>
				<?php
				echo $_SESSION['logged_user']->name;
				?>
			</td>
		</tr>
		<tr>
			<td><strong>Ваш номер телефона</strong></td>
			<td>
				<?php
				echo $_SESSION['logged_user']->number;
				?>
			</td>
		</tr>
		<tr>
			<td><strong>Ваш Email</strong></td>
			<td>
				<?php
				echo $_SESSION['logged_user']->Email;
				?>
			</td>
		</tr>
	</table>

	<?php require "../defolt/defoltfooter.php";?>
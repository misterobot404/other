<?php require"../Registration/bd.php";?>

<title>FaSociety</title>
<link rel="shortcut icon" type="image/x-icom" href="../images/icon.png">
<link rel="stylesheet" href="../Main/stile.css"  media="all">
<script src="../js/jquery-1.11.3.min.js" type="text/javascript" defer></script>
<script src="../js/slider.js" type="text/javascript" defer></script>

<div class="userpanel">
	<?php
	if(isset($_SESSION['logged_user']) ) :?>
	<strong>Привет, <?php echo $_SESSION['logged_user']->login; ?></strong>
	<br>
	<?php if (($_SESSION['logged_user']->login)=="GOD")
	{
		?>
		<div class="GOD" onclick="window.location.href='GOD.php'">JOB<br> FOR<br> GOD</div>
		<?php
	};
	?>
	<?php if (($_SESSION['logged_user']->login)=="COURIER" or ($_SESSION['logged_user']->login)=="COURIER2" or ($_SESSION['logged_user']->login=="COURIER3"))
	{
		?>
		<div class="GOD" onclick="window.location.href='COURIER.php'">JOB<br> FOR<br> COURIER</div>
		<?php
	};?>
	<a href="../Registration/logout.php">Выйти</a>
<?php else : ?>
	<a href="../Registration/signup.php">Регистрация</a> |
	<a href="../Registration/login.php">Войти</a>
<?php endif; ?>
</div>
<div class="sitename">
	FaSociety!
</div>
<div class="clear" ></div>
<div class="menu">
	<nav>
		<ul>
			<li><a href="../Main/Main.php">Главная</a></li>
			<?php	if(isset($_SESSION['logged_user']) ) : ?>
				<li><a href="../Main/MyAccount.php">Личный кабинет</a></li>
			<?php else : ?>
				<li><a onclick="toggle(block_my_room)">Личный кабинет</a></li>
				<div id="block_my_room" style="display: none;">
					<img src="../images/blue.png">Что бы получить доступ в личный кабинет, необходимо <a href="../Registration/login.php">авторизоваться</a>!<button type="sumbit" class="button-window" onclick="toggle(block_my_room)">OK</button>
				</div>
			<?php endif; ?>
			<li style="margin-right: 110px;"><a href="../Main/AboutUs.php">О нас</a></li>
		</ul>
	</nav>
</div>

<div class="content">
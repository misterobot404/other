<?php require "bd.php";?>

<title>Bellissimo</title>
<link rel="stylesheet" type="text/css" href="style.css">
<link rel="stylesheet" href="slideshow.css">
<script>
	function toggle(el) {
		el.style.display = (el.style.display == 'none') ? '' : 'none'}
	</script>

	<?php 
	$data = $_POST;
	$admin["login"]="lizok";
	$admin["password"]="123";
	if(isset($data['do_login']))
	{
		$errors=array();
		if($data["login"]==$admin["login"])
		{
			//логин совпадает
			if($data["password"]==$admin["password"])
			{
				//всё хорошо, логиним пользователя
				$_SESSION['logged_user'] = $admin["login"];
			} else
			{			$errors[] = 'Пароль введён не правильно!';
		}
	} else
	{
		$errors[] = 'Пользователь с таким логином не найден!';
	}
}
?>

<?php
function upload_file($file, $upload_dir= 'images', $allowed_types= array('image/png','image/x-png','image/jpeg','image/webp','image/gif')){

  $blacklist = array(".php", ".phtml", ".php3", ".php4");
  $ext = substr($filename, strrpos($filename,'.'), strlen($filename)-1); // В переменную $ext заносим расширение загруженного файла.
  if(in_array($ext,$blacklist )){
    return array('error' => 'Запрещено загружать исполняемые файлы');}

  $upload_dir = dirname(__FILE__).DIRECTORY_SEPARATOR.$upload_dir.DIRECTORY_SEPARATOR; // Место, куда будут загружаться файлы.
  $max_filesize = 8388608; // Максимальный размер загружаемого файла в байтах (в данном случае он равен 8 Мб).
  $prefix = date('Ymd-is_');
  $filename = $file['name']; // В переменную $filename заносим точное имя файла.

  if(!is_writable($upload_dir))  // Проверяем, доступна ли на запись папка, определенная нами под загрузку файлов.
    return array('error' => 'Невозможно загрузить файл в папку "'.$upload_dir.'". Установите права доступа - 777.');

  if(!in_array($file['type'], $allowed_types))
    return array('error' => 'Данный тип файла не поддерживается.');

  if(filesize($file['tmp_name']) > $max_filesize)
    return array('error' => 'файл слишком большой. максимальный размер '.intval($max_filesize/(1024*1024)).'мб');

  if(!move_uploaded_file($file['tmp_name'],$upload_dir.$prefix.$filename)) // Загружаем файл в указанную папку.
    return array('error' => 'При загрузке возникли ошибки. Попробуйте ещё раз.');

    return Array('filename' => $prefix.$filename);
}
?>

<div class="blok-menu">
	<ul class="menu">
		<li><a href="index.php">Что такое Bellissimo</a></li>
		<li><a href="Menu.php">Меню</a></li>
		<li><a href="Adresacia.php">Адресация</a></li>
		<li><a href="Akcii.php">Акции</a></li>
	</ul>
</div>
	<?php if(isset($_SESSION['logged_user'])) :?>
		<div class="avtor">
		<div class="logo"><img src="image/logo.png" >
		<div id="test"><strong>Привет, <?php echo $_SESSION['logged_user']; ?></strong><a href="logout.php">Выйти</a></div>
			</div>
		</div>
	<?php else : ?>
		<div class="avtor">
			<p><div class="logo" style="padding-left: 70px;"><img src="image/logo.png" align="middle"  ><a onclick="toggle(redact_password)">Авторизация</a></p>
				<?php	if(!empty($errors)) :?>
					<div id="redact_password" style="display: block;">
					<?php else : ?>
						<div id="redact_password" style="display: none;">
						<?php endif; ?>
						<?php 
						if(!empty($errors))
						{
							echo '<div class="error"><img src="../images/errorimg.png">'.array_shift($errors).'</div>';
						}
						?>
						<form method="POST">
							<p><strong>Логин</strong>:</p>
							<input type="text" name="login" value="<?php echo @$data["login"];?>">
							<p><strong>Пароль</strong>:</p>
							<input type="password" name="password" value="<?php echo @$data["password"];?>">
							<p><button type="sumbit" name="do_login">Войти</button></p>
						</form>
					</div>
				</div>
			<?php endif; ?>
		</div>
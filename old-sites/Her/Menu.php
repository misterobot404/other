<?php include "defolthead.php" ?>

<!--Сохранение картинки*/-->
<?php 
$path = 'images/'; // директория для загрузки
$ext = array_pop(explode('.',$_FILES['myfile']['name'])); // расширение
$new_name = time().'.'.$ext; // новое имя с расширением
$full_path = $path.$new_name; // полный путь с новым именем и расширением
if($_FILES['myfile']['error'] == 0){
	move_uploaded_file($_FILES['myfile']['tmp_name'], $full_path);
}
?>

<!--Удаление блюд из базы данных*/-->
<?php
$data = $_POST;
if(isset($data['do_delet']))
{
	if ($data["type"]=="Первые блюда")
	{
		$ord = R::findOne('first', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Вторые блюда")
	{
		$ord = R::findOne('double', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Десерты")
	{
		$ord = R::findOne('dessert', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Пиццы")
	{
		$ord = R::findOne('dessert', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Напитки")
	{
		$ord = R::findOne('drink', "`name`=?", array($data['name']));
	}
	if(isset($ord))
	{
		R::trash($ord);
	}
}
?>

<!--Регистрация блюд в базе данных*/-->
<?php
$data = $_POST;
if(isset($data['do_item']))
{
	if ($data["type"]=="Первые блюда")
	{
		$save=R::dispense('first');
	}
	if ($data["type"]=="Вторые блюда")
	{
		$save=R::dispense('double');
	}
	if ($data["type"]=="Десерты")
	{
		$save=R::dispense('dessert');
	}
	if ($data["type"]=="Пиццы")
	{
		$save=R::dispense('pizza');
	}
	if ($data["type"]=="Напитки")
	{
		$save=R::dispense('drink');
	}
	$save->images=$full_path;
	$save->name=$data['name'];
	$save->composition=$data['composition'];
	R::store($save);
}
?>

<!--Изменение блюд в базе данных-->
<?php
$data = $_POST;
if(isset($data['redact_price']))
{
	if ($data["type"]=="Первые блюда")
	{
		$ord = R::findOne('first', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Вторые блюда")
	{
		$ord = R::findOne('double', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Десерты")
	{
		$ord = R::findOne('dessert', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Пиццы")
	{
		$ord = R::findOne('pizza', "`name`=?", array($data['name']));
	}
	if ($data["type"]=="Напитки")
	{
		$ord = R::findOne('drink', "`name`=?", array($data['name']));
	}
	if(isset($ord))
	{
		$ord->name=$data['new_name'];
		$ord->composition=$data['new_composition'];
		R::store($ord);
	}
}
?>

<!--Вывод формы для удаления блюд-->
<?php
if($_SESSION['logged_user'])
{
	?>
	<div class="GOD" style="bottom: 140px;left: 13.38%;" onclick="toggle(delet_price)">Удалить блюдо</div>
	<?php
}
?>

<!--Вывод формы для изменения блюд-->
<?php
if($_SESSION['logged_user'])
{
	?>
	<div class="GOD" style="bottom: 18px"; onclick="toggle(redact_price)">Изменить блюдо</div>
	<?php
}
?>

<!--Вывод формы для добавления блюд-->
<?php
if($_SESSION['logged_user'])
{
	?>
	<div class="GOD" style="left: 13.05%;" onclick="toggle(add_price)">Добавить блюдо</div>
	<?php
}
?>

<!--Форма удаления блюда-->
<div id="delet_price" style="display: none;">
	<form method="POST">
		<p><strong>Категирия блюда</strong>:</p>
		<p><select name="type" value="<?php echo @$data["type"];?>">
			<option selected>Первые блюда</option>
			<option>Вторые блюда</option>
			<option>Десерты</option>
			<option>Пиццы</option>
			<option>Напитки</option>
		</select></p>
		<p><strong>Название блюда</strong>:</p>
		<input type="text" name="name" value="<?php echo @$data["name"];?>">
		<p><button type="sumbit" name="do_delet">Удалить</button></p>
	</form>
</div>

<!--Форма добавления блюд-->
<div id="add_price" style="display: none;">
	<form method="POST" enctype="multipart/form-data">
		<p><strong>Категирия блюда</strong>:</p>
		<p><select name="type" value="<?php echo @$data["type"];?>">
			<option selected>Первые блюда</option>
			<option>Вторые блюда</option>
			<option>Десерты</option>
			<option>Пиццы</option>
			<option>Напитки</option>
		</select></p>
		<p><input type="file" name="myfile" id="myfile"></p>
		<p><strong>Название блюда</strong>:</p>
		<input type="text" name="name" value="<?php echo @$data["name"];?>">
		<p><strong>Состав блюда</strong>:</p>
		<input type="text" name="composition" value="<?php echo @$data["composition"];?>">
		<p><button type="sumbit" name="do_item">Добавить</button></p>
	</form>
</div>

<!--Форма изменения блюд-->
<div id="redact_price" style="display: none;">
	<form method="POST" enctype="multipart/form-data">
		<p><strong>Категирия блюда</strong>:</p>
		<p><select name="type" value="<?php echo @$data["type"];?>">
			<option selected>Первые блюда</option>
			<option>Вторые блюда</option>
			<option>Десерты</option>
			<option>Пиццы</option>
			<option>Напитки</option>
		</select></p>
		<p><strong>Название блюда</strong>:</p>
		<input type="text" name="name" value="<?php echo @$data["name"];?>">
		<p><strong>Новое название</strong>:</p>
		<input type="text" name="new_name" value="<?php echo @$data["new_name"];?>">
		<p><strong>Новое описание</strong>:</p>
		<input type="text" name="new_composition" value="<?php echo @$data["new_composition"];?>">
		<p><button type="sumbit" name="redact_price">Изменить</button></p>
	</form>
</div>


<div class="content1">
	<div class="menu2">
		<ul>
			<li><a href="#pervie">Первые блюда</a></li>
			<li><a href="#vtorie">Вторые блюда</a></li>
			<li><a href="#deserti">Десерты</a></li>
			<li><a href="#picci">Пиццы</a></li>
			<li><a href="#napitki">Напитки</a></li>
		</ul>
		<a href="#" title="Вернуться к началу" class="topbutton">^Наверх</a>


		<h2><a name="pervie">Первые блюда</a></h2>
		<!--Вывод всех блюд-->
		<div class="cartinki">
			<?php
			$order=R::findAll('first');
			if($order)
			{
				foreach ($order as $value)
				{
					?>
					<figure class="sign">
						<p><? echo "<img src = \"".$value['images']."\"width=200px; height=190px;>";?></p>
						<figcaption><h1><?echo $value['name'];?></h1>
							<? echo $value['composition']; ?>
						</figcaption>
					</figure>
					<?
				}
			}
			?>
		</div>
		

		<h2 style="clear: left"><a name="vtorie">Вторые блюда</a></h2>
		<div class="cartinki">
			<?php
			$order=R::findAll('double');
			if($order)
			{
				foreach ($order as $value)
				{
					?>
					<figure class="sign">
						<p><? echo "<img src = \"".$value['images']."\"width=200px; height=190px;>";?></p>
						<figcaption><h1><?echo $value['name'];?></h1>
							<? echo $value['composition']; ?>
						</figcaption>
					</figure>
					<?
				}
			}
			?>
		</div>


		<h2 style="clear: left"><a name="deserti">Десерты</a></h2> 
		<div class="cartinki">
			<?php
			$order=R::findAll('dessert');
			if($order)
			{
				foreach ($order as $value)
				{
					?>
					<figure class="sign">
						<p><? echo "<img src = \"".$value['images']."\"width=200px; height=190px;>";?></p>
						<figcaption><h1><?echo $value['name'];?></h1>
							<? echo $value['composition']; ?>
						</figcaption>
					</figure>
					<?
				}
			}
			?>
		</div>


		<h2 style="clear: left"><a name="picci">Пиццы</a></h2>
		<div class="cartinki">
			<?php
			$order=R::findAll('pizza');
			if($order)
			{
				foreach ($order as $value)
				{
					?>
					<figure class="sign">
						<p><? echo "<img src = \"".$value['images']."\"width=200px; height=190px;>";?></p>
						<figcaption><h1><?echo $value['name'];?></h1>
							<? echo $value['composition']; ?>
						</figcaption>
					</figure>
					<?
				}
			}
			?>
		</div>


		<h2 style="clear: left"><a name="napitki">Напитки</a></h2>
		<div class="cartinki">
			<?php
			$order=R::findAll('drink');
			if($order)
			{
				foreach ($order as $value)
				{
					?>
					<figure class="sign">
						<p><? echo "<img src = \"".$value['images']."\"width=200px; height=190px;>";?></p>
						<figcaption><h1><?echo $value['name'];?></h1>
							<? echo $value['composition']; ?>
						</figcaption>
					</figure>
					<?
				}
			}
			?>
		</div>


	</div>
</div>
<?php include "defoltfooter.php" ?>
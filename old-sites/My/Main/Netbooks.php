<?php require "../defolt/defolthead.php";?>

<?php 
if($_POST)
{	
	$_SESSION['Netbooks']=157990;
	?>
	<div id="block_my_room1">
		Товар добавлен в корзину!<button type="sumbit" class="button-window1" onclick="toggle(block_my_room1)">OK</button>
	</div>
	<?php 
}
?>

<h2>Мониторы</h2>
<hr class="line">
<div class="item">
	<div class="item-content">
		<div class="item-content-text">
			<img src="../images/ASUS1.jpg" id="item-content-text-images">
			<div class="item-content-text-text">
				<h3>15.4" Ноутбук Apple MacBook Pro Retina TB (MPTU2RU/A) серебристый</h3>
				<span>[2880х1800, IPS, Intel Core i7 7700HQ, 4x2.8 ГГц, RAM 16 ГБ, SSD 256 Гб, AMD Radeon Pro 555]</span>
			</div>
		</div>
		<div class="item-content-price">
			<span id="rub">157 990</span><span id="rubsumbol">₽</span>
		</div>	
		<?php	if(isset($_SESSION['logged_user']) ) : ?>
			<form method="POST">
				<button class="item-content-pay" type="sumbit" name="Netbooks++">В корзину</button>
			</form>
		<?php else : ?>
			<button class="item-content-pay" type="sumbit" onclick="toggle(block_my_room3)">В корзину</button>
			<div id="block_my_room3" style="display: none;">
				<img src="../images/blue.png">Что бы получить доступ к корзине, <span style="margin-left: 17px;">необходимо <a href="../Registration/login.php">авторизоваться</a>!</span><button type="sumbit" class="button-window" onclick="toggle(block_my_room3)">OK</button>
			</div>
		<?php endif; ?>
	</div>
</div>

<?php require "../defolt/defoltfooter.php";?>
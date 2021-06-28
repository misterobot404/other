<?php require "../defolt/defolthead.php";?>

<?php 
if($_POST)
{	
	$_SESSION['Sistem_block']=340200;
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
					<img src="../images/SB.jpg" id="item-content-text-images">
					<div class="item-content-text-text">
					<h3 style="margin-top: 16px;">Рабочая станция Dell Precision T5810-0224 [5810-0224]</h3>
					<span>[2880х1800, IPS, Intel Core i7 7700HQ, 4x2.8 ГГц, RAM 16 ГБ, SSD 256 Гб, AMD Radeon Pro 555]</span>
				</div>
			</div>
			<div class="item-content-price">
				<span id="rub">340 200</span><span id="rubsumbol">₽</span>
			</div>	
	<?php	if(isset($_SESSION['logged_user']) ) : ?>
			<form method="POST">
				<button class="item-content-pay" type="sumbit" name="Sistem_block++">В корзину</button>
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
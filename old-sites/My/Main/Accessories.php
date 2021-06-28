<?php require "../defolt/defolthead.php";?>

<?php
if($_POST)
{	
	$_SESSION['Accessories']=100800;
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
			<img src="../images/Complect2.jpg" id="item-content-text-images">
			<div class="item-content-text-text">
				<h3 style="margin-top: 16px;">Оперативная память Corsair Vengeance RGB [CMR16GX4M2C3000C15] 16 ГБ</h3>
				<span>[DDR3, 8 ГБx2, 1600 МГц, PC12800, 10-10-10-30]</span>
			</div>
		</div>
		<div class="item-content-price">
			<span id="rub">100 800</span><span id="rubsumbol">₽</span>
		</div>
		<?php	if(isset($_SESSION['logged_user']) ) : ?>
			<form method="POST">
				<button class="item-content-pay" type="sumbit" name="Accessories++">В корзину</button>
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
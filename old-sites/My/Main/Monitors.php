<?php require "../defolt/defolthead.php";?>

<?php 
if($_POST)
{	
	$_SESSION['Monitors']=114550;
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
			<img src="../images/ASUS_M.png" id="item-content-text-images">
			<div class="item-content-text-text">
				<h3>31.5" Монитор ASUS ProArt PA329Q [90LM02CC-B01370]</h3>
				<span>[3440x1440@100 Гц, IPS, 5 мс, 1000:1, 300 кд/м2, 178°/178°, HDMI, DisplayPort, USB х2, NVIDIA G-SYNC]</span>
			</div>
		</div>
		<div class="item-content-price">
			<span id="rub">114 550</span><span id="rubsumbol">₽</span>
		</div>
		<?php	if(isset($_SESSION['logged_user']) ) : ?>
			<form method="POST">
				<button class="item-content-pay" type="sumbit" name="Monitors++">В корзину</button>
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

<?php require "../defolt/defolthead.php";?>

<?php
$summ=$_SESSION['Monitors']+$_SESSION['Netbooks']+$_SESSION['Sistem_block']+$_SESSION['Accessories'];
$data = $_POST;
if($_POST)
{	
	$order = R::dispense('order');
	$order->address=$data['address'];
	$order->data=$data['data'];
	$order->courier="?";
	R::store($order);
	$_SESSION['Monitors']=0;
	$_SESSION['Netbooks']=0;
	$_SESSION['Sistem_block']=0;
	$_SESSION['Accessories']=0;
	?>
	<div id="block_my_room1">
		Ожидайте заказа!<button type="sumbit" class="button-window1" onclick="toggle(block_my_room1)">OK</button>
	</div>
	<?php 
}
?>

<h2 id="privat-room">Корзина</h2>
<?php if (($_SESSION['Monitors']) or ($_SESSION['Netbooks']) or ($_SESSION['Sistem_block']) or ($_SESSION['Accessories'])) :?>
	<button type="sumbit" class="button-edit" onclick="toggle(redact_password)">Оформить заказ</button>
	<div id="redact_password" style="display: none;">
		<form action="Basket.php" method="POST">
			<p>	
				<div class="money-block-text" style="color: #3B3B3B;">
					Итоговая сумма:
				</div>
				<div class="item-content-price1" style="color: #3B3B3B; padding-bottom: 15px;">
					<span id="rub" ><?php echo $summ?></span><span id="rubsumbol">₽</span>
				</div></p>
				<p><strong>Введите адрес</strong>:</p>
				<input type="text" name="address" value="<?php echo @$data["address"];?>">
				<p><strong>Введите дату</strong>:</p>
				<input type="text" name="data" value="<?php echo @$data["data"];?>">
				<p><button type="sumbit" name="do_login">Заказать!</button></p>
			</form>
		</div>
	<?php endif; ?>
	<hr class="line">
	<?php if (!($_SESSION['Monitors']) and !($_SESSION['Netbooks']) and !($_SESSION['Sistem_block']) and !($_SESSION['Accessories'])) :?>
		<div class="empty-message">
			<div class="cart-image"></div>
			<h3>Ваша корзина пуста</h3>
		</div>
	<?php endif; ?>
	<?php if($_SESSION['Monitors']) :?>
		<div class="item">
			<div class="item-content">
				<div class="item-content-text">
					<img src="../images/ASUS_M.png" id="item-content-text-images">
					<div class="item-content-text-text">
						<h3>31.5" Монитор ASUS ProArt PA329Q [90LM02CC-B01370]</h3>
						<span>[3440x1440@100 Гц, IPS, 5 мс, 1000:1, 300 кд/м2, 178°/178°, HDMI, DisplayPort, USB х2, NVIDIA G-SYNC]</span>
					</div>
				</div>
				<div class="item-content-price" style="padding-top: 40px;">
					<span id="rub">114 550</span><span id="rubsumbol">₽</span>
				</div>
			</div>
		</div>
	<?php endif; ?>
	<?php if($_SESSION['Netbooks']) :?>
		<div class="item">
			<div class="item-content">
				<div class="item-content-text">
					<img src="../images/ASUS1.jpg" id="item-content-text-images">
					<div class="item-content-text-text">
						<h3>15.4" Ноутбук Apple MacBook Pro Retina TB (MPTU2RU/A) серебристый</h3>
						<span>[2880х1800, IPS, Intel Core i7 7700HQ, 4x2.8 ГГц, RAM 16 ГБ, SSD 256 Гб, AMD Radeon Pro 555]</span>
					</div>
				</div>
				<div class="item-content-price" style="padding-top: 40px;">
					<span id="rub">157 990</span><span id="rubsumbol">₽</span>
				</div>	
			</div>
		</div>
	<?php endif; ?>
	<?php if($_SESSION['Sistem_block']) :?>
		<div class="item">
			<div class="item-content">
				<div class="item-content-text">
					<img src="../images/SB.jpg" id="item-content-text-images">
					<div class="item-content-text-text">
						<h3 style="margin-top: 16px;">Рабочая станция Dell Precision T5810-0224 [5810-0224]</h3>
						<span>[2880х1800, IPS, Intel Core i7 7700HQ, 4x2.8 ГГц, RAM 16 ГБ, SSD 256 Гб, AMD Radeon Pro 555]</span>
					</div>
				</div>
				<div class="item-content-price" style="padding-top: 40px;">
					<span id="rub">340 200</span><span id="rubsumbol">₽</span>
				</div>	
			</div>
		</div>
	<?php endif; ?>
	<?php if($_SESSION['Accessories']) :?>
		<div class="item">
			<div class="item-content">
				<div class="item-content-text">
					<img src="../images/Complect2.jpg" id="item-content-text-images">
					<div class="item-content-text-text">
						<h3 style="margin-top: 16px;">Оперативная память Corsair Vengeance RGB [CMR16GX4M2C3000C15] 16 ГБ</h3>
						<span>[DDR3, 8 ГБx2, 1600 МГц, PC12800, 10-10-10-30]</span>
					</div>
				</div>
				<div class="item-content-price" style="padding-top: 40px;">
					<span id="rub">100 800</span><span id="rubsumbol">₽</span>
				</div>	
			</div>
		</div>
	<?php endif; ?>
	<?php if (($_SESSION['Monitors']) or ($_SESSION['Netbooks']) or ($_SESSION['Sistem_block']) or ($_SESSION['Accessories'])) :?>
		<div class="clear"></div>
	</div>
<?php endif; ?>

<?php require "../defolt/defoltfooter.php";?>
<?php require "../defolt/defolthead.php";?>

<?php
$data = $_POST;
if(isset($data['do_login']))
{
	$ord1 = R::load('courier', $data["namber-courier"]);
	$ord1->order=$data["namber-order"];
	R::store($ord1);
	$ord = R::load('order', $data["namber-order"]);
	$ord->courier=$data["namber-courier"];
	R::store($ord);
	header('Location: GOD.php');
}
?>

<h2>Заявки</h2>
<hr class="line">
<?php
$order=R::findLike('order', array('courier' => array('?')));
if($order)
{
	foreach ($order as $value)
	{
		echo "<br/>";
		echo '<tr>		
		<td>'."Заявка № ";echo $value['id']; echo "<br/>".'</td>
		<td>'."Адрес доставки: " ;echo $value['address']; echo "<br/>".'</td>
		<td>'."Дата доставки: "; echo $value['data']; echo "<br/>".'</td>
		<td>'."Курьер: " ; echo  $value['courier']; echo "<br/>".'</td>
		</tr>';
		echo "<br/>";
	}
}
else
{
	echo "Увы, заявок нет!";
}
?>
<h2 style="margin-top: 30px;">Курьеры</h2>
<hr class="line" style="margin-bottom: 10px;">
<?php
$courier=R::findLike('courier', array('order' => array('?')));
if($courier)
{
foreach ($courier as $value)
{
	echo "<br/>";
	echo '<tr>
	<td>'."Курьер № ";echo $value['id']; echo "<br/>".'</td>
	<td>'."ФИО курьера: " ;echo $value['fio']; echo "<br/>".'</td>
	<td>'."Машина курьера: " ;echo $value['car']; echo "<br/>".'</td>
	</tr>';
	echo "<br/>";
}
}
else
{
	echo "Увы, свободных курьеров нет!";
}
?>
<br/>
<form action="GOD.php" method="POST">
	<p><strong>Номер заявки</strong>:</p>
	<input type="text" name="namber-order" value="<?php echo @$data["namber-order"];?>">
	<p><strong>Номер курьера</strong>:</p>
	<input type="password" name="namber-courier" value="<?php echo @$data["namber-courier"];?>">
	<p><button type="sumbit" name="do_login">Выдать задание!</button></p>
</form>

<?php require "../defolt/defoltfooter.php";?>
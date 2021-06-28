<?php require "../defolt/defolthead.php";?>

<?php
$data = $_POST;
if(isset($data['do_login']))
{
	$ord = R::findOne('order', "`courier`=?", array($_SESSION['logged_user']->id));
	R::trash($ord);
	$ord1 = R::load('courier', $_SESSION['logged_user']->id);
	$ord1->order='?';
	R::store($ord1);
	header('Location: COURIER.php');
}
?>

<h2>Мои заказы</h2>
<hr class="line">
<div class="table">
	<?php
	$order=R::findLike('order', array('courier' => $_SESSION['logged_user']->id));
	?>
	<?php
	if($order)
{
	foreach ($order as $value)
	{
		echo "<br/>";
		echo '<tr>		
		<td>'."Заявка № ";echo $value['id']; echo "<br/>".'</td>
		<td>'."Адрес доставки: " ;echo $value['address']; echo "<br/>".'</td>
		<td>'."Дата доставки: "; echo $value['data']; echo "<br/>".'</td>
		</tr>';
		echo "<br/>";
	}
	?>
	<form action="COURIER.php" method="POST">
	<p><button type="sumbit" name="do_login">Выполнено!</button></p>
	</form>
	<?php
	}
else
{
	echo "Увы, для тебя работы нет!";
}
?>
</div>

<?php require "../defolt/defoltfooter.php";?>
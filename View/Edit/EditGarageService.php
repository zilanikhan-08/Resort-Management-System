<html>
    <body>
        <table border="1" align="center">
            <tr>
                <td colspan="3" align="left"><img src="1.png"></td>
                <td align="right"><a href= "../../controller/Auth/Logout.php">Logout |</a></td>
            </tr>
            <tr>
                <td colspan="3" align="left">
                    <form method="get" action="" enctype="">
                        <ul>
                        <li> <a href="Profile.php">Profile </a></li><br>
                            <li> <a href="../Dashboard.php">Home </a></li><br>
                            <li> <a href="EditFlat.php">Edit Flat Services></a></li><br>
                            <li> <a href="EditGarageService.php">Edit Garage Services ></a></li><br>  
                            <li> <a href="EditMoverService.php">Edit Movers Services ></a></li><br>
                            <li> <a href="EditHouseMaid.php">Edit House Maid Services ></a></li><br>
                        </ul>
                    </form>
                </td>
                
 <?php
require_once(__DIR__ . '/../../model/db.php');
error_reporting(0);

if(!isset($_COOKIE['flag'])){
    header('location: ../Auth/Login.php');
}

    $query = "SELECT * FROM `garageservice`"; 
    $con = dbConnection();
    $data = mysqli_query($con,$query);
    $total = mysqli_num_rows($data);
    $info = mysqli_fetch_assoc($data);
    if($total != 0)
    {
 ?>

<td>
    <table border = "3">
    <tr>
        <th>S_ID</th>
        <th>Location</th>
        <th>Rent</th>
        <th>Book</th>
    </tr>

        <?php
        while($info = mysqli_fetch_assoc($data))
        {
            echo "<tr>
            <td>".$info['S_ID']."</td>  
            <td>".$info['Location']."</td> 
            <td>".$info['Rent']."</td>
            <td>".$info['Book']."</td>
            
            <td><a href='Edit_Garage_Form.php?id=$info[S_ID]'>Edit</a></td>
            <td><a href='../../controller/Delete/Delete_Garage.php?id=$info[S_ID]'>Delete</a></td>
            </tr>";
        }
        
?>
</table>
</td>
</tr>

<?php
}else {
    echo "No data found";
}
?>

<tr>
    <td colspan="9" align="center">
        <h6>Copyright @ 2017</h6></br>
    </td>
</tr>
</table>
</body>
</html>
<?php 

if(!isset($_COOKIE['flag'])){
    header('location: ../Auth/Login.php');
}

require_once(__DIR__ . '/../../model/db.php');
$id = $_GET['id'];

$query = "SELECT * FROM housemaid WHERE S_ID = '$id'"; 
    
$con = dbConnection();

    $data = mysqli_query($con,$query);
    $total = mysqli_num_rows($data);
    $info = mysqli_fetch_assoc($data);
?>
<html>
    <body>
        <table border="1" align="center">
            <tr>
                <td colspan="3" align="left"><img src="1.png"></td>
                <td align="right"><a href= "../controller/Auth/Logout.php">Logout |</a></td>
            </tr>
            <tr>
                <td colspan="3" align="left">
                    <form method="get" action="" enctype="">
                        <ul>
                            <li> <a href="Profile.php">Profile </a></li><br>
                            <li> <a href="../Dashboard.php">Home </a></li><br>
                            <li> <a href="EditServices.php">Edit Services></a></li><br>
                            <li> <a href="EditHouseMaid.php">Edit HouseMaid></a></li><br>
                        </ul>
                    </form>
                </td>
                <td colspan="6">
                    <form method="POST" action="../../controller/Edit/editHouseMaid.php" enctype="">
                        <fieldset>
                            <legend><b>Edit House Maid Service</b></legend>
                            ServiceID: <input type="text" name="ServiceID" value=" <?php echo $info['S_ID']?> " /> <br>
                            Service Type: Movers <br>
                            Location: <input type="text" name="Location" value="<?php echo $info['Location']?>" /> <br>
                            Salary: <input type="text" name="Salary" value="<?php echo $info['Salary']?>" /> <br>
                            Duration: <input type="text" name="Duration" value="" /> <br><hr>               
                            <input type="submit" name="submit" value="Edit" />
                        </fieldset>
                    </form>
                </td>
            </tr>
            <tr>
                <td colspan="9" align="center">
                    <h6>Copyright @ 2017</h6></br>
                </td>
            </tr>
        </table>
    </body>
</html>


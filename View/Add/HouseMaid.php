<?php
require_once(__DIR__ . '/../../model/db.php');

if(!isset($_COOKIE['flag'])){
    header('location: ../Auth/Login.php');
}

$query = "SELECT * FROM `housemaid` ORDER BY S_ID DESC LIMIT 1"; 
    
$con = dbConnection();

    $data = mysqli_query($con,$query);
    $info = mysqli_fetch_assoc($data);
    $S_ID = $info['S_ID']+1;
?>
<!DOCTYPE html>
<html>
<head>
    <title>Form</title>
</head>
<body>
<html>
    <body>
    <table border="1" align="center">
                <tr>
                    <td colspan="3" align = "left"><img src="1.png"></td>
                <td align="right"><a href= "../../controller/Auth/Logout.php">Logout |</a></td>
                    
                </tr>
                <tr>
                    <td colspan="3" align = "left">
                    <form method="get" action= "" enctype="">
                            <ul >
                            <li> <a href="Profile.php">Profile </a></li><br>
                            <li> <a href="../Dashboard.php">Home </a></li><br>
                            <li> <a href="FlatService.php">Flat Services></a></li><br>
                            <li> <a href="GarageService.php">Garage Services ></a></li><br>  
                            <li> <a href="MoverService.php">Movers Services ></a></li><br>
                            <li> <a href="HouseMaid.php">House Maid Services ></a></li><br>
                            </ul>
                    
                         </form>
                    </td>
                    <td colspan="6">
                    <form method="POST" action="../../controller/Add/addHouseMaid.php" enctype="">
                            <fieldset>
                                <legend><b>Add New House Maid Service</b></legend>
                                
                                       ServiceID                <input type="text" name="ServiceID" value="<?php echo $S_ID?> " /> <br>
                                       Service Type: House Maid<br>               
                                       Location:                <input type="text" name="Location" value="" /> <br>
                                       Salaray:                    <input type="text" name="Salary" value="" /> <br>
                                       Duration:                <input type="text" name="Duration" value="" /> <br><hr>
                                                     
                                                               <br><input type="submit" name="submit" value="Add" />
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
</body>
</html>


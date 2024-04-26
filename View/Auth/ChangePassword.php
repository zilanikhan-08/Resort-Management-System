<!DOCTYPE html>
<html>
    <html lang="en">
        <head>
            <meta charset="UTF-8">
            <meta name="viewport" content="width=device-width, initial-scale=1.0">
            <title>Document</title>
        </head>
        <body>
            
            <form method="POST" action="" enctype="">
                <fieldset align="center" width="70%" height="300">
                    <legend align="center"><h1>CHANGE_PASSWORD</h1></legend>
                    New Password: <input type="text" name="new" value="" ><br>
                    Confirm Password: <input type="password" name="confirm" value="" ><br>
                    
                    <input type="submit" name="submit" value="OK" >
                </fieldset>
            </form>
            
        </body>
        </html>
<?php

$email = $_GET['email'];
if(isset($_POST['submit'])) {
    $new = $_POST["new"];
    $confirm = $_POST["confirm"];
    
    header("Location: ../../controller/Auth/password_Authentication.php?email=$email&new=$new&confirm=$confirm");

}
?>

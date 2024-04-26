<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" type="text/css" href="index.css">
</head>
<body>
    <table width="100%" height="550" align="center">
        <tr>
            <td>
                <main>
                    <table align="center">                           
                        <form method="POST" action="../../controller/Auth/LoginCheck.php" enctype="">
                            <fieldset align="center" class="wrapper">
                                <legend align="center"></legend>
                                <h1>Login</h1> <!-- Moved the heading inside the wrapper -->
                                User Name: <input type="text" name="username" value="" class="input-box"><br>
                                Password: <input type="password" name="password" value="" class="input-box"><br>
                                <input type="submit" name="submit" value="Sign In" class="btn">
                                <a href="FORGOT_PASSWORD.php">Forget Password?</a>
                            </fieldset>
                        </form>
                    </table>
                </main>
            </td>
        </tr>
    </table>
</body>
</html>

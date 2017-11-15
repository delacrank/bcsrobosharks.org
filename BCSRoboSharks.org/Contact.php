<?php
    include('Includes/views.php');
    include('Includes/functions.php');
    echo display_header('Contact Page | BCSRoboSharks');
    echo display_navigation();
?>
<main>
    <article class ='Contact'>
        
    <div>
        <h1>Contact BCSRoboSharks</h1>
        <img src="Images/telephone.png"/>
        <p>Send an email to BCSRobosharks, or reach out by telephone located at the bottom of the page under contact us. Your message is greatly appericated.</p>
    </div>
        
<?php
    $contact_fname = filter_input(INPUT_POST, 'contact_fname', FILTER_SANITIZE_STRING);
    $contact_email = filter_input(INPUT_POST, 'contact_email', FILTER_VALIDATE_EMAIL);
    $contact_subject = filter_input(INPUT_POST, 'contact_subject', FILTER_SANITIZE_STRING);
    $contact_message = filter_input(INPUT_POST, 'contact_message', FILTER_SANITIZE_STRING);
    $recipient = 'chezzking101@gmail.com';
    $content = 'From: ' . $contact_fname . '\n Message: ' . $contact_message;
    $email = 'From: ' . $contact_email;
?>
    <form name ='c_form' action='<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>' class = 'contact_form' method ="post" onsubmit="return validate_contact_form()">
    <fieldset>
        <p><label>Your Name :</label><input type = "text" name ="contact_fname"  value="<?php if(isset($contact_fname)) echo htmlentities($contact_fname); ?>"></p>
        <p id='c_fname' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px' ></p>
        <p><label>Your Email :</label><input type = "text" name ="contact_email" value = "<?php if(isset($contact_email)) echo htmlentities($contact_email); ?>" onblur ='return validate_email()'></p>
        <p id='c_email' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px'></p>
        <p><label>Subject :</label><input type = "text" name ="contact_subject" value = "<?php if(isset($contact_subject)) echo htmlentities($contact_subject); ?>"></p>
        <p id='c_subject' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px'></p>
        <p><label>Your Message :</label><textarea rows='10' cols='50' name ="contact_message"><?php if(isset($contact_message)) echo htmlentities($contact_message); ?></textarea></p>
        <p id='c_message' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px'></p>
        <input type="submit" value="send" name="submit"/>
    </fieldset>
    </form>
<?php
if($_SERVER['REQUEST_METHOD'] == 'POST') {    
        
    if(!filled_out($_POST)) {
        echo '<p id="error">Please fill out all the required fields.</p>';
    } else if(!$contact_email) {
        echo '<p id="error">Please submit a valid email address.</p>';
    }  else {
        mail($recipient, $contact_subject, $content, $email) or die("Your email could not be sent as filled out, please reload the page and try again.");
        echo '<p id="success">Thank You, your email was successfully sent ' . $contact_fname . '.</p>';
        echo '<script> 
                $(document).ready(function () {
                "use strict";
                    $(".contact_form").hide();
            });
            </script>';
    }
}
?>
    </article>
    <hr />
    
</main>
<?php
    echo display_footer();
?>
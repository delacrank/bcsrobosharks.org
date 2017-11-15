<?php

    function display_header($title) {
        $output = '<!doctype html>';
        $output .= '<html>';
        $output .= '<head>';
        $output .= '<title>' . $title . '</title>';
        $output .= '<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>';
        $output .= '<link rel="stylesheet" href="CSS/stylesheet.css">';
        $output .= '<link href="https://fonts.googleapis.com/css?family=Alegreya|Cairo|Crimson+Text|Slabo+27px" rel="stylesheet">';
        $output .= '</head>';
        $output .= '<body>';
        return $output;
    }

    function display_navigation() {
        $output = '<nav class = \'navigation\'>';
        $output .= '<ul>';
        $output .= '<li><a href=\'Index.php\'>BCS RoboSharks</a></li>';
        $output .= '<li><a href=\'Donate.php\'>Donate</a></li>';
        $output .= '<li><a href=\'Gallery.php\'>Gallery</a></li>';
        $output .= '<li><a href=\'Contact.php\'>Contact Me</a></li>';
        $output .= '<li><img id=\'menu\' src=\'Images/menu.jpg\'/></li>';
        $output .= '</ul></nav>';
        $output .= '<ul id = \'mini-menu\'>';
        $output .= '<li><a href=\'Donate.php\'>Donate</a></li>';
        $output .= '<li><a href=\'Gallery.php\'>Gallery</a></li>';
        $output .= '<li><a href=\'Contact.php\'>Contact Me</a></li>';
        $output .= '</ul>';
        
        return $output;
    }

    function display_footer() {
        $output = '<footer class = \'footer\'>';
        $output .= '<section class = \'col_one\'>';
        $output .= '<ul>';
        $output .= '<li>Sponsered by</li>';
        $output .= '<li><img src="https://www.twosigma.com/static/img/twosigma.png" class="sponsered-img"></li>';
        $output .= '</ul>';
        $output .= '</section>';
        $output .= '<section class = \'col_two\'>';
        $output .= '<ul>';
        $output .= '<li>Navigation</li>';
        $output .= '<li><a href=\'Index.php\'>Home</a></li>';
        $output .= '<li><a href=\'Donate.php\'>Donate</a></li>';
        $output .= '<li><a href=\'Gallery.php\'>Gallery</a></li>';
        $output .= '<li><a href=\'Contact.php\'>Contact Me</a></li>';
        $output .= '</ul>';
        $output .= '</section>';
        $output .= '<section class = \'col_three\'>';
        $output .= '<ul>';
        $output .= '<li>Contact us</li>';
        $output .= '<li>610 Henry Street</li>';
        $output .= '<li>Brooklyn, NY 11231</li>';
        $output .= '<li>Phone: (718) 923-4700</li>';
        $output .= '</ul>';
        $output .= '</section>';
        $output .= '</footer>';
        $output .= '<script type="text/javascript" src="javascript/JSfiles.js" ></script>';
        $output .= '</body>';
        $output .= '</html>';
        return $output;
    }

    function contact_form() {
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
    }
?>
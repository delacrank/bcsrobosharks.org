<?php
    include('Includes/views.php');
    echo display_header('Donate | BCSRoboSharks');
    echo display_navigation();
?>

<main>
    <article class ='donate'>
        <h1>Help Support BCS</h1>
        <div>
        <img src="Images/redcross.png"/>
        <p>Please support BCS, we need your support in order to run a robotics club here at the Brooklyn Collaborative School.</p>
        </div>
    </article>
    
    <!-- <article class = 'contribution'>
        <h1>Contribution goes towards</h1>
        <section class = 'one'>
        <img src='Images/kite.jpg' style='float: left'/>
        <p>Your contribution goes a long way in helping to pay for robotics parts, tranportation, etc.</p>
        </section>
       <section class = 'two'>
      <img src='Images/kite.jpg' style='float:left'/>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit,sed do  eiusmod
            tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
            veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea 
            commodo consequat. Duis aute irure dolor in repre</p>
        </section> 
    </article>  -->
    
    <form name ='d_form' action='' class = 'donate_form' method ="post" onsubmit="return validate_donate_form()">
    <fieldset>
        <section class ='first'>
        <h1>Donation Information</h1>
        <h2>I would like to make a donation in the amount of:</h2>
        <p><input type="radio" name="d_amount" value="1000" /> $1,000 </p>
        <p><input type="radio" name="d_amount" value="500" /> $500 </p>
        <p><input type="radio" name="d_amount" value="100"/> $100 </p>
        <p><input type="radio" name="d_amount" value="50" /> $50 </p>
        <p><input id ="donation_other" type="radio" name="d_amount" value="other"/> other </p>
        <p class = 'radio_input'><label>Other amount:</label> <input type="text" name="di_amount"/></p>
        <p id='d_radio' style='font-family: "Cairo"; font-size: 17px; color: red; margin-bottom: 5px; clear: left; margin-top: 10px;'></p>
        </section>
        
        <section class ='second'> 
        <p><label>First Name:</label><input type="text" name="donate_fname"/></p>
        <p id='d_fname' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px'></p>
        <p><label>Last Name:</label><input type="text" name="donate_lname"/></p>
        <p id='d_lname' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px'></p>
        <p><label>Email:</label><input type="text" name="donate_email"/></p>
        <p id='d_email' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px'></p>
        <p><label>Phone:</label><input type="text" name="donate_phone"/></p>
        <p id='d_phone' style='font-family: "Cairo"; font-size: 17px; color: red; margin-left: 40px; margin-bottom: 5px'></p>
        </section>         
        <input type="submit" value="donate"/>
    </fieldset> 
    </form>
         
<hr />
    
</main>
<?php
    echo display_footer();
?>
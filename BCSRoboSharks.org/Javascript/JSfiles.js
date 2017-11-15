/* exported validate_donate_form */
/* exported validate_contact_form */
/*jslint browser: true*/
/*global $*/
/* eslint-env browser */
/*jslint node: true */
$(window).resize(function () {
    "use strict";
    if ($(window).width() >= 768) {
        $("#mini-menu").slideUp();
    }
});

$(document).ready(function () {
    "use strict";
    $("#menu").click(function () {
        $("#mini-menu").slideToggle();
    });
});

$(document).ready(function () {
    "use strict";
    $(window).scroll(function () {
        if ($(window).scrollTop() > 75) {
            $('nav').addClass('fixed');
            $('#mini-menu').css({'transition-property': 'background',
                                'transition-duration': '1.5s',
                                 'background': 'rgba(81, 107, 126, .9)'});
		} else {
            $('nav').removeClass('fixed');
            $('#mini-menu').css('background', '');
        }
    });
});



$(document).ready(function () {
    "use strict";
    $("#all").click(function () {
        $(".aerial").show();
        $(".ascent").show();
        $(".rush").show();
    });
});

$(document).ready(function () {
    "use strict";
    $("#aerial").click(function () {
        $(".aerial").show();
        $(".ascent").hide();
        $(".rush").hide();
    });
});

$(document).ready(function () {
    "use strict";
    $("#ascent").click(function () {
        $(".ascent").show();
        $(".aerial").hide();
        $(".rush").hide();
    });
});

$(document).ready(function () {
    "use strict";
    $("#rush").click(function () {
        $(".rush").show();
        $(".ascent").hide();
        $(".aerial").hide();
    });
});

$(document).ready(function () {
    "use strict";
    $("#donation_other").click(function () {
        $(".radio_input").show();
    });
});

/* validate the conact form fields */
function validate_contact_form() {
    "use strict";
    var c_fname = document.forms.c_form.contact_fname.value,
        c_email = document.forms.c_form.contact_email.value,
        c_subject = document.forms.c_form.contact_subject.value,
        c_message = document.forms.c_form.contact_message.value,
        email = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/,
        error_fname = document.getElementById("c_fname"),
        error_email = document.getElementById("c_email"),
        error_subject = document.getElementById("c_subject"),
        error_message = document.getElementById("c_message");
    error_fname.innerHTML = "";
    error_email.innerHTML = "";
    error_subject.innerHTML = "";
    error_message.innerHTML = "";
    
    if (c_fname === "") {
        error_fname.innerHTML = "Must input your first name.";
        document.forms.c_form.contact_fname.focus();
        return false;
    } else {
        error_fname.innerHTML = "";
    }
    if (c_email === "") {
        error_email.innerHTML = "Must input an email address.";
        document.forms.c_form.contact_email.focus();
        return false;
    } else if (c_email.search(email)) {
        error_email.innerHTML = "The email address you input was not valid, please resubmit a valid email address.";
        document.forms.c_form.contact_email.focus();
        return false;
    } else {
        error_email.innerHTML = "";
    }
    
    if (c_subject === "") {
        error_subject.innerHTML = "Must input a valid subject.";
        document.forms.c_form.contact_subject.focus();
        return false;
    } else {
        error_subject.innerHTML = "";
    }
    if (c_message === "") {
        error_message.innerHTML = "Must input a valid message.";
        document.forms.c_form.contact_message.focus();
        return false;
    } else {
        error_message.innerHTML = "";
    }
}

/* validate the donation form fields */
function validate_donate_form() {
    "use strict";
    var d_amount = document.getElementsByName("d_amount"),
        di_amount = document.forms.d_form.di_amount.value,
        d_fname = document.forms.d_form.donate_fname.value,
        d_lname = document.forms.d_form.donate_lname.value,
        d_email = document.forms.d_form.donate_email.value,
        d_phone = document.forms.d_form.donate_phone.value,
        email = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/,
        phone = /^[2-9]\d{2}[2-9]\d{2}\d{4}$/,
        error_d_amount = document.getElementById("d_radio"),
        error_d_fname = document.getElementById("d_fname"),
        error_d_lname = document.getElementById("d_lname"),
        error_d_email = document.getElementById("d_email"),
        error_d_phone = document.getElementById("d_phone");
    error_d_amount.innerHTML = "";
    error_d_fname.innerHTML = "";
    error_d_lname.innerHTML = "";
    error_d_email.innerHTML = "";
    error_d_phone.innerHTML = "";
        

    if (d_amount[0].checked === true) {
        error_d_amount.innerHTML = "";
    } else if (d_amount[1].checked === true) {
        error_d_amount.innerHTML = "";
    } else if (d_amount[2].checked === true) {
        error_d_amount.innerHTML = "";
    } else if (d_amount[3].checked === true) {
        error_d_amount.innerHTML = "";
    } else if (d_amount[4].checked === true) {
        if (di_amount === "") {
            error_d_amount.innerHTML = "Must submit an amount.";
            document.forms.d_form.di_amount.focus();
            return false;
        } else {
            error_d_amount.innerHTML = "";
        }      
    } else {
        error_d_amount.innerHTML = "Please make a selection";
        return false;
    } 
        
    if (d_fname === "") {
        error_d_fname.innerHTML = "Must input first name.";
        document.forms.d_form.donate_fname.focus();
        return false;
    } else {
        error_d_fname.innerHTML = "";
    }
        
    if (d_lname === "") {
        error_d_lname.innerHTML = "Must input last name.";
        document.forms.d_form.donate_lname.focus();
        return false;
    }  else {
        error_d_lname.innerHTML = "";
    }
        
    if (d_email === "") {
        error_d_email.innerHTML = "Must input a valid email address.";
        document.forms.d_form.donate_email.focus();
        return false;
    } else if (d_email.search(email)) {
        error_d_email.innerHTML = "The email address you input was not valid, please resubmit a valid email address.";
        document.forms.d_form.donate_email.focus();
        return false;
    } else { 
        error_d_email.innerHTML = "";
    }
        
    if (d_phone === "") {
        error_d_phone.innerHTML = "Must input a phone number.";
        document.forms.d_form.donate_phone.focus();
        return false;
    } else if (d_phone.search(phone)){
        error_d_phone.innerHTML = "The phone number you input was not valid, please resubmit a valid phone number.";
        document.forms.d_form.donate_phone.focus();
        return false;
    } else {
         error_d_phone.innerHTML = "";
    }
} 

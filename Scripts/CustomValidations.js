$(document).ready(function () {
   
    $("input[name='FirstName']").keyup(function () {
        if (jQuery(this).val() != "") {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        } else {
            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        }

    });

    $("input[name='MiddleName']").keyup(function () {
        if (jQuery(this).val() != "") {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        } else {
            jQuery(this).prev().css("color", "#1B8AF3").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-pencil");
        }

    });

    $("input[name='LastName']").keyup(function () {
        if (jQuery(this).val() != "") {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        } else {
            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        }

    });

    $("input[id='DOB']").change(function () {
        if (jQuery(this).val() != "") {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        } else {
            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        }

    });

    $("input[name='Username']").keyup(function () {
        if (jQuery(this).val() != "") {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        } else {
            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        }

    });

    $("input[name='Password']").keyup(function () {
        if (jQuery(this).val() != "") {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        } else {
            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        }

    });

    $("input[name='Address']").keyup(function () {
        if (jQuery(this).val() != "") {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        } else {
            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        }

    });

    $("input[name='PhoneNo1']").keyup(function () {
        if (isNaN(jQuery(this).val())) {

            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        } else {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        }

    });

    $("input[name='PhoneNo2']").keyup(function () {
        if (isNaN(jQuery(this).val())) {

            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        } else {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        }

    });

    $("input[name='CNIC']").keyup(function () {
        if (isNaN(jQuery(this).val())) {

            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        } else {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
        }

    });

    $("input[name='EmailAddress']").keyup(function () {
        var re = /^[\w\-\.\+]+\@[a-zA-Z0-9\.\-]+\.[a-zA-z0-9]{2,4}$/;
        
        if (re.test(jQuery(this).val()))
        {
            jQuery(this).prev().css("color", "#2EDC2E").removeClass("fa-pencil").addClass("fa fa-check-circle");
            
            
        } else {
            jQuery(this).prev().css("color", "#DC2E2E").removeClass("fa-pencil").removeClass("fa-check-circle").addClass("fa-times-circle");
        }
    });


   
});
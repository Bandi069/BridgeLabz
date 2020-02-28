//// This is Form Validation
function validateForm() {
    var x = document.forms["FormValidation"]["FirstName"];
    if (x.value == "") {
        alert("Name must be filled out");
        return false;
    }
}
function FirstNamevalidate(Firstname) {
    var Firstname = document.getElementsByName["lineclass"];
    if (Firstname == "") {
        alert("First Name Empty Not allowed");
        return false;
    }
    else {
        return true;
    }
}
//// This is Validation of Phone Number
function ValidatePhonenumber(Phonenumber) {
    var reg = /^([7-9]{1}[0-9]{9})$/;
    if (reg.test(Phonenumber.value) == false) {
        console.log(reg.test(Phonenumber.value));
        alert("Invalid Phone NUmber");
        return false;
    }

}

//// This is Validation of EMail ID
function EmailIdValidateion(emailField) {
    var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
    if (reg.test(emailField.value) == false) {
        alert('Invalid Email Address');
        return false;
    }
    else {
        return true;
    }
    $(document).ready(function (e) {
        $('#lineclass').click(function () {
            var email = $('#text').val();
            if ($.trim(email).length == 0) {
                alert('Please Enter Valid Email Address');
                return false;
            }
            if (validateEmail(email)) {
                alert('Valid Email Address');
                return false;
            }
            else {
                alert('Invalid Email Address');
                return false;
            }
        });
    });
}

//// This is Click alert function.
//// Gives an alert message.
//// When we click on the button the button calls this Clickfunction()
function Clickfunction() {
    alert("Registered Succesfully");
}


function Clickfunction() {
    alert("Registered Succesfully");
}


function validateForm() {
    var x = document.forms["FormValidation"]["FirstName"].value;
    if (x == "") {
        alert("Name must be filled out");
        return false;
    }
}
function registration(names) {
    var feilds = document.getElementsByClassName("Registration");
    if (feilds.test(names.value == "")) {
        alert("Empty feilds not Accepted");
        return false;
    }
    return true;
}
function FirstNamevalidate(Firstname) {
    var Firstname = document.getElementsByName("lineclass");
    if (Firstname == "") {
        alert("First Name Empty Not allowed");
        return false;
    }
    else {
        return true;
    }

}
function ValidatePhonenumber(Phonenumber) {
    var reg = /^([7-9]{1}[0-9]{9})$/;
    if (reg.test(Phonenumber.value) == false) {
        console.log(reg.test(Phonenumber.value));
        alert("Invalid Phone NUmber");
        return false;
    }
    return true;
}
function EmailIdValidateion(emailField) {
    var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
    if (reg.test(emailField.value) == false) {
        alert('Invalid Email Address');
        return false;
    }

    return true;
}
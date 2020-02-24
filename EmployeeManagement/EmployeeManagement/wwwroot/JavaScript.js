function Clickfunction() {
    alert("Registered Succesfully");
}
function validate() {
    var Firstname = document.getElementsByName("FirstName");
    var phonenumber = document.getElementsByName("PhoneNumber");
    if (Firstname.value == "") {
        alert("Empty Not allowed");
        return false;
    }
    else {
        return true;
    }
    if (phonenumber.value.trim().lenth == 10) {
        return false;
    }
    else {
        alert("Invalid Phone Number")
    }
}
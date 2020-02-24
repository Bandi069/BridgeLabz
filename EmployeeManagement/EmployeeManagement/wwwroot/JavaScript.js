function Clickfunction() {
    alert("Registered Succesfully");
}
function validate() {
    var Firstname = document.getElementsByName("lineclass");
    var phonenumber = document.getElementsByName("PhoneNumber");
    if (Firstname == "") {
        alert("Empty Not allowed");
        return false;
    }
    else {
        return true;
    }
    if (phonenumber.value.trim().length == 10) {
        return false;
    }
    else {
        alert("Invalid Phone Number")
    }
}
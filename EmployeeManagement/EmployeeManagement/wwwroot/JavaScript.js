function Clickfunction() {
    alert("Registered Succesfully");
}
function validate() {
    var Firstname = document.getElementsByName("FirstName");
    if (Firstname.value == "") {
        alert("Empty Not allowed");
        return false;
    }
    else {
        return true;
    }
}
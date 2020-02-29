
//// This is Form Validation
function validateForm() {
    var varform= document.forms["FormValidation"]["FirstName"];
    if (varform.value == "") {
        alert("Name must be fill");
        return false;
    }
}

//// Name validation function
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
        alert("Invalid Phone Number");
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
}


function Clickfunction() {
    $(document).ready(function () {
        var formData = new FormData;
        formData.append("EmployeeID", $("#EmployeeID").val());
        formData.append("Firstame", $("#FirstName").val());
        formData.append("LastName", $("#LastName").val());
        formData.append("PhoneNumber", $("#PhoneNumber").val());
        formData.append("EmailID", $("#EmailID").val());
        $.ajax({
            url: "api/Create",
            type: 'POST',
            cache: false,
            contentType: "application/json",
            processData: false,
            data: formData,
            success: function (response) {
                if (response == "Added Successfully") {
                    alert(response);
                }
                /*else {
                    var Html;
                    if (response == "") {
                        alert("EmployeeID required");
                    }
                    if (response == "") {
                        alert("First Name required");
                    }
                    if (response == "") {
                        alert("Last Name required");
                    }
                    if (response == "") {
                        alert("Email ID is invalid");
                    }
                    if (response == "") {
                        alert("Mobile Number Invalid");
                    }*/
                }
            },
            error: function (response) {
                alert(response);
            }
        });
    });
}


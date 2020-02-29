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


function Clickfunction() {
    $(document).ready(function () {
        var formData = new FormData;
        formData.append("EmployeeID", $("#EmployeeID").val());
        formData.append("Firstame", $("#FirstName").val());
        formData.append("LastName", $("#LastName").val());
        formData.append("PhoneNumber", $("#PhoneNumber").val());
        formData.append("EmailID", $("#EmailID").val());
        $.ajax({
            url: "Create",
            type: 'POST',
            cache: false,
            contentType: false,
            processData: false,
            data: formData,
            success: function (response) {
                if (response == "Added Successfully") {
                    alert(response);
                }
                else {
                    var teHtml;
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
                    }
                }
            },
            error: function (response) {
                alert(response);
            }
        });
    });
}



//// This is Form Validation
function validateForm() {
    var varform = document.forms["FormValidation"]["FirstName"];
    if (varform.value == "") {
        alert("Name must be fill");
        return false;
    }
}

//// Name validation function
function FirstNamevalidate(FirstName) {
    var FirstName = document.getElementsByName["lineclass"];
    if (FirstName == "") {
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

function AddClickfunction() {
    $(document).ready(function () {
        $("#Button").click(function () {
            var formData = new FormData();
            formData.append("EmployeeID", $("#employeeid").val());
            formData.append("FirstName", $("#firstnameid").val());
            formData.append("LastName", $("#lastnameid").val());
            formData.append("EmailID", $("#emailId").val());
            formData.append("PhoneNumber", $("#phonenumid").val());
            $.ajax({
                url: "api/create",
                type: 'POST',
                cache: false,
                contentType: "application / json",
                processData: false,
                data: FormData,
                success: function (response) {

                    window.location.href = 'https://localhost:44348/UpdateEmployee.html'
                    alert("Employee Added Sucessfully")
                },
                error: function () {
                    alert("Errors Occur");
                }
            });
        });
    });
}

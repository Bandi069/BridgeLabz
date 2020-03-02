
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

function Clickfunction() {
    $(document).ready(function () {
        var formData = new FormData;
        formData.append("FirstName", $("#firstNameId").val());
        formData.append("LastName", $("#lastNameId").val());
        formData.append("EmailID", $("#emailId").val());
        formData.append("PhoneNumber", $("#phoneNumId").val());
        $.ajax({
            url: "api/create",
            type: 'POST',
            cache: false,
            contentType: "application/json; charset=utf - 8",
            dataType: "json",
            processData: false,
            data: formData,

            success: function (response) {
                $("#EmployeeRegistration").show();
                window.location.href = 'https://localhost:44348/Index.html'
                alert("Employee Added Sucessfully")
            }
        });
    });
}
function Clickfunction() {
    $(document).ready(function () {
        var formData = new FormData;
        formData.append("FirstName", $("#firstNameId").val());
        formData.append("LastName", $("#lastNameId").val());
        formData.append("EmailID", $("#emailId").val());
        formData.append("PhoneNumber", $("#phoneNumId").val());
        $.ajax({
            url: "api/update",
            type: 'POST',
            cache: false,
            contentType: "application/json; charset=utf - 8",
            dataType: "json",
            processData: false,
            data: formData,

            success: function (response) {
                window.location.href = 'https://localhost:44348/UpdateEmployee.html'
                alert("Employee Updated Sucessfully")
            }
        });
    });
}
function Clickfunction() {
    $(document).ready(function () {
        var formData = new FormData;
     
        formData.append("EmployeeID", $("#employeeID").val());
       
        $.ajax({
            url: "api/delete",
            type: 'Delete',
            cache: false,
            contentType: "application/json; charset=utf - 8",
            dataType: "json",
            processData: false,
            data: formData,

            success: function (response) {
                $("#EmployeeRegistration").show();
                window.location.href = 'https://localhost:44348/Index.html'
                alert("Employee Deleted Sucessfully")
            }
        });
    });
}


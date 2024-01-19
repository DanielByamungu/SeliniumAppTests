console.log(document.getElementById("name"));
const Name = document.getElementById("name");
const address = document.getElementById("address");
const province = document.getElementById("province");
const postalCode = document.getElementById("postalCode");
const phoneNumber = document.getElementById("phoneNumber");
const email = document.getElementById("email");
const vehicleMake = document.getElementById("vehicleMake");
const vehicleModel = document.getElementById("vehicleModel");
const vehicleYear = document.getElementById("vehicleYear");
if (document.readyState == "loading") {
    document.addEventListener("DOMContentLoaded", outputResult);
} else {
    outputResult();
}
let errors = "";

function validation() {
    let noError = true;
    if (Name.value = "") {
        errors += "Please enter a name<br>";
        noError = false;
    } 
    else {
        return noError;
    }

    // else if(!Name.value.includes(" ")){
    //     errors+="Please enter first and last name\n";
    //     noError=false;
    // }

    if (address.value = "") {
        errors += "please enter an address<br>";
        noError = false;
    } else {
        return noError;
    }

    var regPostalCode = /^[A-Za-z]\d[A-Za-z][-]?\s?\d[A-Za-z]\d$/;
    if (postalCode.value.match(regPostalCode)) {
        return noError;
    }
    else {
        errors += "please enter a valid postal code<br>";
        noError = false;
    }

    var regPhoneNumber = /^\d{3}\d{3}\d{4}$/;
    if (phoneNumber.value.match(regPhoneNumber)) {
        return noError;
    } else {
        errors += "please enter a valid phone number<br>";
        noError = false;
    }
    if (email.value = "") {
        errors += "please enter an email<br>";
        noError = false;
    } else {
        return noError;
    }
    if (vehicleMake.value = "") {
        errors += "please enter the vehicle make<br>";
        noError = false;
    } else {
        return noError;
    }
    if (vehicleModel.value = "") {
        errors += "please enter the vehicle model<br>";
        noError = false;
    } else {
        return noError;
    }
    if (vehicleYear.value = "") {
        errors += "please enter the vehicle year<br>";
        noError = false;
    }
    else if (isNaN(vehicleYear.value)) {
        errors += "please enter a valid year with four digits";
        noError = false;
    }
    else {
        return noError;
    }
    return noError;
}

function outputResult() {
    if (validation()) {
        sessionStorage.setItem("name", (document.getElementById("name").value));
        sessionStorage.setItem("email", (document.getElementById("email").value));
        sessionStorage.setItem("address", (document.getElementById("address").value));
        sessionStorage.setItem("province", (document.getElementById("province").value));
        sessionStorage.setItem("postalCode", (document.getElementById("postalCode").value));
        sessionStorage.setItem("phoneNumber", (document.getElementById("phoneNumber").value));
        sessionStorage.setItem("vehicleMake", (document.getElementById("vehicleMake").value));
        sessionStorage.setItem("vehicleYear", (document.getElementById("vehicleYear").value));
        sessionStorage.setItem("vehicleModel", (document.getElementById("vehicleModel").value));
        button.addEventListener("click", outputResult());
    }
    else {
        document.getElementById("Errors").innerHTML = errors;
    }
}
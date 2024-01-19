if (document.readyState == "loading") {
    document.addEventListener("DOMContentLoaded", init);
} else {
    init();
}
function init() {
    document.getElementById("submit").onclick=outputResult;
    const fullName = document.getElementById("fullName");
    const address = document.getElementById("address");
    const city = document.getElementById("city");
    const province = document.getElementById("province");
    const postalCode = document.getElementById("postalCode");
    const phoneNumber = document.getElementById("phoneNumber");
    const email = document.getElementById("email");
    const vehicleMake = document.getElementById("vehicleMake");
    const vehicleModel = document.getElementById("vehicleModel");
    const vehicleYear = document.getElementById("vehicleYear");
    let errors = "";

    function validation() {
        let noError = true;
        if (fullName.value == "") {
            errors += "Please enter a name<br>";
            noError = false;
        }
       

        if (address.value == "") {
            errors += "please enter an address<br>";
            noError = false;
        }
        if (city.value == "") {
            errors += "please enter the city<br>";
            noError = false;
        }
        if (province.value == "") {
            errors += "please enter the province name<br>";
            noError = false;
        }
        var regPostalCode = /^[A-Za-z]\d[A-Za-z]\s\d[A-Za-z]\d$/;
        if (!postalCode.value.match(regPostalCode)) {
            errors += "please enter a valid postal code<br>";
            noError = false;
        }

        var regPhoneNumber = /^\d{3}-\d{3}-\d{4}$/;
        if (!phoneNumber.value.match(regPhoneNumber)) {
            errors += "please enter a valid phone number<br>";
            noError = false;
        } 
        if (email.value == "") {
            errors += "please enter an email<br>";
            noError = false;
        }
        if (vehicleMake.value == "") {
            errors += "please enter the vehicle make<br>";
            noError = false;
        }
        
        if (vehicleModel.value == "") {
            errors += "please enter the vehicle model<br>";
            noError = false;
        } 
        if (vehicleYear.value == "") {
            errors += "please enter the vehicle year<br>";
            noError = false;
        }
        else if (isNaN(vehicleYear.value)) {
            errors += "please enter a valid year with four digits";
            noError = false;
        }
        
        return noError;
    }

    function outputResult() {
       
        if (validation()) {
            sessionStorage.setItem("fullName", (fullName.value));
            sessionStorage.setItem("email", (email.value));
            sessionStorage.setItem("address", (address.value));
            sessionStorage.setItem("city", (city.value));
            sessionStorage.setItem("province", (province.value));
            sessionStorage.setItem("postalCode", (postalCode.value));
            sessionStorage.setItem("phoneNumber", (phoneNumber.value));
            sessionStorage.setItem("vehicleMake", (vehicleMake.value));
            sessionStorage.setItem("vehicleYear", (vehicleYear.value));
            sessionStorage.setItem("vehicleModel", (vehicleModel.value));

            window.location.href = 'result.html';
            
        }
        else {
            document.getElementById("Errors").innerHTML = errors;
            document.getElementById("Errors").style.color="red";
        }
    }
}

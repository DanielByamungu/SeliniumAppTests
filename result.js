function assign()
{
 var fullName = sessionStorage.getItem("fullName");

 var email = sessionStorage.getItem("email");

  var address = sessionStorage.getItem("address");

  var city = sessionStorage.getItem("city");

   var province = sessionStorage.getItem("province");

    var phoneNumber = sessionStorage.getItem("phoneNumber");

    var postalCode =(sessionStorage.getItem("postalCode"));

    var vehicleMake = sessionStorage.getItem("vehicleMake");

    var vehicleModel= sessionStorage.getItem("vehicleModel");

    var vehicleYear =(sessionStorage.getItem("vehicleYear"));

  //document.getElementById("demo").innerHTML ="<br><br>"+ "Name:"+name+"<br>Email: "+email+"<br>PhoneNumber:"+phoneNumber+"<br>Address: "+address+"<br>postalCode: "+postalCode+"<br>province: "+province+"<br>VehicleInformation: "+'<a href="http://www.jdpower/'+vehicleMake+'/'+vehicleModel+'/'+vehicleYear+'.com">www.jdpower.com</a>';
  document.getElementById("demo").innerHTML=`<br>
  Name: ${fullName} <br>
  Email: ${email} <br>
  phoneNumber:${phoneNumber} <br>
  address:${address} <br>
  city: ${city} <br>
  province: ${province} <br>
  PostalCode:${postalCode} <br>
  vehicleInformation:<a href="http://www.jdpower.com/${vehicleMake}/${vehicleModel}/${vehicleYear}">www.jdpower.com/${vehicleMake}/${vehicleModel}/${vehicleYear}</a>`
  
}
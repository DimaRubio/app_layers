var myText = "My new Text";
//alert(myText);

var showText = function (text) {
    alert(text)
}

showText(myText)

var userModel = {
    ID : null,
    Name : "User111",
    Lastname : null,
    Adress : null,
    Email : "asd@test.qa",
    Age : "80"
}

var successful_callback = function (data) {
   // alert("success");
    $('#res').html(data);
}
var error_callback = function (data) { alert("error") }
//var url = "/user/adduser"
//$.post(url, userModel, successful_callback, error_callback)

var url = "/User/AddUserJQ";
$.post(url, userModel, successful_callback);
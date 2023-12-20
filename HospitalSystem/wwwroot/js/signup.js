function signup() {
 
    let email = document.getElementById("email").value;
    let emailRe = /\w+@gmail\.com$/i;
    let validateEmail = emailRe.test(email);
    if (validateEmail === false) {
        alert("your email must have @gmail.com");
        return;
    }
 

    let phoneNum = document.getElementById("phoneNum").value;
 
    let phoneReg = /^0(10|11|12|15)\d{8}$/;
    let validateNumber = phoneReg.test(phoneNum);
    
    if (validateNumber === false) {
        alert("start with 010, 011, 012, or 015");
        return;
    }

    let pass = document.getElementById("password").value;
    let confirmpass = document.getElementById("comfirm password").value;
    let passReg = /\w{8,}/;
    let validatepassword = passReg.test(pass);
    if (validatepassword === false && pass != confirmpass) {
        alert("Weak password the minimum length is 8 chars");
        return;
    }
 
    let gender = document.getElementById("gender").value;
    if (!(gender === "female" || gender === "male")) {
        alert("your gender is male or female");
        return;
    }



}

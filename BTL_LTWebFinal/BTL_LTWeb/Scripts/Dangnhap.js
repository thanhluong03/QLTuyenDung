
let user = document.getElementById("userdn");
let password = document.getElementById("passworddn");

//Hàm xử lý sự kiện add
function valid() {//Lấy giá trị mình nhập vào
    let username = user.value.trim();
    let userpassword = password.value.trim();
    //Nếu giá trị nhập ko thỏa mãn thì hiện thông báo với
    if (!(checkValid(username, userpassword))) {
        let tb = "Kiểm tra lại";
        if (username == "") {
            tb += " Tên đăng nhập,";
        }
        if (userpassword == "") {
            tb += " password,";
        }
        tb = tb.substring(0, tb.length - 1);
        tb += " của người dùng!!!";
        alert(tb);//Thông báo nhập lại từng cái
        return false;
    } else {
        return true;
    }
}
function checkValid(username, userpassword, userrepassword) {
    if (username == "" || userpassword == "") return false;
    else return true;
}

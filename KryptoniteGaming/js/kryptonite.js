
function GetXMLHTTPResponse(URL) {


    var xmlhttp, sResponse = "";
    if (window.XMLHttpRequest) {     // code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp = new XMLHttpRequest();
    }
    else {    // code for IE6, IE5
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    var curDate = new Date();

    var strURL = URL + "&Date=" + curDate.getTime();

    //var strEncrypted = EncryptString(strURL);

    //strURL = "DataAccess.ashx?" + strURL;

    //qalert(strURL);

    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            try {

                // FillResults(xmlhttp.responseText);
            }
            catch (err) { alert(err.message); }
        }
    }


    xmlhttp.open("GET", strURL, false);
    xmlhttp.send();

    return xmlhttp.responseText;

}
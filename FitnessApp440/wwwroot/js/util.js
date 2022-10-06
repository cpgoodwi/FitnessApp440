/* UTILITY FUNCTIONS */

function updateSession(newName) {
    $.ajax({
        type: "GET",
        url: "/api/Session",
        dataType: "json",
        data: { userID: newName },
        success: function (result) {
            console.log(result.value)
            if (result.value[0] != "")
                return
            else
                hideApp()
        },
        error: function (req, status, error) {
            alert("uh oh")
            $("html").hide()
        }
    })
}


/* A Function to Get a Cookie (https://www.w3schools.com/js/js_cookies.asp) */
function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
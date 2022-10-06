// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // check if user is logged in, if not prompt them to log in.

    $.ajax({
        type: "GET",
        url: "/api/Session",
        dataType: "json",
        // data: { userID: getCookie("uid") },
        success: function (result) {
            console.log(result.value)
            if (result.value[0] != "")
                $("#toLogin").hide()
            else
                hideApp()
        },
        error: function (req, status, error) {
            alert("uh oh")
            $("html").hide()
        }
    })
})

function showApp() {
    
}

function hideApp() {
    if ($("main").children().hasClass("authForm")) { // children().hasClass() is a little janky, might want to find another way
        $("#toLogin").hide() // hide() might be too slow for UX, but for now it works
    } else {
        $("main").hide()
        $("#appBody").html(`
            <h1>You are not logged in.</h1>
            <p>Please log in to use our service</p>
        `)
        $("#toProfile").hide()
        $("#toLogout").hide()
        $("#postFood").hide()
    } if ($("main").children().hasClass("authForm")) {
        $("#toProfile").hide()
        $("#toLogout").hide()
        $("#postFood").hide()
    }
}

<<<<<<< HEAD
function loggedIn() {
    // check status of user login in database
    $.ajax({
        type: "GET",
        url: "/Session/GetSessionKeyUsername",
        dataType: "text",
        success: function (result) {
            alert("you did it")
            console.log(result)
        },
        //error: function (req, status, error) {
        //    alert("no luck")
        }
    })

    return true
}
=======
$("#toLogout").click(function () {
    // TODO: Figure out a way to logout. Right now its just close and reopen
})
>>>>>>> f994b5fe38ebf0e441dc242d464ac7bbf67fe9f4

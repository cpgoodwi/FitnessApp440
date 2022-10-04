/* PROFILE JAVASCRIPT FILE
 *  get the state of the client, user can modify their own page but not someone else's
 *  anyone can view anyone's posts but only user can view their likes // TODO: enable private or public likes for user settings
 *  
 *  TODO: use ajax to load all food liked by user
 *  TODO: use ajax to load all food posted by user
 */

$(document).ready(function () {
    console.log("profile loaded")
    $.ajax({
        type: "GET",
        url: "/User/GetUserJSON",
        dataType: "json",
        success: function (result) {
            console.log("from url")
            console.log(result.value)
            $("#profile-name").text(result.value.userName)
        },
        error: function (req, status, error) {
            console.log(status)
        }
    })
})
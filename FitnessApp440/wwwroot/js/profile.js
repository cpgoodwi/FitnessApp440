/* PROFILE JAVASCRIPT FILE
 *  get the state of the client, user can modify their own page but not someone else's
 *  anyone can view anyone's posts but only user can view their likes // TODO: enable private or public likes for user settings
 *  
 *  TODO: use ajax to load all food liked by user
 *  TODO: use ajax to load all food posted by user
 */

$(document).ready(function () {
    var userInfo;

    console.log("profile loaded")
    $.ajax({
        type: "GET",
        url: "/User/GetUserJSON",
        dataType: "json",
        data: { username: "charley" },
        success: function (result) {
            console.log(result.value)
            loadProfile(result.value)
            /*$("#profile-name").text(result.value.userName)*/
        },
        error: function (req, status, error) {
            console.log(status)
        }
    })
})

function loadProfile(userInfo) {
    $("#profile-name").text(userInfo.userName)

    for (const post of userInfo.foodPosts) {
        $("#user-posts").append(new Food(post.foodID, post.byUser, post.name, post.calories, post.protein, post.carbs, post.fat, post.imageLcation, post.descriptionText).renderHTML())
    }

    for (const like of userInfo.likedFood) {
        $("#user-likes").append(new Food(like.foodID, like.byUser, like.name, like.calories, like.protein, like.carbs, like.fat, like.imageLcation, like.descriptionText).renderHTML())
    }
}
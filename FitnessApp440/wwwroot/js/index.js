/* TODO: use ajax to load all food from database
 */

let foodList = []

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Food/LoadAllFood",
        dataType: "json",
        success: function (result) {
            console.log(result)
            for (const mem of result.value)
                foodList.push(new Food(mem.foodID, mem.byUser, mem.name, mem.calories, mem.protein, mem.carbs, mem.fat, mem.imageLcation, mem.descriptionText))
            for (const food of foodList) {
                $("#food-feed").append(food.renderHTML())
            }
        },
        error: function (req, status, error) {
            alert("oh no")
            console.log(status)
        }
    })
})

// foodList.push(new Food(0001, "username", "hot dog", 100, 100, 100, 100, "Banana.jpg", "This is a hot dog"))


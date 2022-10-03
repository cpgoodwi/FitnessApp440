let foodList = []

foodList.push(new Food(0001, "username", "hot dog", 100, 100, 100, 100, "Banana.jpg", "This is a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))
foodList.push(new Food(0002, "username2", "hot dog2", 1002, 1002, 1002, 1002, "Banana.jpg", "This is not a hot dog"))

for (const food of foodList) {
    $("#food-feed").append(food.renderHTML())
}
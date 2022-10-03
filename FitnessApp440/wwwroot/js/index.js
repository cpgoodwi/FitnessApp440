let foodList = []

foodList.push(new Food(0001, "username", "hot dog", 100, 100, 100, 100, "Banana.jpg", "This is a hot dog"))

for (const food of foodList) {
    $("#food-feed").append(food.renderHTML())
}
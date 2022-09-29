let foodList = []

foodList.push(new Food(0001, "hot dog", 100, 100, 100, 100, "hot dog", "This is a hot dog"))

for (const food of foodList) {
    $("#food-feed").append(food.renderHTML())
}
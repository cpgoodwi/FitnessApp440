/* FOOD CLASS
 *  for loading food items as componenets
 *  takes data from data as attributes and loads it into one HTML component to render
 */

class Food {
    constructor(foodID, byUser, name, calories, protein, carbs, fat, image, description) {
        this.foodID = foodID
        this.byUser = byUser // TODO: implement link to view specific user posts
        this.name = name
        this.calories = calories
        this.protein = protein
        this.carbs = carbs
        this.fat = fat
        this.image = image
        this.description = description
    }

    renderHTML() {
        return (`
            <div class="food-item" id="food${this.foodID}">
                <img src="${this.image}" alt="${this.name}" height="100" />
                <h6 class="food-name">${this.name}</h6>
                <a class="food-by">${this.byUser}</a>
                <ul class="food-stats">
                    <li>${this.calories} Calories</li>
                    <li>${this.protein}g Protein</li>
                    <li>${this.carbs}g Carbs</li>
                    <li>${this.fat}g Fat</li>
                </ul>
                <details class="food-desc">${this.description}</details>
                <div id="food${this.foodID}-like" onclick="likeFood(${this.foodID})")">like</div>
                <!-- div id="food${this.foodID}-like2" onclick="Food.like(${this.foodID})")">like2</div -->
            </div>
        `)
    }

    // added static method for like. Either works fine but it might be better 
    static like(foodID) {
        console.log(foodID)
    }
}

function likeFood(foodID) {
    // this function will use AJAX to like or unlike the food on the database
    console.log(foodID)
}
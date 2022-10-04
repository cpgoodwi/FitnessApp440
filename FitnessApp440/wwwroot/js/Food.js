// Food Class for loading food items as componenets
// takes data from data as attributes and loads it into one HTML component to render

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
                <img src="img/${this.image}" alt="${this.name}" height="100" />
                <h5 class="food-name">${this.name} by <a class="food-by">${this.byUser}</a></h5>
                <ul class="food-stats">
                    <li><span>Calories:</span> ${this.calories}cal</li>
                    <li><span>Protein:</span> ${this.protein}g</li>
                    <li><span>Carbs:</span> ${this.carbs}g</li>
                    <li><span>Fat:</span> ${this.fat}g</li>
                </ul>
                <details class="food-desc">${this.description}</details>
                <div id="food${this.foodID}-like" onclick="likeFood(${this.foodID})")">&#9825;</div>
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
    //console.log(foodID);
    //const heart = document.getElementById('food${this.foodID}');
    //heart.innerHTML = "&#10084";

    $(`#food${this.foodID}-like`).click(function () {
        $(`#food${this.foodID}-like`).html("&hearts;");
    });

    //$(`food${this.foodID}-like`).css("background-color", "red");
}
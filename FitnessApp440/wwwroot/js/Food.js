// Food Class for loading food items as componenets
// takes data from data as attributes and loads it into one HTML component to render

class Food {
    constructor(foodID, byUser, name, calories, protein, carbs, fat, imageLcation, description) {
        this.foodID = foodID
        this.byUser = byUser // TODO: implement link to view specific user posts
        this.name = name
        this.calories = calories
        this.protein = protein
        this.carbs = carbs
        this.fat = fat
        this.imageLcation = imageLcation
        this.description = description
    }

    renderHTML() {
        return (`
            <div class="food-item" id="food${this.foodID}">
                <img src="/img/${this.imageLcation}" alt="${this.name}" height="100" />
                <h3 class="food-name">${this.name}</h3><a class="food-by" id="to${this.byUser}">${this.byUser}</a>
                <ul class="food-stats">
                    <li><span>Calories:</span> ${this.calories}cal</li>
                    <li><span>Protein:</span> ${this.protein}g</li>
                    <li><span>Carbs:</span> ${this.carbs}g</li>
                    <li><span>Fat:</span> ${this.fat}g</li>
                </ul>
                <details class="food-desc">${this.description}</details>
                <div id="food${this.foodID}-like" onclick="likeFood(${this.foodID})")">&#9829;</div>
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

    //$(`food${this.foodID}-like`).click(function () {
    //    $(`food${this.foodID}-like`).html("&#10084");
    //});
    $(`#food${foodID}-like`).css("color", "red");
}
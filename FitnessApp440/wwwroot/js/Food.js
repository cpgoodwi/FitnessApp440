﻿/* FOOD CLASS
 *  for loading food items as componenets
 *  takes data from data as attributes and loads it into one HTML component to render
 */

//Morris testing

class Food {
    constructor(foodID, name, calories, protein, carbs, fat, image, description) {
        this.foodID = foodID
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
                <h5 class="food-name">${this.name}</h5>
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
}

function likeFood(foodID) {
    // this function will use AJAX to like or unlike the food on the database
    console.log(foodID)
}
class Food {
    constructor(image) {
        this.image = image
    }

    renderHTML() {
        return (`
            <div class="food-item">
                <img src="${this.image}" alt="Dot Hog" height="100" />
                <h6 class="food-title">Hot Dog</h6>
                <ul class="food-stats">
                    <li>Calories</li>
                    <li>Protein</li>
                    <li>Carbs</li>
                    <li>Fat</li>
                </ul>
                <p class="food-desc">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nibh ipsum consequat nisl vel pretium lectus quam. Sed felis eget velit aliquet sagittis id consectetur purus ut. Amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien. Molestie a iaculis at erat. At risus viverra adipiscing at in tellus integer feugiat. Feugiat pretium nibh ipsum consequat. Ornare suspendisse sed nisi lacus sed viverra tellus in hac. Aliquam ultrices sagittis orci a scelerisque purus semper. Sed turpis tincidunt id aliquet risus feugiat.</p>
            </div>
        `)
    }
}
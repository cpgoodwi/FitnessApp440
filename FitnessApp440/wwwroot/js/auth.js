/* Handling User Authentication AJAX */

// TODO: implement log out functionality (also mentioned in AuthController.cs)

$("#login-form").submit(function (e) {
    const form = $(this)
    values = form.serializeArray(); values.pop() // pop removes __RequestVerificationToken (hope its not important)
    console.log(values)

    if (isValidLogin(values)) {
        console.log(values[0].value)
        // document.cookie = `uid=${values[0].value};path=/`
        updateSession(values[0].value) // TODO: change this to working code
    } else {
        e.preventDefault()
        alert("invalid login")
    }
})

function isValidLogin(values) {
    return (values[0].value.length > 0 && values[1].value.length > 0)
}

$("#create-account").submit(function (e) {
    const form = $(this)
    values = form.serializeArray(); values.pop() // pop removes __RequestVerificationToken (hope its not important)

    if (isValidCreation(values)) {
        updateSession(values[0].value)
    } else {
        e.preventDefault()
        alert("invalid login")
    }
})

function isValidCreation(values) {
    return (values[0].value.length > 0 && values[1].value.length > 0 && values[1].value != values[2].value)
}
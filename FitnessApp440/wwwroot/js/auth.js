/* Handling User Authentication AJAX */

// TODO: implement log out functionality (also mentioned in AuthController.cs)

$("#login-form").submit(function (e) {
    const form = $(this)
    values = form.serializeArray(); values.pop() // pop removes __RequestVerificationToken (hope its not important)
    console.log(values)

    if (isValidLogin(values)) {
        $.ajax({
            type: "POST",
            url: "/Auth/LoginSubmit",
            dataType: "json",
            data: { username: values[0].value, password: values[1].value },
            success: function (result) {
                alert("you did it")
                document.cookie = `username=${values[0].value}; password=${values[1].value}`
            },
            error: function (req, status, error) {
                e.preventDefault()
                alert("something went wrong")
                console.log(status)
            }
        })
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
        $.ajax({
            type: "POST",
            url: "/Auth/CreateSubmit",
            dataType: "json",
            data: { username: values[0].value, password: values[1].value },
            success: function (result) {
                alert("you did it")
                document.cookie = `username=${values[0].value}; password=${values[1].value}`
            },
            error: function (req, status, error) {
                e.preventDefault()
                alert("something went wrong")
                console.log(status)
            }
        })
    } else {
        e.preventDefault()
        alert("invalid login")
    }
})

function isValidCreation(values) {
    return (values[0].value.length > 0 && values[1].value.length > 0 && values[1].value != values[2].value)
}
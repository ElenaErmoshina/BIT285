$(document).ready(function () {
    var baseUrl = "http://bit285login.azurewebsites.net/api/";
    // Store an array of users
    var users = [];

    // Bind users to the list
    var bindUsers = function (users) {
        for (i = 0; i < users.length; i++) {
            var li = $("<li></li>", { "id": users[i].userID, "title": "tooltip", "class": "user-record" });
            li.html(users[i].firstname + " " + users[i].lastname);
            li.appendTo("#user-list");
        }
    };

    // Make initial call to populate list
    $.ajax({
        url: baseUrl + "users",
        method: "GET"
    })
    .done(function (result) {
        bindUsers(result);
    });

    // Setup tooltip
    $(document).tooltip({
        items: "li",
        content: function (callback) {
            var element = $(this);
          
            if (element.attr("class") == "user-record") {
                // Making individual ajax call to get user by their ID
                $.ajax({
                    url: baseUrl + "users/" + element.attr("id"),
                    method: "GET"
                })
                .done(function (result) {
                    var l = $("<ul></ul>");
                    
                    $("<li></li>").html("Last login: " + result.last_login).appendTo(l);
                    $("<li></li>").html("Logged in: " + result.logged_in).appendTo(l);
                    $("<li></li>").html("IP Address: " + result.ipaddress).appendTo(l);

                    // the result is beenig sent back to the tooltip
                    callback(l);
                });
            }
            else {
                // Default value
                return "Tooltip"
            }
        }
    });
});
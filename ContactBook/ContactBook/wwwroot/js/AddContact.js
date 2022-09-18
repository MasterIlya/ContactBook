$('#form').submit(function (e) {
    $.ajax({
        url: "/Contacts/AddContact",
        method: "POST",
        data: {
            "Name": document.forms["form"].elements["Name"].value,
            "MobilePhone": document.forms["form"].elements["MobilePhone"].value,
            "JobTitle": document.forms["form"].elements["JobTitle"].value,
            "BirthDate": document.forms["form"].elements["BirthDate"].value
        },
        success: function (data) {
            if (data.answer != "Ok") {
                location.reload();
            }
    });
    e.preventDefault();
});
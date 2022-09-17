$('#form1').submit(function (e) {
    $.ajax({
        url: "/Contacts/EditContact",
        method: "POST",
        data: {
            "ContactId": document.forms['form1'].elements["IdEdit"].value,
            "Name": document.forms['form1'].elements["NameEdit"].value,
            "MobilePhone": document.forms['form1'].elements["MobilePhoneEdit"].value,
            "JobTitle": document.forms['form1'].elements["JobTitleEdit"].value,
            "BirthDate": document.forms['form1'].elements["BirthDateEdit"].value
        },
        success: function () {
            location.reload();
        }
    });
    e.preventDefault();
});
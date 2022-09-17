function GetContact(contactId) {
    $.ajax({
        dataType: "json",
        url: "/Contacts/GetContactForEdit",
        method: "GET",
        data: { id: contactId},
        success: function (data) {
            document.getElementById("NameEdit").value = data.name
            document.getElementById("MobilePhoneEdit").value = data.mobilePhone
            document.getElementById("JobTitleEdit").value = data.jobTitle

            var date = data.birthDate.substr(0, 10)

            document.getElementById("BirthDateEdit").value = date
            document.getElementById("IdEdit").value = data.contactId
        }
    });
}


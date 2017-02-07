(function () {
    'use strict';
    // Uncomment the following line to enable first chance exceptions.
    // Debug.enableFirstChanceException(true);

    function id(elementId) {
        return document.getElementById(elementId);
    }

    function appendField(fields, value, type, category) {
        if (value) {
            fields.append(new Windows.ApplicationModel.Contacts.ContactField(value, type, category));
        }
    }

    function contactFieldTest() {
        var contact = new Windows.ApplicationModel.Contacts.Contact();
        var value = "test@fabrikam.com";
        var type = Windows.ApplicationModel.Contacts.ContactFieldType.email;
        var category = Windows.ApplicationModel.Contacts.ContactFieldCategory.work;
        var contactField = new Windows.ApplicationModel.Contacts.ContactField(value, type, category);
        contact.fields.append(contactField);
    }

    function selectKnownFieldsEmailTest() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.email);
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            var contactData = contact.name + ", ";
            contactData += contact.emails[0].value + ", ";
            contactElement.innerText = contactData;
            document.body.appendChild(contactElement);
        });
    }

    function selectKnownFieldsTest() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.email);
        //picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.instantMessage);
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.location);
        //picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.phoneNumber);
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            var contactData = contact.name + ", ";
            contactData += contact.emails[0].value + ", ";
            //contactData += contact.instantMessages[0].userName + ", ";
            contactData += contact.locations[0].value + ", ";
            //contactData += contact.phoneNumbers[0].value;
            contactElement.innerText = contactData;
            document.body.appendChild(contactElement);
        });
    }

    WinJS.Application.onmainwindowactivated = function (e) {
        if (e.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            id("contactFieldTestButton").addEventListener("click", contactFieldTest);
            id("selectKnownFieldsEmailTestButton").addEventListener("click", selectKnownFieldsEmailTest);
            id("selectKnownFieldsTestButton").addEventListener("click", selectKnownFieldsTest);
        }
    }

    WinJS.Application.start();
})();
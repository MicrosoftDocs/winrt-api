//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

/// <reference path="base-sdk.js" />

(function () {
    function id(elementId) {
        return document.getElementById(elementId);
    }
    /* The following snippet is for use with our reference content */
    //<SnippetContactsSinglePicker>

    function selectContact() {
        // Create the picker
        var picker = new Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        //<SnippetContactsMain_SelectionMode>
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        //</SnippetContactsMain_SelectionMode>
        //<SnippetContactsMain_DesiredFields>
        picker.desiredFieldsWithContactFieldType.append(Windows.ApplicationModel.Contacts.ContactFieldType.email);    
        //</SnippetContactsMain_DesiredFields>

        // Open the picker for the user to select a contact
        //<SnippetContactsMain_LaunchPickerFields>
        picker.pickContactAsync().done(function (contact) {
            var contactElement = document.createElement("div");
            contactElement.innerText = contact.name + " " + contact.emails[0].address;
            document.body.appendChild(contactElement);
        });
        //</SnippetContactsMain_LaunchPickerFields>
    }

    //</SnippetContactsSinglePicker>


    //<SnippetContactsSinglePickerBasic>
    function selectContact() {
        //<SnippetContactsMain_GetContactPickerInstance>
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        //</SnippetContactsMain_GetContactPickerInstance>
        //<SnippetContactsMain_NameCommitButton>
        picker.commitButtonText = "Select";
        //</SnippetContactsMain_NameCommitButton>
        //<SnippetContactsMain_LaunchPicker>
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            contactElement.innerText = contact.name + " " + contact.emails[0].value;
            document.body.appendChild(contactElement);
        });
        //</SnippetContactsMain_LaunchPicker>
    }
    //</SnippetContactsSinglePickerBasic>

    //<SnippetContactFieldTest>
    function contactFieldTest() {
        var contact = new Windows.ApplicationModel.Contacts.Contact();
        var value = "test@fabrikam.com";
        var type = Windows.ApplicationModel.Contacts.ContactFieldType.email;
        var category = Windows.ApplicationModel.Contacts.ContactFieldCategory.work;
        var contactField = new Windows.ApplicationModel.Contacts.ContactField(value, type, category);
        contact.fields.append(contactField);
    }
    //</SnippetContactFieldTest>
    //<SnippetContactsKnownFields>
    function selectKnownFields() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.email);
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.instantMessage);
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.location);
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.phoneNumber);
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            var contactData = contact.name + ", ";
            contactData += contact.emails[0].value + ", ";
            contactData += contact.instantMessages[0].value + ", ";
            contactData += contact.locations[0].value + ", ";
            contactData += contact.phoneNumbers[0].value;
            contactElement.innerText = contactData;
            document.body.appendChild(contactElement);
        });
    }
    //</SnippetContactsKnownFields>

    //<SnippetContactsKnownFields_Email>
    function selectKnownFields() {
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
    //</SnippetContactsKnownFields_Email>

    //<SnippetContactsKnownFields_IM>
    function getInstantMessageInfo() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.instantMessage);
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            var contactData = contact.name + "<br/>";
            contactData += contact.instantMessages[0].displayText + "<br/>";
            contactData += contact.instantMessages[0].launchUri + "<br/>";
            contactData += contact.instantMessages[0].service + "<br/>";
            contactData += contact.instantMessages[0].userName + "<br/>";
            contactData += contact.instantMessages[0].category + "<br/>";
            contactData += contact.instantMessages[0].type;
            contactElement.innerHTML = contactData;
            document.body.appendChild(contactElement);
        });
    }
    //</SnippetContactsKnownFields_IM>

    //<SnippetContactsKnownFields_location>
    function getLocation() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.location);
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            var contactData = contact.name + "<br/>";
            contactData += contact.locations[0].city + "<br/>";
            contactData += contact.locations[0].country + "<br/>";
            contactData += contact.locations[0].postalcode + "<br/>";
            contactData += contact.locations[0].region = "<br/>";
            contactData += contact.locations[0].street + "<br/>";
            contactData += contact.instantMessages[0].category + "<br/>";
            contactData += contact.instantMessages[0].type;
            contactElement.innerHTML = contactData;
            document.body.appendChild(contactElement);
        });
    }
    //</SnippetContactsKnownFields_location>
    //<SnippetContactsKnownFields_location_unstructured>
    function selectKnownFields() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.location);
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            var contactData = contact.name + "<br/>";
            contactData += contact.locations[0].unstructuredAddress;
            contactElement.innerHTML = contactData;
            document.body.appendChild(contactElement);
        });
    }
    //</SnippetContactsKnownFields_location_unstructured>

    //<SnippetContactsKnownFields_phone>
    function selectKnownFields() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        picker.selectionMode = Windows.ApplicationModel.Contacts.ContactSelectionMode.fields;
        picker.desiredFields.append(Windows.ApplicationModel.Contacts.KnownContactField.phoneNumber);
        picker.pickSingleContactAsync().then(function (contact) {
            var contactElement = document.createElement("div");
            var contactData = contact.name + ", ";
            contactData += contact.phoneNumbers[0].value + ", ";
            contactElement.innerText = contactData;
            document.body.appendChild(contactElement);
        });
    }
    //</SnippetContactsKnownFields_phone>

    //<SnippetContactsMultiPicker>
    function selectContacts() {
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";
        //<SnippetContactsMain_LaunchPickerMultiple>
        picker.pickMultipleContactsAsync().then(function (contacts) {
            contacts.forEach(function (contact) {
                var contactElement = document.createElement("div");
                contactElement.innerText = contact.name;
            });
        });
        //</SnippetContactsMain_LaunchPickerMultiple>
    }
    //</SnippetContactsMultiPicker>
    function selectSingleContact() {
        // Set up the picker
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";

        // Launch the picker
        picker.pickSingleContactAsync().then(function (contact) {
            // Display the fields on the contact
            appendContact(contact, id("scenario1Contacts"));
        });
    }

    function selectMultipleContacts() {
        id("scenario2Contacts").innerHTML = "";

        // Set up the picker
        var picker = Windows.ApplicationModel.Contacts.ContactPicker();
        picker.commitButtonText = "Select";

        // Launch the picker
        picker.pickMultipleContactsAsync().then(function (contacts) {
            contacts.forEach(function (contact) {
                appendContact(contact, id("scenario2Contacts"));
            });
        });
    }

    function appendContact(contact, container) {
        // Creates UI for a contact returned from the picker and adds it to the page
        var contactElement = document.createElement("div");
        contactElement.className = "contact";
        container.appendChild(contactElement);

        // Display the name
        contactElement.appendChild(createTextElement("h3", contact.name));

        // Add the different types of contact data
        appendFields("Emails", contact.emails, contactElement);
        appendFields("Phone Numbers", contact.phoneNumbers, contactElement);
        appendFields("Addresses", contact.locations, contactElement);
    }

    function appendFields(title, fields, container) {
        // Creates UI for a list of contact fields of the same type, e.g. emails or phones
        if (fields.length > 0) {
            container.appendChild(createTextElement("h4", title));

            fields.forEach(function (field) {
                switch (field.category) {
                    case Windows.ApplicationModel.Contacts.ContactFieldCategory.home:
                        container.appendChild(createTextElement("div", field.value + " (home)"));
                        break;
                    case Windows.ApplicationModel.Contacts.ContactFieldCategory.work:
                        container.appendChild(createTextElement("div", field.value + " (work)"));
                        break;
                    case Windows.ApplicationModel.Contacts.ContactFieldCategory.mobile:
                        container.appendChild(createTextElement("div", field.value + " (mobile)"));
                        break;
                    case Windows.ApplicationModel.Contacts.ContactFieldCategory.other:
                        container.appendChild(createTextElement("div", field.value + " (other)"));
                        break;
                    case Windows.ApplicationModel.Contacts.ContactFieldCategory.none:
                    default:
                        container.appendChild(createTextElement("div", field.value));
                        break;
                }
            });
        }
    }

    //<SnippetContactsCreateTextElement>
    function createTextElement(tag, id, text) {
        var element = document.createElement(tag);
        element.className = "singleLineText";
        element.innerText = text;
        return element;
    }
    //</SnippetContactsCreateTextElement>

    /**** THE FOLLOWING CODE NEEDS TO BE TESTED **/
    //<SnippetContactsNameProperty>
    function getFirstAndLastName(contact) {
        var name = contact.name;
        if (name.indexOf(" ") != -1) {
            var firstAndLast = name.split(" ");
            return {
                first: firstAndLast[0],
                last: firstAndLast[1]
            };
        } else {
            return null;
        }
    }
    //</SnippetContactsNameProperty>

    function initialize() {
        // Add any initialization code here

        //id("scenario1Open").addEventListener("click", selectSingleContact, false);
        id("scenario1Open").addEventListener("click", selectContact, false);
        id("scenario2Open").addEventListener("click", selectMultipleContacts, false);
        //id("scenarios").addEventListener("change", onScenarioChanged, false);
    }

    function onScenarioChanged() {
        sdkSample.displayStatus("");
    }


    // <SnippetContactClass>
    function addContactToBasket(sampleContact) {
        // Programmatically add the contact to the basket

        // Apply the sample data onto the contact object
        var contact = new Windows.ApplicationModel.Contacts.Contact();
        contact.name = sampleContact.name;

        appendEmail(contact.fields, sampleContact.homeEmail, Windows.ApplicationModel.Contacts.ContactFieldCategory.home);
        appendEmail(contact.fields, sampleContact.workEmail, Windows.ApplicationModel.Contacts.ContactFieldCategory.work);

        appendPhoneNumber(contact.fields, sampleContact.homePhone, Windows.ApplicationModel.Contacts.ContactFieldCategory.home);
        appendPhoneNumber(contact.fields, sampleContact.workPhone, Windows.ApplicationModel.Contacts.ContactFieldCategory.work);
        appendPhoneNumber(contact.fields, sampleContact.mobilePhone, Windows.ApplicationModel.Contacts.ContactFieldCategory.mobile);

        appendAddress(contact.fields, sampleContact.address, Windows.ApplicationModel.Contacts.ContactFieldCategory.none);

        // Add the contact to the basket
        var statusMessage = document.getElementById("statusMessage");
        switch (contactPickerUI.addContact(sampleContact.id, contact)) {
            case Windows.ApplicationModel.Contacts.Provider.AddContactResult.added:
                // Notify user that the contact was added to the basket
                statusMessage.innerText = sampleContact.name + " was added to the basket";
                break;
            case Windows.ApplicationModel.Contacts.Provider.AddContactResult.alreadyAdded:
                // Notify the user that the contact is already in the basket
                statusMessage.innerText = sampleContact.name + " is already in the basket";
                break;
            case Windows.ApplicationModel.Contacts.Provider.AddContactResult.unavailable:
            default:
                // Notify the user that the basket is not currently available
                statusMessage.innerText = sampleContact.name + " could not be added to the basket";
                break;
        }
    }
    // </SnippetContactClass>




    document.addEventListener("DOMContentLoaded", initialize, false);

})();


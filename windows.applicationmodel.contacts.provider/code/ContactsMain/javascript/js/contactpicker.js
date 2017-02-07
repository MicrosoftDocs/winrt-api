//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

/// <reference path="base-sdk.js" />

(function () {
    var basket;

    function id(elementId) {
        return document.getElementById(elementId);
    }

    //<SnippetContactPickerBasketAppendField>
    function appendField(fields, value, type, category) {
        if (value) {
            fields.append(new Windows.ApplicationModel.Contacts.ContactField(value, type, category));
        }
    }
    //</SnippetContactPickerBasketAppendField>

    //<SnippetContactPickerBasketAppendEmail>
    function appendEmail(fields, email, category) {
        // Adds a new email to the contact fields vector
        appendField(fields, email, Windows.ApplicationModel.Contacts.ContactFieldType.email, category);
    }
    //</SnippetContactPickerBasketAppendEmail>

    //<SnippetContactPickerBasketAppendPhoneNumber>
    function appendPhoneNumber(fields, phone, category) {
        // Adds a new phone number to the contact fields vector
        appendField(fields, phone, Windows.ApplicationModel.Contacts.ContactFieldType.phoneNumber, category);
    }
    //</SnippetContactPickerBasketAppendPhoneNumber>

    //<SnippetContactPickerBasketAppendAddress>
    function appendAddress(fields, address, category) {
        // Adds a new address to the contact fields vector
        if (address) {
            fields.append(new Windows.ApplicationModel.Contacts.ContactLocationField(
                            address.full, category, address.street, address.city, address.state, "", address.zipCode));
        }
    }
    //</SnippetContactPickerBasketAppendAddress>

    /** THE FOLLOWING NEEDS TO BE TESTED **/
    //<SnippetContactConstructor>
    function createContact() {
        var contact = new Windows.ApplicationModel.Contacts.Contact();
        return contact;
    }
    //</SnippetContactConstructor>

    //<SnippetContactPickerBasketCreateForBasket>
    function createContactForBasket(sampleContact) {

        // Transfer contact data to a Contact object
        var contact = new Windows.ApplicationModel.Contacts.Contact();
        contact.firstName = sampleContact.firstName;
        contact.lastName = sampleContact.lastName;
        contact.id = sampleContact.id;

        // Add the personal email address to the Contact object’s emails vector
        var personalEmail = new Windows.ApplicationModel.Contacts.ContactEmail();
        personalEmail.address = sampleContact.personalEmail;
        personalEmail.kind = Windows.ApplicationModel.Contacts.ContactEmailKind.personal;
        contact.emails.append(personalEmail);

        // Adds the home phone number to the Contact object’s phones vector
        var homePhone = new Windows.ApplicationModel.Contacts.ContactPhone();
        homePhone.number = sampleContact.homePhone;
        homePhone.kind = Windows.ApplicationModel.Contacts.ContactPhoneKind.home;
        contact.phones.append(homePhone);

        // Adds the address to the Contact object’s addresses vector
        var homeAddress = new Windows.ApplicationModel.Contacts.ContactAddress();
        homeAddress.streetAddress = sampleContact.address.street;
        homeAddress.locality = sampleContact.address.city;
        homeAddress.region = sampleContact.address.state;
        homeAddress.postalCode = sampleContact.address.zipCode;
        homeAddress.kind = Windows.ApplicationModel.Contacts.ContactAddressKind.home;
        contact.addresses.append(homeAddress);

        // Sets the thumbnail for the contact from path
        Windows.ApplicationModel.Package.current.installedLocation.getFileAsync(sampleContact.image).then(
              function (imageFile) {
                     var streamReference = Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(imageFile);
                     contact.thumbnail = randomAccessStreamReference;
              });

        return contact;
    }
    //</SnippetContactPickerBasketCreateForBasket>

    //<SnippetContactPickerBasketAddToBasket>
    function addContactToBasket(appContact) {
        var addToBasketResult = document.createElement("div");
        switch (basket.addContact(appContact.id, createContactForBasket(appContact))) {
            case Windows.ApplicationModel.Contacts.Provider.AddContactToBasketResult.addedToBasket:
                addToBasketResult.innerText = "Contact " + appContactid + " added to basket.";
            case Windows.ApplicationModel.Contacts.Provider.AddContactToBasketResult.alreadyInBasket:
                addToBasketResult.innerText = "Contact " + appContactid + " already exists in basket.";
                break;
            case Windows.ApplicationModel.Contacts.Provider.AddContactToBasketResult.basketUnavailable:
                addToBasketResult.innerText = "Basket Unavailable";
        }
        document.body.appendChild(addToBasketResult);
    }
    //</SnippetContactPickerBasketAddToBasket>

    //<SnippetContactPickerBasketContains_Remove>
    function removeContactFromBasket(appContact) {
        if (basket.containsContact(appContact.id)) {
            basket.removeContact(appContact.id);
            var removedContactDiv = document.createElement("div");
            removedContactDiv.innerText = "Contact ID: " + e.id + " has been removed.";
            document.body.appendChild(removedContactDiv);
        } 
    }
    //</SnippetContactPickerBasketContains_Remove>

    function onContactRemovedFromBasketUI(e) {
        updateSelectionState(e.id, false);
    }
    /* Demonstrates the use of the ContactRemovedEventArgs class and its id property.*/
    //<SnippetContactPickerBasketContactRemoved>
    function onContactRemovedFromBasket(e) {
        var removedContactDiv = document.createElement("div");
        removedContactDiv.innerText = "Contact ID: " + e.id + " has been removed.";
        document.body.appendChild(removedContactDiv);
    }
    //</SnippetContactPickerBasketContactRemoved>

    function updateSelectionState(contactId, selected) {
        // Set the appropriate check box state
        id(contactId).checked = selected;
    }
        /* The following snippet shows how to get an instance of the ContactPickerBasket object. It also shows how to add an event handler for the contactremoved event. */
        //<SnippetContactPickerBasketSetup>
    function onActivation(e) {

        if (e.kind == Windows.ApplicationModel.Activation.ActivationKind.contactPicker) {
            basket = e.basket;
            basket.addEventListener("contactremoved", onContactRemovedFromBasketUI, false);
            basket.addEventListener("contactremoved", onContactRemovedFromBasket, false);
        }

    }
    //</SnippetContactPickerBasketSetup>
    function initialize() {
        // Add any initialization code here

        //contactStore.forEach(addContactUI);

        //id("scenarios").addEventListener("change", onScenarioChanged, false);
    }

    function addContactUI(appContact, index) {
        // Adds a UI checkbox for a contact so that it can added or removed from the basket

        var element = document.createElement("div");
        id("scenario1Contacts").appendChild(element);
        element.innerHTML = "<input id='" + appContact.id + "' value='" + index + "' type='checkbox' />" + appContact.name;

        element.firstElementChild.addEventListener("change", function (ev) {
            if (ev.target.checked) {
                addContactToBasket(appContact);
            } else {
                removeContactFromBasket(appContact);
            }
        }, false);
    }

    function onScenarioChanged() {
        sdkSample.displayStatus("");
    }

    document.addEventListener("DOMContentLoaded", initialize, false);
    //<SnippetContactPickerBasketActivatedEventListener>
    Windows.UI.WebUI.WebUIApplication.addEventListener("activated", onActivation, false);
    //</SnippetContactPickerBasketActivatedEventListener>

    // A single contact object
    //<SnippetAppContactExample>
    var sampleContacts = [
        {
            firstName: "Kim",
            lastName: "Abercrombie",
            image: "KimAbercrombie.jpg",
            personalEmail: "kim@contoso.com",
            homePhone: "921 555-0187",
            address: {
                full: "123 Main St, Redmond WA, 23456",
                street: "123 Main St",
                city: "Redmond",
                state: "WA",
                zipCode: "23456"
            },
            id: "49b0652e-8f39-48c5-853b-e5e94e6b8a11"
        }
];
    //</SnippetAppContactExample>

    // Sample set of contacts to pick from
    var contactStore = [
    {
        name: "David Jaffe",
        homeEmail: "david@contoso.com",
        workEmail: "david@cpandl.com",
        homePhone: "",
        workPhone: "",
        homePhone: "248-555-0150",
        address: {
            full: "3456 Broadway Ln, Los Angeles, CA",
            street: "",
            city: "",
            state: "",
            zipCode: ""
        },
        id: "761cb6fb-0270-451e-8725-bb575eeb24d5"
    },

    {
        name: "Kim Abercrombie",
        homeEmail: "kim@contoso.com",
        workEmail: "kim@adatum.com",
        homePhone: "444 555-0001",
        workPhone: "245 555-0123",
        mobilePhone: "921 555-0187",
        address: {
            full: "123 Main St, Redmond, WA 23456",
            street: "123 Main St",
            city: "Redmond",
            state: "WA",
            zipCode: "23456"
        },
        id: "49b0652e-8f39-48c5-853b-e5e94e6b8a11"
    },

    {
        name: "Jeff Phillips",
        homeEmail: "jeff@contoso.com",
        workEmail: "jeff@fabrikam.com",
        homePhone: "987-555-0199",
        workPhone: "",
        mobilePhone: "543-555-0111",
        address: {
            full: "456 2nd Ave, Dallas, TX 12345",
            street: "456 2nd Ave",
            city: "Dallas",
            state: "TX",
            zipCode: "12345"
        },
        id: "864abfb4-8998-4355-8236-8d69e47ec832"
    },

    {
        name: "Arlene Huff",
        homeEmail: "arlene@contoso.com",
        workEmail: "",
        homePhone: "",
        workPhone: "",
        mobilePhone: "234-555-0156",
        address: null,
        id: "27347af8-0e92-45b8-b14c-dd70fcd3b4a6"
    },

    {
        name: "Miles Reid",
        homeEmail: "miles@contoso.com",
        workEmail: "miles@proseware.com",
        homePhone: "",
        workPhone: "",
        mobilePhone: "",
        address: {
            full: "678 Elm St, New York, New York 95111",
            street: "678 Elm St",
            city: "New York",
            state: "New York",
            zipCode: "95111"
        },
        id: "e3d24a99-0e29-41af-9add-18f5e3cfc518"
    },
    ];

})();

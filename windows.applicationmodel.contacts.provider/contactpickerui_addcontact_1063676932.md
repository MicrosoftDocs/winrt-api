---
-api-id: M:Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.AddContact(System.String,Windows.ApplicationModel.Contacts.Contact)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.Provider.AddContactResult AddContact(System.String id, Windows.ApplicationModel.Contacts.Contact contact)
-->

# Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.AddContact

## -description
> [!NOTE]
> AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use [AddContact](contactpickerui_addcontact_79336216.md) without the ID.

Adds a [Contact](../windows.applicationmodel.contacts/contact.md).

## -parameters
### -param id
The ID for the contact.

### -param contact
An object that contains the contact's information.

## -returns
An [AddContactResult](addcontactresult.md)-typed value that indicates whether the contact was added successfully.

## -remarks

## -examples
This example code adds a contact to the contact picker.

```javascript
function addContact (sampleContact) {
// Generate the Contact object to be added
var contact = createContactForBasket(sampleContact);

// Add the Contact object to the basket
var statusMessage = document.getElementById("statusMessage");
     switch (contactPickerUI.addContact(contact)) {
     case Windows.ApplicationModel.Contacts.Provider.AddContactResult.added:
         // Notify user that the contact was added to the basket
         statusMessage.innerText = contact.displayName + " was added to the basket";
         break;
     case Windows.ApplicationModel.Contacts.Provider.AddContactResult.alreadyAdded:
         // Notify the user that the contact is already in the basket
         statusMessage.innerText = contact.displayName + " is already in the basket";
         break;
     case Windows.ApplicationModel.Contacts.Provider.AddContactResult.unavailable:
     default:
         // Notify the user that the basket is not currently available
         statusMessage.innerText = contact.displayName + " could not be added to the basket";
         break;
    }
}

```



## -see-also
[AddContact(Contact)](contactpickerui_addcontact_79336216.md)
## -capabilities
contactsSystem

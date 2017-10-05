---
-api-id: E:Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.ContactRemoved
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ContactRemoved<Windows.ApplicationModel.Contacts.Provider.ContactPickerUI,  Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs>
-->

# Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.ContactRemoved

## -description
Occurs when the user deselects or removes the contact.

## -remarks


## -examples


```javascript

var contactPickerUI = null;  

function activatedHandler(ev) {  
    if (ev.detail[0].kind == Windows.ApplicationModel.Activation.ActivationKind.contactPicker) {  
        contactPickerUI = ev.detail[0].contactPickerUI;  
        contactPickerUI.addEventListener("contactremoved", onContactRemoved);  
    }  
}

function onContactRemoved(e) {
    var contactId = e.id;

    // TODO: Respond to removal of this contact.

}
```



## -see-also

## -capabilities
contactsSystem

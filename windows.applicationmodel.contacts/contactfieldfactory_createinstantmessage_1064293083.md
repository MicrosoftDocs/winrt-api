---
-api-id: M:Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateInstantMessage(System.String,Windows.ApplicationModel.Contacts.ContactFieldCategory)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactInstantMessageField CreateInstantMessage(System.String userName, Windows.ApplicationModel.Contacts.ContactFieldCategory category)
-->

# Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateInstantMessage

## -description

Creates a field to contain information about a contact's instant messaging account.

> [!NOTE]
> [IContactInstantMessageFieldFactory](icontactinstantmessagefieldfactory.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactConnectedServiceAccount](contactconnectedserviceaccount.md).

## -parameters
### -param userName
The user name for the instant messaging account.

### -param category
The category the field belongs to.

## -returns
Contains an instant messaging field that you can add to a [Contact](contact.md) object.

## -remarks

## -examples

## -see-also
[CreateInstantMessage(String)](contactfieldfactory_createinstantmessage_2022649811.md), [CreateInstantMessage(String, ContactFieldCategory, String, String, Uri)](contactfieldfactory_createinstantmessage_1039910149.md)
## -capabilities
contactsSystem

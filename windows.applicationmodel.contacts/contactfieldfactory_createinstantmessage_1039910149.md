---
-api-id: M:Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateInstantMessage(System.String,Windows.ApplicationModel.Contacts.ContactFieldCategory,System.String,System.String,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactInstantMessageField CreateInstantMessage(System.String userName, Windows.ApplicationModel.Contacts.ContactFieldCategory category, System.String service, System.String displayText, Windows.Foundation.Uri verb)
-->

# Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateInstantMessage

## -description

Creates a field to contain information about a contact's instant messaging account.

> [!NOTE]
> [IContactInstantMessageFieldFactory](icontactinstantmessagefieldfactory.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactConnectedServiceAccount](contactconnectedserviceaccount.md).

## -parameters
### -param userName
The user name of the instant messaging account.

### -param category
The category the field belongs to.

### -param service
The name of the instant messaging service.

### -param displayText
The text to display to prompt an instant messaging conversation.

### -param verb
The Uniform Resource Identifier (URI) that starts an instant messaging conversation.

## -returns
Contains an instant messaging field that you can add to a [Contact](contact.md) object.

## -remarks

## -examples

## -see-also
[CreateInstantMessage(String)](contactfieldfactory_createinstantmessage_2022649811.md), [CreateInstantMessage(String, ContactFieldCategory)](contactfieldfactory_createinstantmessage_1064293083.md)
## -capabilities
contactsSystem

---
-api-id: T:Windows.ApplicationModel.Contacts.ContactBatch
-api-type: winrt class
---

<!-- Class syntax.
public class ContactBatch : Windows.ApplicationModel.Contacts.IContactBatch
-->

# Windows.ApplicationModel.Contacts.ContactBatch

## -description
Represents a group of [Contact](contact.md) objects and server search status.

## -remarks
If you are searching local contacts, keep processing until you get a ContactBatch that has an empty list of [Contacts](contactbatch_contacts.md). If you are searching on a server and you get an empty [Contacts](contactbatch_contacts.md) list, check the [Status](contactbatch_status.md) to make sure there wasn't a server error.

## -examples

## -see-also

## -capabilities
contactsSystem

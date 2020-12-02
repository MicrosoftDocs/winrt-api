---
-api-id: M:Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateLocation(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactLocationField CreateLocation(System.String unstructuredAddress)
-->

# Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateLocation

## -description

Creates a field to contain information about a contact's location.

> [!NOTE]
> [IContactLocationFieldFactory](icontactlocationfieldfactory.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md).

## -parameters
### -param unstructuredAddress
The address of the contact in an unstructured format.

## -returns
Contains a location field that you can add to a [Contact](contact.md) object.

## -remarks

## -examples

## -see-also
[CreateLocation(String, ContactFieldCategory)](contactfieldfactory_createlocation_966869216.md), [CreateLocation(String, ContactFieldCategory, String, String, String, String, String)](contactfieldfactory_createlocation_1542951776.md)
## -capabilities
contactsSystem

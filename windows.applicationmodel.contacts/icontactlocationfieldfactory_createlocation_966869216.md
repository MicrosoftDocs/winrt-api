---
-api-id: M:Windows.ApplicationModel.Contacts.IContactLocationFieldFactory.CreateLocation(System.String,Windows.ApplicationModel.Contacts.ContactFieldCategory)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactLocationField CreateLocation(System.String unstructuredAddress, Windows.ApplicationModel.Contacts.ContactFieldCategory category)
-->

# Windows.ApplicationModel.Contacts.IContactLocationFieldFactory.CreateLocation

## -description

Creates a field to contain information about a contact's location.

> [!NOTE]
> [IContactLocationFieldFactory](icontactlocationfieldfactory.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md).

## -parameters
### -param unstructuredAddress
The address of the contact in an unstructured format.

### -param category
The category the field belongs to.

## -returns
A location field that you can add to a [Contact](contact.md) object.

## -remarks

## -examples

## -see-also
[CreateLocation(String)](icontactlocationfieldfactory_createlocation_2118237656.md), [CreateLocation(String, ContactFieldCategory, String, String, String, String, String)](icontactlocationfieldfactory_createlocation_1542951776.md)
## -capabilities
contactsSystem

---
-api-id: M:Windows.ApplicationModel.Contacts.IContactLocationFieldFactory.CreateLocation(System.String,Windows.ApplicationModel.Contacts.ContactFieldCategory,System.String,System.String,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactLocationField CreateLocation(System.String unstructuredAddress, Windows.ApplicationModel.Contacts.ContactFieldCategory category, System.String street, System.String city, System.String region, System.String country, System.String postalCode)
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

### -param street
The street address.

### -param city
The name of the city for the address.

### -param region
The name of the region for the address.

### -param country
The name of the country for the address.

### -param postalCode
The postal code for the address.

## -returns
A location field that you can add to a [Contact](contact.md) object.

## -remarks

## -examples

## -see-also
[CreateLocation(String)](icontactlocationfieldfactory_createlocation_2118237656.md), [CreateLocation(String, ContactFieldCategory)](icontactlocationfieldfactory_createlocation_966869216.md)
## -capabilities
contactsSystem

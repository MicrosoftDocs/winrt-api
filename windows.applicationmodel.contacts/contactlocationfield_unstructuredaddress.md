---
-api-id: P:Windows.ApplicationModel.Contacts.ContactLocationField.UnstructuredAddress
-api-type: winrt property
---

<!-- Property syntax
public string UnstructuredAddress { get; }
-->

# Windows.ApplicationModel.Contacts.ContactLocationField.UnstructuredAddress

## -description

Gets a string that represents an unstructured address.

> [!NOTE]
> [ContactLocationField](contactlocationfield.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md).

## -property-value
The address of the contact in an unstructured format.

## -remarks
If the contact-providing application includes an address, but doesn't specify elements such as [PostalCode](contactlocationfield_postalcode.md) or [City](contactlocationfield_city.md), the data is put in the UnstructuredAddress property.

## -examples

## -see-also

## -capabilities
contactsSystem

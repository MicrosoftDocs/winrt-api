---
-api-id: P:Windows.ApplicationModel.Calls.PhoneDialOptions.Contact
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Contacts.Contact Contact { get;  set; }
-->

# Windows.ApplicationModel.Calls.PhoneDialOptions.Contact

## -description
Gets or sets the address book contact associated with a dial request.

## -property-value
The address book contact associated with a dial request.

## -remarks
If you are supplying an [IContact](/previous-versions/aa912125(v=msdn.10)) as the Contact, then you need to make sure it is a component contact and not an aggregate contact. This will make sure that the correct contact is reached when you attempt to place a call using these [PhoneDialOptions](phonedialoptions.md). Otherwise, the additional information in the contact will be lost and a lookup will be performed using only the number. This might result in the incorrect contact being selected if multiple contacts share the same number but have different metadata.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem

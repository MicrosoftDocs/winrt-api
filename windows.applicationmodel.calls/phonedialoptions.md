---
-api-id: T:Windows.ApplicationModel.Calls.PhoneDialOptions
-api-type: winrt class
---

<!-- Class syntax.
public class PhoneDialOptions : Windows.ApplicationModel.Calls.IPhoneDialOptions
-->

# Windows.ApplicationModel.Calls.PhoneDialOptions

## -description
Represents options for dialing a call.

## -remarks
If you are supplying an [IContact](/previous-versions/aa912125(v=msdn.10)) as the [Contact](phonedialoptions_contact.md), then you need to make sure it is a component contact and not an aggregate contact. This will make sure that the correct contact is reached when you attempt to place a call using these PhoneDialOptions. Otherwise, the additional information in the contact will be lost and a lookup will be performed using only the number. This might result in the incorrect contact being selected if multiple contacts share the same number but have different metadata.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem

---
-api-id: P:Windows.Phone.PersonalInformation.StoredContact.RemoteId
-api-type: winrt property
---

<!-- Property syntax
public string RemoteId { get;  set; }
-->

# Windows.Phone.PersonalInformation.StoredContact.RemoteId

## -description
Gets the remote identifier of the stored contact.

## -property-value
The remote identifier of the contact.

## -remarks
Use this property to associate the [Id](storedcontact_id.md) of the contact with the identifier used by a remote, cloud-based contact store. The value of this property must be stable and must be unique across all apps on the phone. Attempting to save a contact may fail if the RemoteId property is not unique on the phone.

## -examples

## -see-also
[Implementing contact bindings in a Windows Phone Silverlight 8.1 app](/previous-versions/windows/apps/dn642083(v=vs.105))

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

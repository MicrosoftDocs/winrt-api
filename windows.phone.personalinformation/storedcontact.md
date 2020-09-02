---
-api-id: T:Windows.Phone.PersonalInformation.StoredContact
-api-type: winrt class
---

<!-- Class syntax.
public class StoredContact : Windows.Phone.PersonalInformation.IContactInformation, Windows.Phone.PersonalInformation.IContactInformation2, Windows.Phone.PersonalInformation.IStoredContact
-->

# Windows.Phone.PersonalInformation.StoredContact

## -description
Represents a contact associated with a custom contact store.

## -remarks
You must open your app's contact store in order to obtain a StoredContact object. To work with contact information that is not yet associated with a store or to parse contact information from a vCard, use the [ContactInformation](contactinformation.md) class.

These APIs create or obtain a StoredContact object:
+ [ContactStore.CreateMeContactAsync](contactstore_createmecontactasync_367847777.md)
+ [ContactStore.FindContactByIdAsync](contactstore_findcontactbyidasync_682238637.md)
+ [ContactStore.FindContactByRemoteIdAsync](contactstore_findcontactbyremoteidasync_1811337011.md)
+ [ContactQueryResult.GetContactsAsync](contactqueryresult_getcontactsasync_1004597153.md) (returns a collection)


## -examples

## -see-also
[IContactInformation](icontactinformation.md), [ContactStore class](contactstore.md), [Implementing contact bindings in a Windows Phone Silverlight 8.1 app](/previous-versions/windows/apps/dn642083(v=vs.105))

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

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
You must open your app's contact store in order to obtain a [StoredContact](storedcontact.md) object. To work with contact information that is not yet associated with a store or to parse contact information from a vCard, use the [ContactInformation](contactinformation.md) class.

These APIs create or obtain a [StoredContact](storedcontact.md) object:
+ [ContactStore.CreateMeContactAsync](contactstore_createmecontactasync.md)
+ [ContactStore.FindContactByIdAsync](contactstore_findcontactbyidasync.md)
+ [ContactStore.FindContactByRemoteIdAsync](contactstore_findcontactbyremoteidasync.md)
+ [ContactQueryResult.GetContactsAsync](contactqueryresult_getcontactsasync.md) (returns a collection)


## -examples

## -see-also
[IContactInformation](icontactinformation.md), [ContactStore class](contactstore.md), [Implementing contact bindings in a Windows Phone Silverlight 8.1 app](https://msdn.microsoft.com/en-us/library/windows/apps/dn642083(v=vs.105).aspx)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

---
-api-id: T:Windows.Phone.PersonalInformation.ContactInformation
-api-type: winrt class
---

<!-- Class syntax.
public class ContactInformation : Windows.Phone.PersonalInformation.IContactInformation
-->

# Windows.Phone.PersonalInformation.ContactInformation

## -description
Represents a contact without an association to a contact store.

## -remarks
This class is used to store information about a contact. It has a set of commonly used built-in properties like a family name and a description, and it also allows you to store custom properties as name/value pairs. The [StoredContact](storedcontact.md) class shares all of these properties but it requires you to open your app's custom contact store before you can obtain an instance of the class. Many applications will use [StoredContact](storedcontact.md) directly and never need to use ContactInformation. If you need to temporarily store contact information without opening your contact store or if you need to parse contact information from a vCard using [ParseVcardAsync](contactinformation_parsevcardasync_392056483.md), you can use ContactInformation and then pass the object to the [StoredContact](storedcontact_storedcontact_1100165694.md) constructor.

## -examples

## -see-also
[IContactInformation](icontactinformation.md), [Implementing contact bindings in a Windows Phone Silverlight 8.1 app](/previous-versions/windows/apps/dn642083(v=vs.105))

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

---
-api-id: T:Windows.Phone.PersonalInformation.ContactQueryResultOrdering
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.PersonalInformation.ContactQueryResultOrdering : int
-->

# ContactQueryResultOrdering

## -description
Specifies the order in which contacts are returned from a [CreateContactQuery](contactstore_createcontactquery_964460747.md) call.

## -enum-fields
### -field SystemDefault:0
The default ordering used by the operating system.

### -field GivenNameFamilyName:1
Order by given name and then family name.

### -field FamilyNameGivenName:2
Order by family name and then given name.


## -remarks
The results are returned as a [ContactQueryResult](contactqueryresult.md) object, and the order of results is manifested when you call [GetContactsAsync](contactqueryresult_getcontactsasync.md).

## -examples

## -see-also
[ContactQueryResult](contactqueryresult.md)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

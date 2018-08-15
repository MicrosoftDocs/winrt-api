---
-api-id: M:Windows.ApplicationModel.Contacts.DataProvider.ContactListServerSearchReadBatchRequest.SaveContactAsync(Windows.ApplicationModel.Contacts.Contact)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SaveContactAsync(Windows.ApplicationModel.Contacts.Contact contact)
-->

# Windows.ApplicationModel.Contacts.DataProvider.ContactListServerSearchReadBatchRequest.SaveContactAsync

## -description
Asynchronously saves a contact that meets server-side search criteria.

When a server-side search is requested, the data provider performs the search, calls [SaveContactAsync](contactlistserversearchreadbatchrequest_savecontactasync_64942310.md) on each contact found, and then calls [ReportCompletedAsync.](contactlistserversearchreadbatchrequest_reportcompletedasync_1707664681.md)

## -parameters
### -param contact
A [Contact](../windows.applicationmodel.contacts/contact.md) that meets the search criteria.

## -returns
An asynchronous contact save operation.

## -remarks

## -examples

## -see-also

## -capabilities
contactsSystem

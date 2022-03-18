---
-api-id: M:Windows.ApplicationModel.Contacts.ContactStore.FindContactsAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Contacts.Contact>> FindContactsAsync(System.String searchText)
-->

# Windows.ApplicationModel.Contacts.ContactStore.FindContactsAsync

## -description
Retrieves a list of [Contact](contact.md) objects based on the supplied search text.

## -parameters
### -param searchText
The search string for the operation. The query will attempt to match the name ([Name](contact_name.md)), email address ([Emails](contact_emails.md) values), or phone number ([Phones](contact_phones.md) values) of a contact.

## -returns
An asynchronous operation that returns a search-filtered list of contacts on successful completion. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [Contact](contact.md) items. (You can use APIs of [IVectorView<Contact>](../windows.foundation.collections/ivectorview_1.md) for C++, APIs of [IReadOnlyList<Contact>](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -examples

## -see-also
[FindContactsAsync](contactstore_findcontactsasync_173480860.md), [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
## -capabilities
contactsSystem

---
-api-id: M:Windows.ApplicationModel.Contacts.ContactStore.FindContactsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Contacts.Contact>> FindContactsAsync()
-->

# Windows.ApplicationModel.Contacts.ContactStore.FindContactsAsync

## -description
Retrieves the list of all contacts in the contact store.

## -returns
An asynchronous operation that returns a list of all [Contact](contact.md) objects in the contact store. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [Contact](contact.md) items. (You can use APIs of [IVectorView&lt;Contact&gt;](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList<Contact>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1) for .NET.)

## -remarks

## -examples

## -see-also
[Contact](contact.md), [FindContactsAsync(String)](contactstore_findcontactsasync_1406591676.md), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
## -capabilities
contactsSystem

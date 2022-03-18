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
An asynchronous operation that returns a list of all [Contact](contact.md) objects in the contact store. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [Contact](contact.md) items. (You can use APIs of [IVectorView<Contact>](../windows.foundation.collections/ivectorview_1.md) for C++, APIs of [IReadOnlyList<Contact>](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -examples

## -see-also
[Contact](contact.md), [FindContactsAsync(String)](contactstore_findcontactsasync_1406591676.md), [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
## -capabilities
contactsSystem

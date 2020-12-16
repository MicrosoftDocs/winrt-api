---
-api-id: M:Windows.Phone.PersonalInformation.ContactQueryResult.GetContactsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Phone.PersonalInformation.StoredContact>> GetContactsAsync()
-->

# Windows.Phone.PersonalInformation.ContactQueryResult.GetContactsAsync

## -description
Retrieves contacts from the contact store.

## -returns
When this method completes, it returns an [IVectorView](/previous-versions/br224594(v=vs.85)) containing [StoredContact](storedcontact.md) objects. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [StoredContact](storedcontact.md) items. (You can use APIs of [IVectorView<StoredContact>](../windows.foundation.collections/ivectorview_1.md) for C++, APIs of [IReadOnlyList<StoredContact>](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -examples

## -see-also
[GetContactsAsync(UInt32, UInt32)](contactqueryresult_getcontactsasync_1075020628.md), [StoredContact](storedcontact.md), [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

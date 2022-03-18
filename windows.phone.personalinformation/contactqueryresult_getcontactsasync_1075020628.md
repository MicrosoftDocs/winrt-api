---
-api-id: M:Windows.Phone.PersonalInformation.ContactQueryResult.GetContactsAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Phone.PersonalInformation.StoredContact>> GetContactsAsync(System.UInt32 startIndex, System.UInt32 maxNumberOfItems)
-->

# Windows.Phone.PersonalInformation.ContactQueryResult.GetContactsAsync

## -description
Retrieves contacts from the contact store given the specified starting index and number of items to return..

## -parameters
### -param startIndex
The index of the first contact to be retrieved.

### -param maxNumberOfItems
The number of contacts to retrieve.

## -returns
When this method completes, it returns an [IVectorView](/previous-versions/br224594(v=vs.85)) containing [StoredContact](storedcontact.md) objects. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [StoredContact](storedcontact.md) items. (You can use APIs of [IVectorView<StoredContact>](../windows.foundation.collections/ivectorview_1.md) for C++, APIs of [IReadOnlyList<StoredContact>](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -examples

## -see-also
[GetContactsAsync](contactqueryresult_getcontactsasync_1004597153.md), [StoredContact](storedcontact.md), [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

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
When this method completes, it returns an [IVectorView](https://msdn.microsoft.com/library/644aa3d0-6f4d-406e-9adc-7f02fe575e90) containing [StoredContact](storedcontact.md) objects. If you use [Asynchronous programming](https://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is a read-only list/vector of [StoredContact](storedcontact.md) items. (You can use APIs of [IVectorView&lt;StoredContact&gt;](../windows.foundation.collections/ivectorview_1.md) for C++, APIs of [IReadOnlyList<StoredContact>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1) for .NET.)

## -remarks

## -examples

## -see-also
[GetContactsAsync](contactqueryresult_getcontactsasync_1004597153.md), [StoredContact](storedcontact.md), [Asynchronous programming](https://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

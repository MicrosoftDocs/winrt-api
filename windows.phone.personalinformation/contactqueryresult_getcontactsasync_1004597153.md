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
When this method completes, it returns an [IVectorView](http://msdn.microsoft.com/library/644aa3d0-6f4d-406e-9adc-7f02fe575e90) containing [StoredContact](storedcontact.md) objects. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is a read-only list/vector of [StoredContact](storedcontact.md) items. (You can use APIs of [IVectorView&lt;StoredContact&gt;](../windows.foundation.collections/ivectorview_1.md) for C++, APIs of [IReadOnlyList&lt;StoredContact&gt;](XREF:TODO:T:System.Collections.Generic.IReadOnlyList`1) for .NET.)

## -remarks

## -examples

## -see-also
[GetContactsAsync(UInt32, UInt32)](contactqueryresult_getcontactsasync_1075020628.md), [StoredContact](storedcontact.md), [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
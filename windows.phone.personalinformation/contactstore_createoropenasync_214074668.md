---
-api-id: M:Windows.Phone.PersonalInformation.ContactStore.CreateOrOpenAsync(Windows.Phone.PersonalInformation.ContactStoreSystemAccessMode,Windows.Phone.PersonalInformation.ContactStoreApplicationAccessMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Phone.PersonalInformation.ContactStore> CreateOrOpenAsync(Windows.Phone.PersonalInformation.ContactStoreSystemAccessMode access, Windows.Phone.PersonalInformation.ContactStoreApplicationAccessMode sharing)
-->

# Windows.Phone.PersonalInformation.ContactStore.CreateOrOpenAsync

## -description
Opens the app's custom contact store, creating the store with the specified options if it does not already exist.

## -parameters
### -param access
Whether contacts in the store can be modified by the phone experience or only by the app that created it.

### -param sharing
Whether all properties for contacts in the store are visible to other applications or just the description and display picture.

## -returns
When this method completes, it returns a [ContactStore](contactstore.md) object representing the app's custom contact store. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is [ContactStore](contactstore.md).

## -remarks

## -examples

## -see-also
[CreateOrOpenAsync](contactstore_createoropenasync_757682798.md), [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

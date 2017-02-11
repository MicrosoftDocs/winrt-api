---
-api-id: M:Windows.Phone.PersonalInformation.ContactStore.LoadExtendedPropertiesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMap<string, object>> LoadExtendedPropertiesAsync()
-->

# Windows.Phone.PersonalInformation.ContactStore.LoadExtendedPropertiesAsync

## -description
Loads the extended properties for the app's custom contact store.

## -returns
When this method completes, it returns an map/dictionary containing string key/untyped value pairs. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is a map or dictionary of these key-value pairs, keyed by string names. (You can use APIs of [IMap&lt;Platform::String,Platform::Object&gt;](XREF:TODO:w_found_coll.imap`2) for C++, APIs of [IDictionary&lt;String,Object&gt;](XREF:TODO:T:System.Collections.Generic.IDictionary`2) for .NET.)

## -remarks
This method is used to access the extended properties for the contact store, not for individual contacts. A common scenario is to use the contact store's extended properties to store revision numbers for the local contact store and a remote contact store in and then using [GetChangesAsync](contactstore_getchangesasync.md) to synchronize the two stores. To access extended properties to individual contacts, see [GetExtendedPropertiesAsync](storedcontact_getextendedpropertiesasync.md).

## -examples

## -see-also
[KnownContactProperties](knowncontactproperties.md), [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
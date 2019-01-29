---
-api-id: M:Windows.Phone.PersonalInformation.StoredContact.GetPropertiesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMap<string, object>> GetPropertiesAsync()
-->

# Windows.Phone.PersonalInformation.StoredContact.GetPropertiesAsync

## -description
Gets the known properties for the contact.

## -returns
When this method completes, it returns a map/dictionary of name/value pairs (string name, untyped values). If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is a map or dictionary of these key-value pairs, keyed by string names. (You can use APIs of [IMap<Platform::String,Platform::Object>](https://docs.microsoft.com/uwp/api/windows.foundation.collections.imap_k_v_) for C++, APIs of [IDictionary<String,Object>](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2) for .NET.)

## -remarks
The key names must be one of the properties of the [KnownContactProperties](knowncontactproperties.md) class. To get values for arbitrary app-defined properties, use [GetExtendedPropertiesAsync](storedcontact_getextendedpropertiesasync_1400113805.md) instead. The contents of the collection is saved when [SaveAsync](storedcontact_saveasync_2143735121.md) is called.

## -examples

## -see-also
[Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

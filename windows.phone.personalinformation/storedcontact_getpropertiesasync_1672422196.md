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
When this method completes, it returns a map/dictionary of name/value pairs (string name, untyped values). If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a map or dictionary of these key-value pairs, keyed by string names. (You can use APIs of [IMap<Platform::String,Platform::Object>](/uwp/api/windows.foundation.collections.imap_k_v_) for C++, APIs of [IDictionary<String,Object>](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks
The key names must be one of the properties of the [KnownContactProperties](knowncontactproperties.md) class. To get values for arbitrary app-defined properties, use [GetExtendedPropertiesAsync](storedcontact_getextendedpropertiesasync_1400113805.md) instead. The contents of the collection is saved when [SaveAsync](storedcontact_saveasync_2143735121.md) is called.

## -examples

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

---
-api-id: M:Windows.Phone.PersonalInformation.StoredContact.GetExtendedPropertiesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMap<string, object>> GetExtendedPropertiesAsync()
-->

# Windows.Phone.PersonalInformation.StoredContact.GetExtendedPropertiesAsync

## -description
Gets the extended properties for a stored contact as an map of name/value pairs.

## -returns
When this method completes, it returns a map/dictionary of name/value pairs (string name, untyped values). If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a map or dictionary of these key-value pairs, keyed by string names. (You can use APIs of [IMap<Platform::String,Platform::Object>](/uwp/api/windows.foundation.collections.imap_k_v_) for C++, APIs of [IDictionary<String,Object>](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks
In the current release, the values stored in the collection returned by this method must be strings. The key names are app-defined and are not used by the operating system at all. To get the values for common properties, such as a contact address or telephone numbers that are used by the operating system, use [GetPropertiesAsync](contactinformation_getpropertiesasync_1672422196.md) instead. The contents of the extended properties collection is saved when [SaveAsync](storedcontact_saveasync_2143735121.md) is called.

## -examples

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

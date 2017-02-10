---
-api-id: M:Windows.Phone.PersonalInformation.ContactInformation.GetPropertiesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IMap<string, object>> GetPropertiesAsync()
-->

# Windows.Phone.PersonalInformation.ContactInformation.GetPropertiesAsync

## -description
Gets the properties for a contact as an map of name/value pairs.

## -returns
When this method completes, it returns a map/dictionary of name/value pairs (string name, untyped values). If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is a map or dictionary of these key-value pairs, keyed by string names. (You can use APIs of [IMap&lt;Platform::String,Platform::Object&gt;](XREF:TODO:w_found_coll.imap`2) for C++, APIs of [IDictionary&lt;String,Object&gt;](XREF:TODO:T:System.Collections.Generic.IDictionary`2) for .NET.)

## -remarks
When working with the collection that this method returns, use the [KnownContactProperties](knowncontactproperties.md) static properties as the key value. This assures that you're asking for known, existing properties.

## -examples

## -see-also
[KnownContactProperties](knowncontactproperties.md), [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
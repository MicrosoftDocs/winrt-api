---
-api-id: M:Windows.Phone.PersonalInformation.ContactInformation.ParseVcardAsync(Windows.Storage.Streams.IInputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Phone.PersonalInformation.ContactInformation> ParseVcardAsync(Windows.Storage.Streams.IInputStream vcard)
-->

# Windows.Phone.PersonalInformation.ContactInformation.ParseVcardAsync

## -description
Parses a vCard from a stream and returns a populated [ContactInformation](contactinformation.md) object.

## -parameters
### -param vcard
A stream containing the vCard data.

## -returns
When this method completes, it returns a [ContactInformation](contactinformation.md) object populated with the data from the vCard. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is [ContactInformation](contactinformation.md).

## -remarks

## -examples

## -see-also
[Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
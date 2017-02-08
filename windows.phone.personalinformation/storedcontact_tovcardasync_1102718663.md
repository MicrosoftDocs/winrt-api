---
-api-id: M:Windows.Phone.PersonalInformation.StoredContact.ToVcardAsync(Windows.Phone.PersonalInformation.VCardFormat)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> ToVcardAsync(Windows.Phone.PersonalInformation.VCardFormat format)
-->

# Windows.Phone.PersonalInformation.StoredContact.ToVcardAsync

## -description
Retrieves a vCard representation of the contact using the specified vCard format.

## -parameters
### -param format
The format that the returned vCard will use.

## -returns
When this method completes, it returns a stream containing the vCard data. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md), which is the data.

## -remarks

## -examples

## -see-also
[ToVcardAsync](storedcontact_tovcardasync_1389129276.md), [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]
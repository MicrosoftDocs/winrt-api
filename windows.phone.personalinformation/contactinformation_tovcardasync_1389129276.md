---
-api-id: M:Windows.Phone.PersonalInformation.ContactInformation.ToVcardAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> ToVcardAsync()
-->

# Windows.Phone.PersonalInformation.ContactInformation.ToVcardAsync

## -description
Retrieves a vCard representation of the contact using the vCard version 3.0 format.

## -returns
When this method completes, it returns a stream containing the vCard data. If you use [Asynchronous programming](https://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md), which is the data.

## -remarks
*vCard* is a file format standard for electronic business cards.

## -examples

## -see-also
[ToVcardAsync(VCardFormat)](contactinformation_tovcardasync_1102718663.md), [Asynchronous programming](https://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)

## -capabilities
ID_CAP_CONTACTS [Windows Phone]

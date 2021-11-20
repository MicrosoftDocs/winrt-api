---
-api-id: M:Windows.Security.Credentials.WebAccount.GetPictureAsync(Windows.Security.Credentials.WebAccountPictureSize)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> GetPictureAsync(Windows.Security.Credentials.WebAccountPictureSize desizedSize)
-->

# Windows.Security.Credentials.WebAccount.GetPictureAsync

## -description
Gets the web account's picture asynchronously.

## -parameters
### -param desizedSize
The desired size of the web account picture.

## -returns
When this method completes, it returns the web account's picture.

## -remarks
The word "desired" is misspelled in this parameter name.

This method should be called on [WebAccount](webaccount.md) returned in [WebTokenRequestResponse](webtokenrequestresponse.md) with ("UserPictureEnabled", "True") inserted in [WebTokenRequest.Properties](webtokenrequest_properties.md) while creating [WebTokenRequest](webtokenrequest.md) for acquirung token or else it might return default profile picture.

## -examples

## -see-also

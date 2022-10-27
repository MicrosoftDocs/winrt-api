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

This method should be called on the [WebAccount](webaccount.md) returned in [WebTokenRequestResponse](webtokenrequestresponse.md). Add (`UserPictureEnabled`, `True`) to the [WebTokenRequest.Properties](webtokenrequest_properties.md) while creating [WebTokenRequest](webtokenrequest.md) to acquire a token. Otherwise, the call may return a default profile picture.

## -examples

## -see-also

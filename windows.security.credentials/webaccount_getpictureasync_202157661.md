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

> [!IMPORTANT]
> The word "desired" is misspelled in this method's parameter name.

This method should be called on the [WebAccount](webaccount.md) returned in [WebTokenRequestResult](..\windows.security.authentication.web.core\webtokenrequestresult.md). Add (`UserPictureEnabled`, `True`) to the [WebTokenRequest.Properties](..\windows.security.authentication.web.core\webtokenrequest_properties.md) while creating [WebTokenRequest](..\windows.security.authentication.web.core\webtokenrequest.md) to acquire a token. Otherwise, the call may return a default profile picture.

## -examples

## -see-also

---
-api-id: M:Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest.GenerateManualEnablingChallenge
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Protection.PlayReady.PlayReadySoapMessage GenerateManualEnablingChallenge()
-->

# Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest.GenerateManualEnablingChallenge

## -description
Begins the process of manually enabling.

## -returns
Begins the process of manually enabling.

## -remarks
Provides the caller the raw HTTP challenge and headers that must be sent up to the server. When the response is received, it should be processed by calling the [ProcessManualEnablingResponse](iplayreadyservicerequest_processmanualenablingresponse_559693975.md) method.

Calling this method places the interface in a read-only state even if the method does not succeed.

## -examples

## -see-also

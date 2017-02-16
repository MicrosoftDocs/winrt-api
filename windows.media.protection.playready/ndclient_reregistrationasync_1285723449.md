---
-api-id: M:Windows.Media.Protection.PlayReady.NDClient.ReRegistrationAsync(Windows.Media.Protection.PlayReady.INDCustomData)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ReRegistrationAsync(Windows.Media.Protection.PlayReady.INDCustomData registrationCustomData)
-->

# Windows.Media.Protection.PlayReady.NDClient.ReRegistrationAsync

## -description
Performs a proximity detection and reregistration between a client receiver and a transmitter.

## -parameters
### -param registrationCustomData
Custom data for the registration request.

## -returns
The result of the asynchronous reregistration call.

## -remarks
The PlayReady Network Device (PRND) protocol requires a receiver to reregister with a transmitter within 48 hours after a successful proximity detection operation so that the receiver can continue to receive protected data from the transmitter. An app should call this method immediately after it receives a [ReRegistrationNeeded](ndclient_reregistrationneeded.md) event.

## -examples

## -see-also

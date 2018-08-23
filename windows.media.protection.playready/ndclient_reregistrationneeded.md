---
-api-id: E:Windows.Media.Protection.PlayReady.NDClient.ReRegistrationNeeded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReRegistrationNeeded<Windows.Media.Protection.PlayReady.NDClient,  object>
-->

# Windows.Media.Protection.PlayReady.NDClient.ReRegistrationNeeded

## -description
Notifies listeners that the app should start re-registration by calling the [ReRegistrationAsync](ndclient_reregistrationasync_1285723449.md) method.

## -remarks
The PlayReady Network Device (PRND) protocol requires client receivers to re-register with transmitters every 48 hours. This event notifies listeners that 47.5 hours have passed since the receiver successfully registered with a transmitter. This gives the app a chance to call the **ReRegistrationAsync** method before the session expires.

## -examples

## -see-also

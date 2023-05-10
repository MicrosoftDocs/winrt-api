---
-api-id: P:Windows.Networking.XboxLive.XboxLiveEndpointPair.State
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.XboxLive.XboxLiveEndpointPairState State { get; }
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.State

## -description

Gets a value representing the state of this **XboxLiveEndpointPair**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

The current state of the endpoint pair.

## -remarks

The state of an **XboxLiveEndpointPair** can change at any time. You should not cache this value, unless you also use the **StateChanged** event to update that cached state when it changes.

## -examples

## -see-also

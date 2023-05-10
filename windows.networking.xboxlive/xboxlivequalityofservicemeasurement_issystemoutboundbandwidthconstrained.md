---
-api-id: P:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.IsSystemOutboundBandwidthConstrained
-api-type: winrt property
---

<!-- Property syntax
public bool IsSystemOutboundBandwidthConstrained { get;  set; }
-->

# Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurement.IsSystemOutboundBandwidthConstrained

## -description

Gets or sets a Boolean value configuring whether Quality of Service (QoS) measurements and other **Windows.Networking.XboxLive** internal network operations attempt to constrain their outbound bandwidth consumption. Constraining consumption in this way reduces the impact of those operations on your app's outgoing bandwidth usage, at the expense of longer delays or increased failure rates for them.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

When `true`, QoS measurements are made with outbound bandwidth consumption constrained.

## -remarks

## -examples

## -see-also

---
-api-id: T:Windows.Networking.XboxLive.XboxLiveDeviceAddress
-api-type: winrt class
---

<!-- Class syntax.
public class XboxLiveDeviceAddress : Windows.Networking.XboxLive.IXboxLiveDeviceAddress
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress

## -description

Represents the network location of a console or other authenticated device.

Objects of this class represent an opaque collection of connectivity information about a device (in particular, a list of IP addresses). You pass an **XboxLiveDeviceAddress** to one of the **XboxLiveEndpointPairTemplate** class's **CreateEndpointPairAsync** or **CreateEndpointPairForPortsAsync** methods in order to instantiate an **XboxLiveEndpointPair** between the local device and the device at the given **XboxLiveDeviceAddress**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks

## -examples

## -see-also

---
-api-id: T:Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo
-api-type: winrt class
---

<!-- Class syntax.
public class PerceptionFrameProviderInfo : Windows.Devices.Perception.Provider.IPerceptionFrameProviderInfo
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo

## -description
A specific set of properties describing a unique IPerceptionFrameProvider.

## -remarks
The properties are:

Id - A unique identifier of the IPerceptionFrameProvider, for example, a GUID or "com.contoso.depthcamera.x500.serialNumber1234".
+ This id must be persistent across reboots.
+ This id must be different between devices for a single manufacturer.
+ This id must be approximately globally unique such that there are no conflicts on any one host.


DisplayName - A friendly name for the provider, for example, "Contoso Depth Camera x500".

DeviceKind - A descriptor of the kind of FrameProvider categorically, for example, "com.contoso.depthcamera.x500".

FrameKind - The type of frames the device creates. This must be one of:
+ KnownPerceptionFrameKind::Color
+ KnownPerceptionFrameKind::Depth
+ KnownPerceptionFrameKind::Infrared


Hidden - Whether or not the device enumerates via FindAllAsync or device added events on source watchers. If false, the device is accessible only via FromIdAsync. If false, and the device is registered in a FaceAuthenticationGroup, the device is still enumerated as a Face Authentication source.

## -examples

## -see-also

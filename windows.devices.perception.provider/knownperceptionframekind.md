---
-api-id: T:Windows.Devices.Perception.Provider.KnownPerceptionFrameKind
-api-type: winrt class
---

<!-- Class syntax.
public class KnownPerceptionFrameKind 
-->

# Windows.Devices.Perception.Provider.KnownPerceptionFrameKind

## -description
A string used to identify the type classification of a frame.

## -remarks
Possible values are Color, Depth, and Infrared.

FrameProviders must indicate the type of frames they return by setting a FrameKind property on the IPerceptionFrameProviderInfo that matches one of the values retrieved from this static class.

For example, if your FrameProvider returns Color frames, the FrameKind property of the IPerceptionFrameProviderInfo objects your provider must be set KnownPerceptionFrameKind::Color.

## -examples

## -see-also

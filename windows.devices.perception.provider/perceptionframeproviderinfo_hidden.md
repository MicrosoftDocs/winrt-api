---
-api-id: P:Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo.Hidden
-api-type: winrt property
---

<!-- Property syntax
public bool Hidden { get;  set; }
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo.Hidden

## -description
Gets or sets a value indicating whether the device enumerates via FindAllAsync or device-added events on source watchers.

## -property-value
True if the device enumerates via FindAllAsync or device added events on source watchers; otherwise, false. If false, the device will only be accessible via FromIdAsync. If false, the device will enumerate as a Face Authentication source, if registered via PerceptionFrameProviderManagerService::RegisterFaceAuthenticationGroup().

## -remarks

## -examples

## -see-also

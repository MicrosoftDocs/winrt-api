---
-api-id: P:Windows.Graphics.Holographic.HolographicCameraRenderingParameters.IsContentProtectionEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsContentProtectionEnabled { get;  set; }
-->

# Windows.Graphics.Holographic.HolographicCameraRenderingParameters.IsContentProtectionEnabled

## -description
Gets or sets whether the application is displaying protected content.

## -property-value
Whether content protection is enabled.

## -remarks
While content protection is enabled, rendered content will be visible only in the headset, disabling the Mixed Reality Portal's preview.

If [IsHardwareContentProtectionEnabled](holographiccamera_ishardwarecontentprotectionenabled.md) is set to true, **IsContentProtectionEnabled** will always return true.

## -see-also

## -examples


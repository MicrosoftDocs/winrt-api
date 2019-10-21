---
-api-id: P:Windows.Graphics.Holographic.HolographicDisplay.RefreshRate
-api-type: winrt property
---

<!-- Property syntax.
public double RefreshRate { get; }
-->

# Windows.Graphics.Holographic.HolographicDisplay.RefreshRate

## -description
Gets the refresh rate at which an app must present content to this holographic display.

## -property-value
The refresh rate.

## -remarks
Note that this refresh rate may be lower than the display panel's maximum refresh rate. This can occur if the system is configured to operate at a lower refresh rate&mdash;for example, based on user preferences for Windows Mixed Reality.

To observe dynamic changes to frame duration&mdash;for example, when Mixed Reality Capture (MRC) is enabled&mdash;inspect the [HolographicFrame.Duration](/uwp/api/windows.graphics.holographic.holographicframe.duration) property.

## -see-also

## -examples


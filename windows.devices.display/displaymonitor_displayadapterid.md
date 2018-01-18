---
-api-id: P:Windows.Devices.Display.DisplayMonitor.DisplayAdapterId
-api-type: winrt property
---

<!-- Property syntax.
public DisplayAdapterId DisplayAdapterId { get; }
-->

# Windows.Devices.Display.DisplayMonitor.DisplayAdapterId

## -description
Gets the locally unique identifier (LUID) of the display adapter to which the monitor is connected. Note that the display adapter to which the monitor is connected may not be the most suitable one for rendering.

An LUID is a 64-bit value guaranteed to be unique only on the system on which it was generated. The uniqueness of an LUID is guaranteed only until the system is restarted. This LUID is compatible with [Direct3D](https://msdn.microsoft.com/library/windows/desktop/hh309466), [DisplayConfig](https://msdn.microsoft.com/library/windows/hardware/ff553954), and [HolographicSpace](../windows.graphics.holographic/holographicspace.md) APIs.

## -property-value
The locally unique identifier (LUID) of the display adapter to which the monitor is connected if known, otherwise `null`.

## -remarks

## -see-also

## -examples


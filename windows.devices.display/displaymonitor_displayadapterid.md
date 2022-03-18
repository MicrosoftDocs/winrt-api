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

An LUID is a 64-bit value guaranteed to be unique only on the system on which it was generated. The uniqueness of an LUID is guaranteed only until the system is restarted. This LUID is compatible with [Direct3D](/windows/desktop/direct3d), [DisplayConfig](/windows/desktop/api/wingdi/ns-wingdi-displayconfig_path_target_info), and [HolographicSpace](../windows.graphics.holographic/holographicspace.md) APIs.

## -property-value
A [DisplayAdapterId](../windows.graphics/displayadapterid.md) containing the numeric locally unique ID (LUID) of the display adapter to which the monitor is connected if known, otherwise `null`.

## -remarks

## -see-also

## -examples


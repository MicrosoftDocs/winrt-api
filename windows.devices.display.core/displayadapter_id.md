---
-api-id: P:Windows.Devices.Display.Core.DisplayAdapter.Id
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public DisplayAdapterId Id { get; }
-->

# Windows.Devices.Display.Core.DisplayAdapter.Id

## -description
Gets a numeric locally unique ID (LUID) that refers to the runtime instance of the display adapter. This ID changes if the adapter's PnP device is stopped/started, or if the system reboots.

An LUID is a 64-bit value guaranteed to be unique only on the system on which it was generated. The uniqueness of an LUID is guaranteed only until the adapter's PnP device is stopped/started, or if the system is restarted. This LUID is compatible with [Direct3D](/windows/desktop/direct3d), [DisplayConfig](/windows/desktop/api/wingdi/ns-wingdi-displayconfig_path_target_info), and [HolographicSpace](../windows.graphics.holographic/holographicspace.md) APIs.

## -property-value
A [DisplayAdapterId](../windows.graphics/displayadapterid.md) containing a locally unique numeric ID (LUID) value.

## -remarks

## -see-also

## -examples

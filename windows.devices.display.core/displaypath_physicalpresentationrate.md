---
-api-id: P:Windows.Devices.Display.Core.DisplayPath.PhysicalPresentationRate
-api-type: winrt property
---

# Windows.Devices.Display.Core.DisplayPath.PhysicalPresentationRate

<!--
public System.Nullable<Windows.Devices.Display.Core.DisplayPresentationRate> PhysicalPresentationRate { get; set; }
-->

## -description

Gets or sets the actual physical rate at which the display is scanning out pixels (when refresh rates are being virtualized).

## -property-value

A [DisplayPresentationRate](displaypresentationrate.md) object representing the actual physical rate at which the display is scanning out pixels.

## -remarks

Starting with Windows 11, [DisplayPresentationRate](displaypresentationrate.md) is virtualized *if the physical display is capable of virtualizing refresh rates*, and doesn't necessarily represent the actual pixel rate on the wire.

To determine the actual physical rate at which the display is scanning out pixels, use the flag [DisplayManagerOptions::VirtualRefreshRateAware](displaymanageroptions.md) while creating your [DisplayManager](displaymanager.md) and [DisplayPath](displaypath.md) objects.

If your application's **DisplayManager** isn't virtual refresh rate aware, then it won't be able to access **PhysicalPresentationRate**.

## -see-also

## -examples

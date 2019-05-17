---
-api-id: P:Windows.Graphics.Printing.PrintTask.IsPrinterTargetEnabled
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsPrinterTargetEnabled { get;  set; }
-->

# Windows.Graphics.Printing.PrintTask.IsPrinterTargetEnabled

## -description
Gets or sets a value indicating whether the [PrintTask](printtask.md) supports printer targets.

## -property-value
True if the [PrintTask](printtask.md) supports printer targets.

## -remarks
This property works together with [Is3DManufacturingTargetEnabled](printtask_is3dmanufacturingtargetenabled.md) to determine which devices are enumerated when the user extends the print charm. When IsPrinterTargetEnabled is **true**, the print charm displays conventional printing devices, like 2D printers. When [Is3DManufacturingTargetEnabled](printtask_is3dmanufacturingtargetenabled.md) is **true**, the print charm displays 3D devices like 3D printers. When both IsPrinterTargetEnabled and [Is3DManufacturingTargetEnabled](printtask_is3dmanufacturingtargetenabled.md) are **true**, the print charm displays both 2D printers and 3D printers.

By default, IsPrinterTargetEnabled is **true** and [Is3DManufacturingTargetEnabled](printtask_is3dmanufacturingtargetenabled.md) is **false**.

UWP apps that support 2D printing in Windows 8 are not required to make a change in Windows 8.1 to add this property.

## -examples

## -see-also

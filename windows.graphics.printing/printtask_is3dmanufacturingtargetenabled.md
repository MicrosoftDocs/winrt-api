---
-api-id: P:Windows.Graphics.Printing.PrintTask.Is3DManufacturingTargetEnabled
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool Is3DManufacturingTargetEnabled { get;  set; }
-->

# Windows.Graphics.Printing.PrintTask.Is3DManufacturingTargetEnabled

## -description
Gets or sets a value that indicates whether the [PrintTask](printtask.md) supports 3D manufacturing devices, like a 3D printer.

## -property-value
True, if 3D manufacturing devices are supported.

## -remarks
This property works together with [IsPrinterTargetEnabled](printtask_isprintertargetenabled.md) to determine which devices are enumerated when the user extends the print charm. When [IsPrinterTargetEnabled](printtask_isprintertargetenabled.md) is **true**, the print charm displays conventional printing devices, like 2D printers. When Is3DManufacturingTargetEnabled is **true**, the print charm displays 3D devices like 3D printers. When both [IsPrinterTargetEnabled](printtask_isprintertargetenabled.md) and Is3DManufacturingTargetEnabled are **true**, the print charm displays both 2D printers and 3D printers.

By default, [IsPrinterTargetEnabled](printtask_isprintertargetenabled.md) is **true** and Is3DManufacturingTargetEnabled is **false**.



> [!NOTE]
> UWP apps that support 3D printing in Windows 8.1 must set [IsPrinterTargetEnabled](printtask_isprintertargetenabled.md) to **false** and Is3DManufacturingTargetEnabled to **true** in order to enumerate only 3D printers in the print charm.

## -examples

## -see-also
[3D printing](http://msdn.microsoft.com/en-us/windows/hardware/bg183398)

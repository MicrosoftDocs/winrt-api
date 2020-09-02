---
-api-id: P:Windows.Graphics.Printing.StandardPrintTaskOptions.HolePunch
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string HolePunch { get; }
-->

# Windows.Graphics.Printing.StandardPrintTaskOptions.HolePunch

## -description
Gets the canonical name for the hole punch option of the print task.

## -property-value
The canonical name for the hole punch option of the print task.

## -remarks
Use this property to get the canonical name to add or remove the hole punch option from the [PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md) list to indicate whether the hole punch option appears in the print preview UI. For more information, see [Customize the print preview UI](/windows/uwp/devices-sensors/customize-the-print-preview-ui). This property only applies to printers that support the hole punch capability.

## -examples

## -see-also
[Customize the print preview UI](/windows/uwp/devices-sensors/customize-the-print-preview-ui),[Printing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing),[PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md),[PrintTaskOptionDetails](../windows.graphics.printing.optiondetails/printtaskoptiondetails.md)
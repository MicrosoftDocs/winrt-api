---
-api-id: P:Windows.Graphics.Printing.StandardPrintTaskOptions.ColorMode
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string ColorMode { get; }
-->

# Windows.Graphics.Printing.StandardPrintTaskOptions.ColorMode

## -description
Gets the canonical name for color mode option of the print task.

## -property-value
The canonical name for color mode option of the print task.

## -remarks
Use this property to get the canonical name to add or remove the color mode option from the [PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md) list to indicate whether the color mode option appears in the print preview UI. For more information, see [Customize the print preview UI](https://docs.microsoft.com/windows/uwp/devices-sensors/customize-the-print-preview-ui). This property only applies to printers that support the color mode capability.

## -examples

## -see-also
[Customize the print preview UI](https://docs.microsoft.com/windows/uwp/devices-sensors/customize-the-print-preview-ui),[Printing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing),[PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md),[PrintTaskOptionDetails](../windows.graphics.printing.optiondetails/printtaskoptiondetails.md)
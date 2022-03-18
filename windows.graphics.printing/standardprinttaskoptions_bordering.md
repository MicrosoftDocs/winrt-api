---
-api-id: P:Windows.Graphics.Printing.StandardPrintTaskOptions.Bordering
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Bordering { get; }
-->

# Windows.Graphics.Printing.StandardPrintTaskOptions.Bordering

## -description
Gets the canonical name of the bordering option for the print task.

## -property-value
The canonical name of the bordering option for the print task.

## -remarks
Use this property to get the canonical name to add or remove the bordering option from the [PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md) list to indicate whether the bordering option appears in the print preview UI. For more information, see [Customize the print preview UI](/windows/uwp/devices-sensors/customize-the-print-preview-ui). This property only applies to printers that support the bordering capability (for example, to print borders or no borders).

## -examples

## -see-also
[Customize the print preview UI](/windows/uwp/devices-sensors/customize-the-print-preview-ui),[Printing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing),[PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md),[PrintTaskOptionDetails](../windows.graphics.printing.optiondetails/printtaskoptiondetails.md)
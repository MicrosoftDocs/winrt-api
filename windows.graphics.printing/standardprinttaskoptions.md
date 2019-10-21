---
-api-id: T:Windows.Graphics.Printing.StandardPrintTaskOptions
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class StandardPrintTaskOptions 
-->

# Windows.Graphics.Printing.StandardPrintTaskOptions

## -description
Provides access to the canonical names for the options represented by the [PrintTaskOptions](printtaskoptions.md) class. You can use the StandardPrintTaskOptions class to identify print options displayed in the user experience or to retrieve specific options using the [PrintTaskOptionDetails](../windows.graphics.printing.optiondetails/printtaskoptiondetails.md) class.

## -remarks
The StandardPrintTaskOptions class provides the canonical names for the common print task options used in the [PrintTaskOptions](printtaskoptions.md) object. These names may be used to add or remove items from the [PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md) list to indicate the options that appear in the print preview UI. For more information, see [Customize the print preview UI](https://docs.microsoft.com/windows/uwp/devices-sensors/customize-the-print-preview-ui). These names may also be used with the [PrintTaskOptionDetails](../windows.graphics.printing.optiondetails/printtaskoptiondetails.md) object to locate the standard options in the list of options. These names are considered to be unique, and any attempt to create options of the same name will be rejected.

Here is a JavaScript code snippet that you could use, for example, to append the standard print task options to be displayed in the UI:

```javascript
// Choose the printer options to be shown.
// The order in which the options are appended determines the order in which they appear in the UI
printTask.options.displayedOptions.clear();
printTask.options.displayedOptions.append(Windows.Graphics.Printing.StandardPrintTaskOptions.copies);
printTask.options.displayedOptions.append(Windows.Graphics.Printing.StandardPrintTaskOptions.mediaSize);
printTask.options.displayedOptions.append(Windows.Graphics.Printing.StandardPrintTaskOptions.orientation);
printTask.options.displayedOptions.append(Windows.Graphics.Printing.StandardPrintTaskOptions.duplex);
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Bordering |
| 1803 | 17134 | CustomPageRanges |

## -examples

## -see-also
[Customize the print preview UI](https://docs.microsoft.com/windows/uwp/devices-sensors/customize-the-print-preview-ui),[Printing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing),[PrintTaskOptions.DisplayedOptions](printtaskoptions_displayedoptions.md),[PrintTaskOptionDetails](../windows.graphics.printing.optiondetails/printtaskoptiondetails.md)

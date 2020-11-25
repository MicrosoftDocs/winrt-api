---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintTaskOptionDetails : Windows.Graphics.Printing.IPrintTaskOptionsCore, Windows.Graphics.Printing.IPrintTaskOptionsCoreUIConfiguration, Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails

## -description
A collection of events, methods and properties for advanced print tasks.

## -remarks

You can use **PrintTaskOptionDetails** to retrieve information about the available options for a print task and to add custom options to the print experience.

Here is a code snippet that shows how to retrieve the advanced options for a print task and then set the order in which they will be displayed in the print window of the app.

```csharp
//  Retrieve the advanced Print Task Options.
PrintTaskOptionDetails printDetailedOptions = PrintTaskOptionDetails.GetFromPrintTaskOptions(printTask.Options);

// Choose the printer options to be shown.
// The order in which the options are appended determines the order in which they appear in the UI
printDetailedOptions.DisplayedOptions.Clear();

printDetailedOptions.DisplayedOptions.Add(StandardPrintTaskOptions.Copies);
printDetailedOptions.DisplayedOptions.Add(StandardPrintTaskOptions.Orientation);
printDetailedOptions.DisplayedOptions.Add(StandardPrintTaskOptions.ColorMode);
```

For more information on this and other printing scenarios, see [Printing](/windows/uwp/devices-sensors/print-from-your-app) on the Windows Dev Center.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | CreateToggleOption |

## -examples

## -see-also
[getFromPrintTaskOptions](printtaskoptiondetails_getfromprinttaskoptions_55978790.md)

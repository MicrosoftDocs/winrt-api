---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintBindingOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintBindingOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintBindingOptionDetails

## -description
Represents the list of print binding options.

## -remarks
Here is a code snippet that shows how to retrieve the object:

```csharp
//  Retrieve the advanced Print Task Options.
PrintTaskOptionDetails printDetailedOptions = PrintTaskOptionDetails.GetFromPrintTaskOptions(printTask.Options);

// Get the object.
PrintBindingOptionDetails printBindingOptionDetails =
     (PrintBindingOptionDetails)printDetailedOptions.Options[StandardPrintTaskOptions.Binding];
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also

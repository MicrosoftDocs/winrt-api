---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintCopiesOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintCopiesOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintNumberOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintCopiesOptionDetails

## -description
Represents the option for the number of printed copies.

## -remarks

Here is a code snippet that shows how to retrieve the object:

```csharp
//  Retrieve the advanced Print Task Options.
PrintTaskOptionDetails printDetailedOptions = PrintTaskOptionDetails.GetFromPrintTaskOptions(printTask.Options);

// Get the object.
PrintCopiesOptionDetails printCopiesOptionDetails =
     (PrintCopiesOptionDetails)printDetailedOptions.Options[StandardPrintTaskOptions.Copies];
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also

---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintQualityOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintQualityOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintQualityOptionDetails

## -description
Represents the list of print quality options.

## -remarks

Here is a code snippet that shows how to retrieve the object:

```csharp
//  Retrieve the advanced Print Task Options.
PrintTaskOptionDetails printDetailedOptions = PrintTaskOptionDetails.GetFromPrintTaskOptions(printTask.Options);

// Get the object.
PrintQualityOptionDetails printQualityOptionDetails =
     (PrintQualityOptionDetails)printDetailedOptions.Options[StandardPrintTaskOptions.PrintQuality];
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also

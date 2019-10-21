---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintHolePunchOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintHolePunchOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintHolePunchOptionDetails

## -description
Represents the list of punch hole options.

## -remarks
Here is a JavaScript code snippet that shows how to retrieve the object:

```javascript
//  Retrieve the advanced Print Task Options
var printDetailedOptions = 
     Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails.getFromPrintTaskOptions(printTask.options);

// get the object
var printHolePunchOptionDetails = 
     printDetailedOptions.options.lookup(Windows.Graphics.Printing.StandardPrintTaskOptions.holePunch);
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also

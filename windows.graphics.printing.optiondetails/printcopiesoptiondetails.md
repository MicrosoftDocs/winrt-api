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
Here is a JavaScript code snippet that shows how to retrieve the object:

```javascript
//  Retrieve the advanced Print Task Options
var printDetailedOptions = 
     Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails.getFromPrintTaskOptions(printTask.options);

// get the object
var printCopiesOptionDetails = 
     printDetailedOptions.options.lookup(Windows.Graphics.Printing.StandardPrintTaskOptions.copies);
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also

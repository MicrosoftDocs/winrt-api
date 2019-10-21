---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintOrientationOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintOrientationOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintOrientationOptionDetails

## -description
Represents the list of print orientation options.

## -remarks
Here is a JavaScript code snippet that shows how to retrieve the object:

```javascript
//  Retrieve the advanced Print Task Options
var printDetailedOptions = 
     Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails.getFromPrintTaskOptions(printTask.options);

// get the object
var printOrientationOptionDetails =
     printDetailedOptions.options.lookup(Windows.Graphics.Printing.StandardPrintTaskOptions.orientation);
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also

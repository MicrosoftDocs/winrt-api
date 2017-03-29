---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintDuplexOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintDuplexOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintDuplexOptionDetails

## -description
Represents the list of print duplex options.

## -remarks
Here is a JavaScript code snippet that shows how to retrieve the object:





```javascript
//  Retrieve the advanced Print Task Options
var printDetailedOptions = 
     Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails.getFromPrintTaskOptions(printTask.options);

// get the object
var printDuplexOptionDetails =
     printDetailedOptions.options.lookup(Windows.Graphics.Printing.StandardPrintTaskOptions.duplex);
```



## -examples

## -see-also
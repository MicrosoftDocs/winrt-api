---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintBorderingOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintBorderingOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintBorderingOptionDetails

## -description
Represents the list of print bordering options.

## -remarks
Here is a JavaScript code snippet that shows how to retrieve the object:





```javascript
//  Retrieve the advanced Print Task Options
var printDetailedOptions = 
     Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails.getFromPrintTaskOptions(printTask.options);

// get the object
var printBorderingOptionDetails = 
     printDetailedOptions.options.lookup(Windows.Graphics.Printing.StandardPrintTaskOptions.bordering);

```



## -examples

## -see-also
[IPrintOptionDetails](iprintoptiondetails.md), [IPrintItemListOptionDetails](iprintitemlistoptiondetails.md)
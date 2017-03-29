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
You can use **PrintTaskOptionDetails** to retrieve information about the available options for a print task and to add custom options to the print experience. If you develop in JavaScript, however, you must use **Direct2D** printing to change the preview or print content based on option changes. This is because print template is not supported. For more information about **Direct2D** printing, see [Printing and command lists]( http://go.microsoft.com/fwlink/p/?LinkID=266323).

Here is a JavaScript code snippet that shows how to retrieve the advanced options for a print task and then set the order in which they will be displayed in the print window of the app.





```javascript
   //  Retrieve the advanced Print Task Options
        var printDetailedOptions = 
            Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails.getFromPrintTaskOptions(printTask.options);

   // Choose the printer options to be shown.
   // The order in which the options are appended determines the order in which they appear in the UI
        printDetailedOptions.displayedOptions.clear();

        printDetailedOptions.displayedOptions.append(Windows.Graphics.Printing.StandardPrintTaskOptions.copies);
        printDetailedOptions.displayedOptions.append(Windows.Graphics.Printing.StandardPrintTaskOptions.orientation);
        printDetailedOptions.displayedOptions.append(Windows.Graphics.Printing.StandardPrintTaskOptions.colorMode);

```

For more information on this and other printing scenarios, see [Printing](http://msdn.microsoft.com/library/windows/apps/hh465225.aspx) on the Windows Dev Center.

## -examples

## -see-also
[getFromPrintTaskOptions](printtaskoptiondetails_getfromprinttaskoptions.md)
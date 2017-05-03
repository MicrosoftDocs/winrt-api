---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintTaskOptionChangedEventArgs : Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionChangedEventArgs
-->

# Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs

## -description
Called when a print task option has changed.

## -remarks
Here is a code snippet that shows how to retrieve the object, when a print task option has changed. First, the app must register to listen for option changes. Once the option is changed, a callback is made to the event listener. Note that in JavaScript, you must use **Direct2D** printing to change the preview or print content based on option changes because print template is no longer supported. For more information about **Direct2D** printing, see [Printing and command lists]( http://go.microsoft.com/fwlink/p/?LinkID=266323).





```javascript

// Retreive the advanced print task options
var printDetailedOptions = Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails.getFromPrintTaskOptions(printTask.options);

// Create a new list option 
var pageRange = printDetailedOptions.createItemListOption("PageRange", "Page Range"); 
pageRange.addItem("PrintAll", "Print all"); 
pageRange.addItem("PrintSelection", "Print Selection"); 
pageRange.addItem("PrintRange", "Print Range"); 

// Add the custom option to the option list 
printDetailedOptions.displayedOptions.append("PageRange"); 

// Register the handler for option change event. 
printDetailedOptions.onoptionchanged = onOptionsChanged; 
//The callback function for when an option has changed. optionsEvent is an object of type: PrintTaskOptionChangedEventArgs
function onOptionsChanged(optionsEvent) { } 
 

```



## -examples

## -see-also
---
-api-id: T:Windows.Graphics.Printing.PrintTaskSourceRequestedArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintTaskSourceRequestedArgs : Windows.Graphics.Printing.IPrintTaskSourceRequestedArgs
-->

# Windows.Graphics.Printing.PrintTaskSourceRequestedArgs

## -description
Arguments associated with the [PrintTaskSourceRequestedHandler](printtasksourcerequestedhandler.md) delegate. Provides a method for handing the content to be printed to the Print Task.

## -remarks
PrintTaskSourceRequestedArgs can, for example, be used to retrieve the deadline for a print task. Here is a JavaScript code snippet that retrieves a print task deadline:





```javascript
// Get a value for the DateTime object for a print task
var deadline = Windows.Graphics.Printing.PrintTaskSourceRequestedArgs.deadline;

```



## -examples

## -see-also

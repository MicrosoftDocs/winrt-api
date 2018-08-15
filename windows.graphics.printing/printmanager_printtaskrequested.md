---
-api-id: E:Windows.Graphics.Printing.PrintManager.PrintTaskRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PrintTaskRequested<Windows.Graphics.Printing.PrintManager,  Windows.Graphics.Printing.PrintTaskRequestedEventArgs>
-->

# Windows.Graphics.Printing.PrintManager.PrintTaskRequested

## -description
Raised when a request to print has occurred. This event may be triggered by user action or via programmatic invocation of printing via the [ShowPrintUIAsync](printmanager_showprintuiasync_1397448831.md) method.

## -remarks
When you add print capabilities to your UWP app, you have to implement an event handler to process this event when it is raised. Here is a JavaScript code snippet that shows how to handle this event:





```javascript
// Print event handler for printing via the PrintManager API.
// printEvent contains the print task request object
    function onPrintTaskRequested(printEvent) {    
        var printTask = printEvent.request.createPrintTask("Print Sample", function (args) {
            args.setSource(MSApp.getHtmlPrintDocumentSource(document));
    });

```

To see the complete listing for this and other printing scenarios using **PrintTaskRequested**, see [Printing](http://msdn.microsoft.com/library/windows/apps/hh465225.aspx).

## -examples

## -see-also
[Printing](http://msdn.microsoft.com/library/windows/apps/hh465225.aspx)
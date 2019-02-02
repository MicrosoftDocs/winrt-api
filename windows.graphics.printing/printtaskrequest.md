---
-api-id: T:Windows.Graphics.Printing.PrintTaskRequest
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintTaskRequest : Windows.Graphics.Printing.IPrintTaskRequest
-->

# Windows.Graphics.Printing.PrintTaskRequest

## -description
Contains the request from the system to create a print task. This object is available from the [PrintTaskRequestedEventArgs](printtaskrequestedeventargs.md) object passed to the [PrintTaskRequested](printmanager_printtaskrequested.md) event.

## -remarks
The [PrintTaskRequest](printtaskrequest.md) class is used by an app to create a new [PrintTask](printtask.md) object. A [PrintTask](printtask.md) object is created in response to the [PrintTaskRequested](printmanager_printtaskrequested.md) event and it indicates to the system that the app has content to be printed. When creating a [PrintTask](printtask.md) object using the [CreatePrintTask](printtaskrequest_createprinttask_356827780.md) method, the app must provide a name for the [PrintTask](printtask.md) and a [PrintTaskSourceRequestedHandler](printtasksourcerequestedhandler.md) event handler which is called when the content to be printed is required.

An app should do the minimum amount of work possible in the [PrintTaskRequested](printmanager_printtaskrequested.md) event handler since only a short amount of time is provided for a response. Wherever possible, the app should simply create a [PrintTask](printtask.md) and delay any content initialization until the [PrintTaskSourceRequestedHandler](printtasksourcerequestedhandler.md) event handler is called.

If an app needs to perform an asynchronous operation during the [PrintTaskRequested](printmanager_printtaskrequested.md) handler it must retrieve and use a [PrintTaskRequestedDeferral](printtaskrequesteddeferral.md) object. Prior to the exit of the event handler, and typically before the asynchronous operation is started, the app must retrieve the **PrintTaskRequestedDeferral** object by calling the [GetDeferral](printtaskrequest_getdeferral_254836512.md) method of the [PrintTaskRequest](printtaskrequest.md) object. When the asynchronous operation completes, the app must call the [Complete](printtaskrequesteddeferral_complete_1807836922.md) method of the [PrintTaskRequestedDeferral](printtaskrequesteddeferral.md) object to signal that the print task request is complete. The call to the **Complete** method must occur before the [Deadline](printtaskrequest_deadline.md) is reached in order for the request to be accepted.

The **CreatePrintTask** method in **PrintTaskRequest** can be used to create the print task. Here is a JavaScript code snippet showing the creation of a print task:





```javascript
    // Print event handler for printing via the PrintManager API.
    // printEvent contains the print task request object
    function onPrintTaskRequested(printEvent) {
        printEvent.request.createPrintTask("Print Sample", function (args) {
            args.setSource(MSApp.getHtmlPrintDocumentSource(document));
        }); 
    }

```

For more information on this and other printing scenarios, see [Printing](https://msdn.microsoft.com/library/windows/apps/hh465225.aspx) on the Windows Dev Center.

## -examples

## -see-also
[Printing](https://msdn.microsoft.com/library/windows/apps/hh465225.aspx)

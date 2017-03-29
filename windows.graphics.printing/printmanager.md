---
-api-id: T:Windows.Graphics.Printing.PrintManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintManager : Windows.Graphics.Printing.IPrintManager
-->

# Windows.Graphics.Printing.PrintManager

## -description
Informs Windows that an application wishes to participate in printing. The [PrintManager](printmanager.md) class is also used for programmatically initiating printing.

## -remarks
The [PrintManager](printmanager.md) class is responsible for orchestrating the printing flow for Windows Store app. To use this class, you must first call the [GetForCurrentView](printmanager_getforcurrentview.md) method. This method returns the [PrintManager](printmanager.md) object that is specific to the current active window. Next, you must add an event listener for the [PrintTaskRequested](printmanager_printtaskrequested.md) event. This event is raised by the system when a user indicates the possibility of initiating a printing operation. Typically this occurs when the user taps the Devices charm, but the event may also be invoked programmatically.

When a Windows Store app registers its "intention" to print, it creates a print contract with the print manager. Here is a JavaScript code snippet to show how to register your app for a print contract using a [PrintManager](printmanager.md):





```javascript
    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
           
            //Register for print contract
            var printManager = Windows.Graphics.Printing.PrintManager.getForCurrentView();
            printManager.onprinttaskrequested = onPrintTaskRequested;
        
            WinJS.UI.processAll();
        }
    };

```

For more examples involving the print manager and to see some sample code for printing scenarios in Windows Store app, see [Printing](http://msdn.microsoft.com/library/windows/apps/hh465225.aspx) in the Windows Dev Center.

## -examples

## -see-also
[Authoring a  for Printers](http://msdn.microsoft.com/library/windows/hardware/br259129), [Developing v4 Print Drivers](http://msdn.microsoft.com/library/windows/hardware/br259124), [Printing](http://msdn.microsoft.com/library/windows/apps/hh465225.aspx)
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
Provides the entry-point for printing within an application.

## -remarks
The PrintManager class is responsible for orchestrating the printing flow for UWP app. To use this class, you must first call the [GetForCurrentView](printmanager_getforcurrentview_1363600702.md) method. This method returns the PrintManager object that is specific to the current active window. Next, you must add an event listener for the [PrintTaskRequested](printmanager_printtaskrequested.md) event. This event is raised when the application invokes the printing dialog via the **ShowPrintUIAsync** method.

When a UWP app registers its "intention" to print, it creates a print contract with the print manager. Here is a JavaScript code snippet to show how to register your app for a print contract using a PrintManager:

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

For more examples involving the print manager and to see some sample code for printing scenarios in UWP apps, see [Printing](/previous-versions/windows/apps/hh465225(v=win.10)) in the Windows Dev Center.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsSupported |

## -examples

## -see-also
[Authoring a  for Printers](/windows-hardware/drivers/devapps/windows-store-device-apps-for-printers), [Developing v4 Print Drivers](/windows-hardware/drivers/print/v4-printer-driver), [Printing](/previous-versions/windows/apps/hh465225(v=win.10))

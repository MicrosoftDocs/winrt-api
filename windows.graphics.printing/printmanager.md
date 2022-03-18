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
The PrintManager class is responsible for orchestrating the printing flow for UWP apps. To use this class, you must first call the [GetForCurrentView](printmanager_getforcurrentview_1363600702.md) method. This method returns the PrintManager object that is specific to the current active window. Next, you must add an event listener for the [PrintTaskRequested](printmanager_printtaskrequested.md) event. This event is raised when the application invokes the printing dialog via the **ShowPrintUIAsync** method.

When a UWP app registers its "intention" to print, it creates a print contract with the print manager. In the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing), registration is performed by the `RegisterForPrinting` method.

```csharp
public virtual void RegisterForPrinting()
{
   printDocument = new PrintDocument();
   printDocumentSource = printDocument.DocumentSource;
   printDocument.Paginate += CreatePrintPreviewPages;
   printDocument.GetPreviewPage += GetPrintPreviewPage;
   printDocument.AddPages += AddPrintPages;

   PrintManager printMan = PrintManager.GetForCurrentView();
   printMan.PrintTaskRequested += PrintTaskRequested;
}
```

For more examples involving the print manager and to see some sample code for printing scenarios in UWP apps, see [Printing](/windows/uwp/devices-sensors/print-from-your-app) and the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing)..

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsSupported |

## -examples

## -see-also
[UWP device apps for printers](/windows-hardware/drivers/devapps/windows-store-device-apps-for-printers), [Developing v4 Print Drivers](/windows-hardware/drivers/print/v4-printer-driver), [Printing](/windows/uwp/devices-sensors/print-from-your-app)

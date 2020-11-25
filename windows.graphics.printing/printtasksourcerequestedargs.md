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
Arguments associated with the [PrintTaskSourceRequestedHandler](printtasksourcerequestedhandler.md) delegate. Provides a method for handing the content to be printed to the PrintTask.

## -remarks
PrintTaskSourceRequestedArgs is used to set the source of the content to be printed. Here is a code snippet from the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing) that shows the [SetSource](printtasksourcerequestedargs_setsource_1925283600.md) method:

```csharp
protected virtual void PrintTaskRequested(PrintManager sender, PrintTaskRequestedEventArgs e)
{
    PrintTask printTask = null;
    printTask = e.Request.CreatePrintTask("C# Printing SDK Sample", sourceRequested =>
    {
        // Print Task event handler is invoked when the print job is completed.
        printTask.Completed += async (s, args) =>
        {
            // Notify the user when the print operation fails.
            if (args.Completion == PrintTaskCompletion.Failed)
            {
                await scenarioPage.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    MainPage.Current.NotifyUser("Failed to print.", NotifyType.ErrorMessage);
                });
            }
        };

        // Call PrintTaskSourceRequestedArgs.SetSource
        sourceRequested.SetSource(printDocumentSource);
    });
}
```

For more information on this and other printing scenarios, see [Printing](/windows/uwp/devices-sensors/print-from-your-app) and the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing).


## -examples

## -see-also

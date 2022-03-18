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
When you add print capabilities to your UWP app, you have to implement an event handler to process this event when it is raised. Here is a code snippet from the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing) that shows how to handle this event:

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

        sourceRequested.SetSource(printDocumentSource);
    });
}
```

To see the complete listing for this and other printing scenarios using **PrintTaskRequested**, see [Printing](/windows/uwp/devices-sensors/print-from-your-app) and the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing).

## -examples

## -see-also
[Printing](/windows/uwp/devices-sensors/print-from-your-app)

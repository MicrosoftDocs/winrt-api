---
-api-id: M:Windows.Graphics.Printing.PrintSupport.PrintSupportPrinterSelectedEventArgs.GetDeferral
-api-type: winrt method
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportPrinterSelectedEventArgs.GetDeferral

<!--
public Windows.Foundation.Deferral GetDeferral ();
-->


## -description

Informs the system that the app might continue to perform work after the [PrintSupportExtensionSession.PrinterSelected](xref:Windows.Graphics.Printing.PrintSupport.PrintSupportExtensionSession.PrinterSelected) event handler returns.

## -returns

A background task deferral.

## -remarks

If **PrinterSelected** event handler uses an asynchronous operation, it is possible for the handler to return before the background task has completed its work. As soon as the handler returns, the system might suspend or terminate the background task host process, which could prevent completion of asynchronous operations started by the background task.

To keep the host process from being suspended or terminated while the background task is running, use the **GetDeferral** method to get a background task deferral for each asynchronous operation initiated. Then, when the asynchronous operation is finished, call the [BackgroundTaskDeferral.Complete](xref:Windows.ApplicationModel.Background.BackgroundTaskDeferral.Complete) method.

## -see-also

## -examples



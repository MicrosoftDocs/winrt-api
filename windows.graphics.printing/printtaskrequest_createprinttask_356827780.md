---
-api-id: M:Windows.Graphics.Printing.PrintTaskRequest.CreatePrintTask(System.String,Windows.Graphics.Printing.PrintTaskSourceRequestedHandler)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Graphics.Printing.PrintTask CreatePrintTask(System.String title, Windows.Graphics.Printing.PrintTaskSourceRequestedHandler handler)
-->

# Windows.Graphics.Printing.PrintTaskRequest.CreatePrintTask

## -description
Creates a new [PrintTask](printtask.md) which indicates that the app has content to be printed.

## -parameters
### -param title
Title for the print task.

### -param handler
Pointer to a **PrintTaskSourceRequestedHandler** delegate for the print task.

## -returns
Pointer to the print task that was created.

## -remarks

## -examples

## -see-also
[Printing](https://docs.microsoft.com/previous-versions/windows/apps/hh465225(v=win.10)), [PrintTask](printtask.md), [PrintTaskSourceRequestedHandler](printtasksourcerequestedhandler.md)

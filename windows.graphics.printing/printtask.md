---
-api-id: T:Windows.Graphics.Printing.PrintTask
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintTask : Windows.Graphics.Printing.IPrintTask, Windows.Graphics.Printing.IPrintTask2, Windows.Graphics.Printing.IPrintTaskTargetDeviceSupport
-->

# Windows.Graphics.Printing.PrintTask

## -description
Represents a printing operation including the content to be printed, as well as providing access to information describing how the content is to be printed.

## -remarks
The **PrintTask** object represents a printing operation for UWP apps. The app is responsible for creating a **PrintTask** that is requested via the [PrintTaskRequested](printmanager_printtaskrequested.md) event on the [PrintManager](printmanager.md) object. To create **PrintTask** you must provide the name for the task and a [PrintTaskSourceRequestedHandler](printtasksourcerequestedhandler.md) delegate which is called when the user is ready to begin printing.

If the user decides not to print the task, the task may be completed without ever requesting the document source.

**PrintTask** contains a reference, in the form of the [Source](printtask_source.md) property, to the Print Document Source provided by the app. This object must support the [IPrintDocumentSource](iprintdocumentsource.md) interface.

In addition **PrintTask** contains an [Options](printtask_options.md) property which holds a reference to the [PrintTaskOptions](printtaskoptions.md) object. The **PrintTaskOptions** object provides access to details about the desired format of the printed content. **PrintTaskOptions** also provides methods which allow aspects of the print user experience to be modified. For example, **PrintTaskOptions** allows the app to define which of the supported options appear on the initial page of the print experience.

A print task goes through a specific set of states after its creation, and these changes in state can be used by an app to provide feedback to the user. Most of the state transitions are represented in the events that are raised by **PrintTask**. The print task is created in response to the **PrintTaskRequested** event on the **PrintManager** using the [CreatePrintTask](printtaskrequest_createprinttask_356827780.md) method on the **PrintTaskRequest** object. At this point the print task cannot be printed, since the content to print has not yet been provided. Typically a **PrintTaskRequested** event is raised when the user clicks on the Devices charm or an application initiates printing via the [ShowPrintUIAsync](printmanager_showprintuiasync_1397448831.md) method on the **PrintManager**.

Once the system determines that the task will be printed, the **PrintTaskSourceRequestedHandler** delegate is called to actually retrieve a reference to the Document Source object. At this point **PrintTask** is fully initialized. If the user decides not to complete the printing represented by the **PrintTask** object, the completion event is raised with a completion type of *abandoned*.

Upon initialization the printing user experience is responsible for helping the user select the different attributes, such as paper size or duplex, for the printed content. When the print window initialization is almost complete, **PrintTask** raises the *Previewing* event. This is when the user is now able to manipulate the contents of the **PrintTaskOptions** object via the print window. The user may change the values of the settings at any time during the Preview stage, and this must be taken into consideration the next time an app paginates the content. The **PrintTaskOptions** object provides basic functionality for retrieving the values of the print settings. For more advanced control of the print options, see [PrintTaskOptionDetails](../windows.graphics.printing.optiondetails/printtaskoptiondetails.md). Again the user may cancel this operation which will result in a completion event being raised with a completion type of *cancelled*.

When the user chooses to actually initiate printing by pressing Print in the print window, for example, the print task transitions from *Previewing* to the *Submitting* state, and the *Submitting* event is raised. The print document source is then passed a MakeDocument command and the process of submitting pages to the print subsystem begins. While pages are being submitted, the *Progressing* event is raised. An app may choose to use the information in the progressing event to let the user know how much content remains to be printed. Once the process of submitting the document to the print subsystem is complete, **PrintTask** raises the *Completion* event. This event indicates whether the job was submitted successfully, canceled, or failed during the submission process.

Here is a code snippet from the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing) that shows how to indicate the order in which the default print settings should be displayed:

```csharp
protected override void PrintTaskRequested(PrintManager sender, PrintTaskRequestedEventArgs e)
{
    PrintTask printTask = null;
    printTask = e.Request.CreatePrintTask("C# Printing SDK Sample", sourceRequestedArgs =>
    {
        IList<string> displayedOptions = printTask.Options.DisplayedOptions;

        // Choose the printer options to be shown.
        // The order in which the options are appended determines the order in which they appear in the UI
        displayedOptions.Clear();
        displayedOptions.Add(Windows.Graphics.Printing.StandardPrintTaskOptions.Copies);
        displayedOptions.Add(Windows.Graphics.Printing.StandardPrintTaskOptions.Orientation);
        displayedOptions.Add(Windows.Graphics.Printing.StandardPrintTaskOptions.MediaSize);
        displayedOptions.Add(Windows.Graphics.Printing.StandardPrintTaskOptions.Collation);
        displayedOptions.Add(Windows.Graphics.Printing.StandardPrintTaskOptions.Duplex);

        // Preset the default value of the printer option
        printTask.Options.MediaSize = PrintMediaSize.NorthAmericaLegal;

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

        sourceRequestedArgs.SetSource(printDocumentSource);
    });
}
```

To see the complete listing for this, and other printing scenarios using **PrintTask**, see [Printing](/windows/uwp/devices-sensors/print-from-your-app) and the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsPreviewEnabled |

## -examples

## -see-also
[Printing](/windows/uwp/devices-sensors/print-from-your-app), [PrintManager](printmanager.md)

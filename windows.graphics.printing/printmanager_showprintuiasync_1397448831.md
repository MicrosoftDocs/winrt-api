---
-api-id: M:Windows.Graphics.Printing.PrintManager.ShowPrintUIAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ShowPrintUIAsync()
-->

# Windows.Graphics.Printing.PrintManager.ShowPrintUIAsync

## -description
Programmatically initiates the user interface for printing content.

## -returns
A Boolean value to indicate a TRUE for success or a FALSE for a failure.

## -remarks
This method may be used by an application which has already used **GetForCurrentView** to retrieve the **PrintManager** instance and has registered a listener for the **PrintTaskRequested** event to initiate the printing user experience. **ShowPrintUIAsync** displays the appropriate printing window. If printing can't be performed at that time, the method will throw an exception. We recommend catching these exceptions and letting the user know when printing can't proceed, as shown here.



```csharp
async private void printButton_Click(object sender, RoutedEventArgs e)
{
    try
    {
        // Show print UI
        await Windows.Graphics.Printing.PrintManager.ShowPrintUIAsync();

    }
    catch
    {
        // Printing cannot proceed at this time
        ContentDialog noPrintingDialog = new ContentDialog()
        {
            Title = "Printing error",
            Content = "\nSorry, printing can't proceed at this time.", PrimaryButtonText = "OK"
        };
        await noPrintingDialog.ShowAsync();
    }
}
```

In this example, a print window is displayed in the event handler for a button click. If the method throws an exception (because printing can't be performed at that time), a [ContentDialog](../windows.ui.xaml.controls/contentdialog.md) control informs the user of the situation. For more info about printing from your app, see [Printing](/windows/uwp/devices-sensors/print-from-your-app).

## -examples

## -see-also
[Printing](/windows/uwp/devices-sensors/print-from-your-app)

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
This method may be used by an application which has already used **GetForCurrentView** to retrieve the **PrintManager** instance and has registered a listener for the **PrintTaskRequested** event to initiate the printing user experience. In general, applications are encouraged to let users print content via the Devices charm. For this reason, using the [ShowPrintUIAsync](printmanager_showprintuiasync.md) method is discouraged. **ShowPrintUIAsync** is provided mainly for scenarios in which the app is to provide guidance for users to help users complete a printing-related process. For example, guidance at the end of a ticket purchasing process, or after checking in for a flight, and then printing a boarding pass.

[ShowPrintUIAsync](printmanager_showprintuiasync.md) displays the appropriate printing window. If printing can't be performed at that time, the method will throw an exception. We recommend catching these exceptions and letting the user know when printing can't proceed, as shown here.



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

In this example, a print window is displayed in the event handler for a button click. If the method throws an exception (because printing can't be performed at that time), a [ContentDialog](../windows.ui.xaml.controls/contentdialog.md) control informs the user of the situation. For more info about printing from your app, see [Printing](http://msdn.microsoft.com/library/windows/apps/hh465225.aspx).

## -examples

## -see-also
[Printing](http://msdn.microsoft.com/library/windows/apps/hh465225.aspx)
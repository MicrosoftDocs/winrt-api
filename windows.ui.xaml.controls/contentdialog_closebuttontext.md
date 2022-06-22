---
-api-id: P:Windows.UI.Xaml.Controls.ContentDialog.CloseButtonText
-api-type: winrt property
---

<!-- Property syntax.
public string CloseButtonText { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentDialog.CloseButtonText

## -description
Gets or sets the text to display on the close button.



## -xaml-syntax
```xaml
<ContentDialog CloseButtonText="string"/>
```

## -property-value
The text to display on the close button.

## -remarks
Every dialog should contain a safe, nondestructive action button that enables the user to confidently exit the dialog.

Use the close button to create this button. This allows you to create the right user experience for all inputs including mouse, keyboard, touch, and gamepad. The dialog will close when:
- The user clicks or taps on the close button
- The user presses the system back button
- The user presses the ESC button on keyboard
- The user presses Gamepad B

Invoking the close button returns ContentDialogResult.None.

### Version compatibility

The CloseButtonText property is not available prior to Windows 10, version 1703. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you should use the [SecondaryButtonText](contentdialog_secondarybuttontext.md) property instead. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<ContentDialog x:Name="contentDialog1" Loaded="ContentDialog_Loaded">
    ...
</ContentDialog>
```

```csharp
private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.ContentDialog", "CloseButtonText"))
    {
        contentDialog1.CloseButtonText = "Cancel";
    }
    else
    {
        contentDialog1.SecondaryButtonText = "Cancel";
    }
}

```

## -examples

## -see-also

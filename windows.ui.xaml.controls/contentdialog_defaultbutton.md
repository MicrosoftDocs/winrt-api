---
-api-id: P:Windows.UI.Xaml.Controls.ContentDialog.DefaultButton
-api-type: winrt property
---

<!-- Property syntax.
public ContentDialogButton DefaultButton { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentDialog.DefaultButton

## -description
Gets or sets a value that indicates which button on the dialog is the default action.



## -property-value
A value of the enumeration. The default is **None.**

## -remarks
You may optionally choose to differentiate one of the three buttons as the default button. Specifying the default button causes the following to happen:
- The button receives the Accent Button visual treatment
- The button will respond to the ENTER key automatically
    - When the user presses the ENTER key on the keyboard, the click handler associated with the default button will fire and the [ContentDialogResult](contentdialogresult.md) will return the value associated with the default button
    - If the user has placed focus on a control that handles ENTER, the default button will not respond to ENTER presses
- The button will receive focus automatically when the dialog is opened unless the dialog’s content contains focusable UI

### Version compatibility

The DefaultButton property is not available prior to Windows 10, version 1703. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<ContentDialog x:Name="contentDialog1" Loaded="ContentDialog_Loaded">
    ...
</ContentDialog>
```

```csharp
private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.ContentDialog", "DefaultButton"))
    {
        contentDialog1.DefaultButton = ContentDialogButton.Primary;
    }
}

```

## -see-also

## -examples

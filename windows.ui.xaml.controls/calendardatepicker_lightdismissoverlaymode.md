---
-api-id: P:Windows.UI.Xaml.Controls.CalendarDatePicker.LightDismissOverlayMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode { get;  set; }
-->

# Windows.UI.Xaml.Controls.CalendarDatePicker.LightDismissOverlayMode

## -description
Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.



## -property-value
A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.

## -remarks
Transient UI, such as the open calendar view of a [CalendarDatePicker](calendardatepicker.md), closes when you click or tap outside of it. This is called light-dismiss. "Overlay" refers to the area outside of a light-dismiss UI.

By default, the "overlay" is darkened on the Xbox, and not darkened on other devices families. You can set LightDismissOverlayMode to **On** to make your app darken the "overlay" area on all device families, or set it to **Off** to not darken the "overlay" area on all device families.

### Version compatibility

The LightDismissOverlayMode property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```csharp
 private void MainPage_Loaded(object sender, RoutedEventArgs e)
 {
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.CalendarDatePicker", "LightDismissOverlayMode"))
    {
        calendarDatePicker1.LightDismissOverlayMode = LightDismissOverlayMode.On;
    }
}

```



## -examples

## -see-also

---
-api-id: E:Windows.UI.Xaml.Controls.Control.FocusEngaged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FocusEngaged<Windows.UI.Xaml.Controls.Control,  Windows.UI.Xaml.Controls.FocusEngagedEventArgs>
-->

# Windows.UI.Xaml.Controls.Control.FocusEngaged

## -description
Occurs when focus is constrained within the control boundaries (for game pad/remote interaction).



## -xaml-syntax
```xaml
<control FocusEngaged="eventhandler"/>
```


## -remarks
For event data, see [FocusEngagedEventArgs](focusengagedeventargs.md).

Focus engagement makes it easier to use a game pad or remote control to interact with an app. Setting focus engagement does not affect keyboard or other input devices.

When the [IsFocusEngagementEnabled](control_isfocusengagementenabled.md) property is set to **true**, it marks the control as requiring focus engagement. This means that the user must press the A/Select button to "engage" the control and interact with it. When they are finished, they can press the B/Back button to disengage the control and navigate away from it.

For more info about this property, see the [Focus engagement](/windows/uwp/input-and-devices/designing-for-tv) section of the [Designing for Xbox and TV](/windows/uwp/input-and-devices/designing-for-tv) article.

### Version compatibility

The FocusEngaged event is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not connect this event without first performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this event before you use it.

```xaml
<Slider x:Name="slider1" Loaded="Slider_Loaded"/>

```

```csharp
private void Slider_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsEventPresent("Windows.UI.Xaml.Controls.Control", "FocusEngaged"))
    {
        slider1.FocusEngaged += Slider1_FocusEngaged;
    }
}

```



## -examples

## -see-also

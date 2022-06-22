---
-api-id: M:Windows.UI.Xaml.Controls.Control.RemoveFocusEngagement
-api-type: winrt method
---

<!-- Method syntax
public void RemoveFocusEngagement()
-->

# Windows.UI.Xaml.Controls.Control.RemoveFocusEngagement

## -description
Releases focus from the control boundaries for a control that has focus engagement (for game pad/remote interaction).



## -remarks
Focus engagement makes it easier to use a game pad or remote control to interact with an app. Setting focus engagement does not affect keyboard or other input devices.

When the [IsFocusEngagementEnabled](control_isfocusengagementenabled.md) property is set to **true**, it marks the control as requiring focus engagement. This means that the user must press the A/Select button to "engage" the control and interact with it. When they are finished, they can press the B/Back button to disengage the control and navigate away from it. You can call RemoveFocusEngagement to programmatically disengage a control.

For more info, see the [Focus engagement](/windows/uwp/input-and-devices/designing-for-tv) section of the [Designing for Xbox and TV](/windows/uwp/input-and-devices/designing-for-tv) article.

### Version compatibility

The RemoveFocusEngagement method is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not call this method without first performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this method before you use it.

```csharp
if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Controls.Control", "RemoveFocusEngagement"))
{
    control1.RemoveFocusEngagement();
}

```



## -examples

## -see-also

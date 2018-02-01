---
-api-id: T:Windows.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class CalendarDatePickerAutomationPeer : FrameworkElementAutomationPeer, FrameworkElementAutomationPeer, IInvokeProvider, IValueProvider
-->

# Windows.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer

## -description
Exposes [CalendarDatePicker](../windows.ui.xaml.controls/calendardatepicker.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime [CalendarDatePicker](../windows.ui.xaml.controls/calendardatepicker.md) class creates a new [CalendarDatePickerAutomationPeer](calendardatepickerautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from [CalendarDatePickerAutomationPeer](calendardatepickerautomationpeer.md) if you are deriving a custom class from [CalendarDatePicker](../windows.ui.xaml.controls/calendardatepicker.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **DatePickerAutomationPeer**

[CalendarDatePickerAutomationPeer](calendardatepickerautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname.md) returns "CalendarDatePicker".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.Button](automationcontroltype.md).
+ [GetPattern](automationpeer_getpattern.md) reports support for [PatternInterface.Invoke](patterninterface.md) ([IInvokeProvider](../windows.ui.xaml.automation.provider/iinvokeprovider.md) ). The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [CalendarDatePicker](../windows.ui.xaml.controls/calendardatepicker.md)

## -examples


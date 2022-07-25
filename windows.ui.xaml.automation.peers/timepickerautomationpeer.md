---
-api-id: T:Windows.UI.Xaml.Automation.Peers.TimePickerAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class TimePickerAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.ITimePickerAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.TimePickerAutomationPeer

## -description
Exposes [TimePicker](../windows.ui.xaml.controls/timepicker.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [TimePicker](../windows.ui.xaml.controls/timepicker.md) class creates a new TimePickerAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from TimePickerAutomationPeer if you are deriving a custom class from [TimePicker](../windows.ui.xaml.controls/timepicker.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **TimePickerAutomationPeer**

TimePickerAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "TimePicker".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Group](automationcontroltype.md).
+ [GetName](automationpeer_getname_1386609741.md) attempts to get a string from the owner control's [Header](../windows.ui.xaml.controls/timepicker_header.md) property. Otherwise, the framework peer behavior of using [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) applies.
+ [GetPattern](automationpeer_getpattern_2046576749.md) reports no pattern support.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [TimePicker](../windows.ui.xaml.controls/timepicker.md), [DatePicker](../windows.ui.xaml.controls/datepicker.md)

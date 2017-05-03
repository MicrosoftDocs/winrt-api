---
-api-id: T:Windows.UI.Xaml.Automation.Peers.CheckBoxAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class CheckBoxAutomationPeer : Windows.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer, Windows.UI.Xaml.Automation.Peers.ICheckBoxAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.CheckBoxAutomationPeer

## -description
Exposes [CheckBox](../windows.ui.xaml.controls/checkbox.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [CheckBox](../windows.ui.xaml.controls/checkbox.md) class creates a new [CheckBoxAutomationPeer](checkboxautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from [CheckBoxAutomationPeer](checkboxautomationpeer.md) if you are deriving a custom class from [CheckBox](../windows.ui.xaml.controls/checkbox.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **CheckBoxAutomationPeer**

[CheckBoxAutomationPeer](checkboxautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) reports that the peer provides pattern support for [PatternInterface.Toggle](patterninterface.md) ([IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md) ). This is actually coming from the [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md) base class; [CheckBoxAutomationPeer](checkboxautomationpeer.md) doesn't override the **Core** method further.
+ [GetClassName](automationpeer_getclassname.md) returns "CheckBox".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.CheckBox](automationcontroltype.md).
+ The peer can fire the [PropertyChanged](automationevents.md) automation event when [ToggleState](appbarautomationpeer_togglestate.md) of the peer and owner control changes.
This peer has the base class [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) and inherits its behavior other than the overrides indicated above. Notably, [GetName](automationpeer_getname.md) returns a string value based on examining the current **Content**. For more info, see [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[ToggleButtonAutomationPeer](togglebuttonautomationpeer.md), [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md), [CheckBox](../windows.ui.xaml.controls/checkbox.md), [IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)
---
-api-id: T:Windows.UI.Xaml.Automation.Peers.PasswordBoxAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class PasswordBoxAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IPasswordBoxAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.PasswordBoxAutomationPeer

## -description
Exposes [PasswordBox](../windows.ui.xaml.controls/passwordbox.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [PasswordBox](../windows.ui.xaml.controls/passwordbox.md) class creates a new [PasswordBoxAutomationPeer](passwordboxautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [PasswordBox](../windows.ui.xaml.controls/passwordbox.md) is sealed, so the normal scenario of deriving from the [PasswordBox](../windows.ui.xaml.controls/passwordbox.md) class and its existing peer isn't applicable to [PasswordBoxAutomationPeer](passwordboxautomationpeer.md).

### Default peer implementation and overrides in **PasswordBoxAutomationPeer**

[PasswordBoxAutomationPeer](passwordboxautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) reports no pattern support.
+ [GetClassName](automationpeer_getclassname.md) returns "PasswordBox".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.Edit](automationcontroltype.md).
+ [IsPassword](automationpeer_ispassword.md) returns **true**.
An automation **Name** is not calculated for you for [PasswordBox](../windows.ui.xaml.controls/passwordbox.md) content. You should assign a value using the [AutomationProperties.Name](../windows.ui.xaml.automation/automationproperties_name.md) attached property.

Any value entered for a password is potentially sensitive information and is often handled differently from a normal edit box by assistive technology implementations. For example a screen reader might not read characters aloud when [IsPassword](automationpeer_ispassword.md) returns **true**.

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [PasswordBox](../windows.ui.xaml.controls/passwordbox.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)
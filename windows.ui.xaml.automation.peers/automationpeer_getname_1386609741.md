---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetName
-api-type: winrt method
---

<!-- Method syntax
public string GetName()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetName

## -description
Gets text that describes the element that is associated with this automation peer. The Microsoft UI Automation  **Name** value is the primary identifier used by most assistive technology when they represent your app's UI by interacting with the Microsoft UI Automation framework.



## -returns
The name of the element that is the peer's owner, as used by assistive technology and other Microsoft UI Automation clients.

## -remarks
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) introduces behavior to GetName by providing an intermediate [GetNameCore](automationpeer_getnamecore_2066192858.md) implementation. If an element has a value for the **LabeledBy**Microsoft UI Automation property, the labeling element's **Name** value is used as the **Name**.

[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) also introduces behavior through an internal **GetPlainText** method that other default peer classes may override in order to access the content model of that control and return a useful default for **Name**. For example, any [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) derived class will use a string representation of its [Content](../windows.ui.xaml.controls/contentcontrol_content.md) value as the default **Name**. This is enabled because internally [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) implements **GetPlainText** and imparts that behavior to all [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) derived classes. This is how you get a useful **Name** default from the string value of a [Button](../windows.ui.xaml.controls/button.md), for example.

Other specific peers also may have an intermediate [GetNameCore](automationpeer_getnamecore_2066192858.md) implementation that provides a useful way for that particular Windows Runtime control to provide built-in values for **Name**. The source of these values comes from other UI properties that are typically set in XAML or as app user code. For example, [TextBoxAutomationPeer](textboxautomationpeer.md) implements behavior that uses the value of the [Text](../windows.ui.xaml.controls/textbox_text.md) property from the owner [TextBox](../windows.ui.xaml.controls/textbox.md) as the default **Name**. From the user code perspective, the default behavior can be overridden by applying a different [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) value. From the peer implementer / provider perspective, the default behavior of the peer can be changed by deriving a new peer class from the existing peer, overriding [GetNameCore](automationpeer_getnamecore_2066192858.md), and giving it a new implementation that wouldn't call the base implementation in at least some cases.

To learn more about the possible default behavior of specific peer classes for default Windows Runtime controls, see the reference topic for that particular peer class and look for implementation notes in the Remarks section.

## -examples

## -see-also
[Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)

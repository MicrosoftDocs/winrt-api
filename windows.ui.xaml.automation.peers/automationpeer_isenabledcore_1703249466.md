---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsEnabledCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsEnabledCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsEnabledCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsEnabled](automationpeer_isenabled_180154405.md) or an equivalent Microsoft UI Automation client API.


## -returns
**true** if the element can be interacted with; otherwise, **false**.

## -remarks
The standard implementation at the [AutomationPeer](automationpeer.md) level returns **true**. However, [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) adds behavior that checks whether the owner is a [Control](../windows.ui.xaml.controls/control.md) and forwards owner information from [Control.IsEnabled](../windows.ui.xaml.controls/control_isenabled.md). For cases where the owner is not a control but does have a peer, such as for a [TextBlock](../windows.ui.xaml.controls/textblock.md), the [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) implementation returns **true**.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

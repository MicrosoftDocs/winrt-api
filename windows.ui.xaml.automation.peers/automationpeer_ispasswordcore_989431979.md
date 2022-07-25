---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsPasswordCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsPasswordCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsPasswordCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsPassword](automationpeer_ispassword_1875117543.md) or an equivalent Microsoft UI Automation client API.


## -returns
**true** if the element contains sensitive content; otherwise, **false**.

## -remarks
The standard implementation returns **false**. [PasswordBoxAutomationPeer](passwordboxautomationpeer.md) provides an implementation that returns **true**. If the peer being returned by your control is [PasswordBoxAutomationPeer](passwordboxautomationpeer.md) or derived from it, you will inherit that behavior.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [PasswordBox](../windows.ui.xaml.controls/passwordbox.md), [PasswordBoxAutomationPeer](passwordboxautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

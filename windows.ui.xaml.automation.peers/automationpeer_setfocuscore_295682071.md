---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.SetFocusCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected void SetFocusCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.SetFocusCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [SetFocus](automationpeer_setfocus_192955311.md) or an equivalent Microsoft UI Automation client API.



## -remarks
The standard implementation uses [IsKeyboardFocusable](automationpeer_iskeyboardfocusable_2030365113.md) to determine whether the peer reports that the owner can be focused. [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) adds behavior that performs the actual focus operation if it is possible.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

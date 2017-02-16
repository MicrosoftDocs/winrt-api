---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.SetFocusCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected void SetFocusCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.SetFocusCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [SetFocus](automationpeer_setfocus.md) or an equivalent Microsoft UI Automation client API.

## -remarks
The standard implementation uses [IsKeyboardFocusable](automationpeer_iskeyboardfocusable.md) to determine whether the peer reports that the owner can be focused. [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) adds behavior that performs the actual focus operation if it is possible.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Control.Focus](../windows.ui.xaml.controls/control_focus.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)
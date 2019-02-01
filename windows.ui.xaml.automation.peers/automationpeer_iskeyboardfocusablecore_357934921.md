---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsKeyboardFocusableCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsKeyboardFocusableCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsKeyboardFocusableCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsKeyboardFocusable](automationpeer_iskeyboardfocusable_2030365113.md) or an equivalent Microsoft UI Automation client API.

## -returns
**true** if the element can accept keyboard focus; otherwise, **false**.

## -remarks
The standard implementation at the [AutomationPeer](automationpeer.md) level returns **false**. However, [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) adds behavior that checks whether the owner is a [Control](../windows.ui.xaml.controls/control.md) or otherwise focusable, and whether the owner is enabled.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](https://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)

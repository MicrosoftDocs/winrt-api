---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.HasKeyboardFocusCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool HasKeyboardFocusCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.HasKeyboardFocusCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [HasKeyboardFocus](automationpeer_haskeyboardfocus_1926443629.md) or an equivalent Microsoft UI Automation client API.


## -returns
**true** if the element has keyboard focus; otherwise, **false**.

## -remarks
The standard implementation at the [AutomationPeer](automationpeer.md) level checks whether the owner has focus, and always returns **false** if the owner isn't focusable. [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) expands this behavior somewhat because it adds awareness of owner characteristics that rely on the owner being a [Control](../windows.ui.xaml.controls/control.md) subclass. Test the existing return value in the peer that you are using or overriding and then override that behavior if necessary.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

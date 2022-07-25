---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsControlElementCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsControlElementCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsControlElementCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsControlElement](automationpeer_iscontrolelement_1004644794.md) or an equivalent Microsoft UI Automation client API.


## -returns
**true** if the element is a control; otherwise, **false**.

## -remarks
The standard implementation at the [AutomationPeer](automationpeer.md) level returns **false**. However, [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) adds behavior that changes the default to **true**. Other specific peers also may affect this behavior; for example many peers return different values depending on whether the owner is created from a control template. Test the existing return value in the peer that you are using or overriding and then override that behavior if necessary.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

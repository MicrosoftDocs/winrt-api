---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsRequiredForFormCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsRequiredForFormCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsRequiredForFormCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsRequiredForForm](automationpeer_isrequiredforform_1300796554.md) or an equivalent Microsoft UI Automation client API.


## -returns
**true** if the element must be completed; otherwise, **false**.

## -remarks
The standard implementation returns false. Overriding this value at the peer level to return true is probably an uncommon scenario, because you are implying that every instance of your control has a required-for-form behavior no matter what app or UI situation it is used for. It's more typical for apps to specify a required-for-form behavior that is declared in the app's XAML UI definitions, by setting [AutomationProperties.IsRequiredForForm](/uwp/api/windows.ui.xaml.automation.automationproperties.isrequiredforform).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetAutomationIdCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetAutomationIdCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetAutomationIdCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetAutomationId](automationpeer_getautomationid_1912681712.md) or an equivalent Microsoft UI Automation client API.



## -returns
The automation identifier.

## -remarks
Providing a class-based behavior for **AutomationId** is uncommon. Typically, app authors set values for elements in the app by setting the [AutomationProperties.AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties.automationid) attached property in the XAML UI definition.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

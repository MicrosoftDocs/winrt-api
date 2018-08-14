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
Providing a class-based behavior for **AutomationId** is uncommon. Typically, app authors set values for elements in the app by setting the [AutomationProperties.AutomationId](../windows.ui.xaml.automation/automationproperties_automationid.md) attached property in the XAML UI definition.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)
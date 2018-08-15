---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetHelpTextCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetHelpTextCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetHelpTextCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetHelpText](automationpeer_gethelptext_1251901404.md) or an equivalent Microsoft UI Automation client API.

## -returns
The help text.

## -remarks
Specifying a control behavior for help text is uncommon. In most cases, apps that need it will establish help text information in the UI by applying the [AutomationProperties.HelpText](../windows.ui.xaml.automation/automationproperties_helptext.md) attached property to the UI definition XAML.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [AutomationProperties.HelpText](../windows.ui.xaml.automation/automationproperties_helptext.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)
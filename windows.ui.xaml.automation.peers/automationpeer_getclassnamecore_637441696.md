---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClassNameCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetClassNameCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClassNameCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetClassName](automationpeer_getclassname_614238974.md) or an equivalent Microsoft UI Automation client API.



## -returns
The class name.

## -remarks
You should never invoke the base behavior, and all custom peers should override GetClassNameCore to report the class name that is unique to that peer class. For more info, see [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [GetLocalizedControlTypeCore](automationpeer_getlocalizedcontroltypecore_1799576178.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

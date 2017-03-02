---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClassNameCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetClassNameCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClassNameCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetClassName](automationpeer_getclassname.md) or an equivalent Microsoft UI Automation client API.

## -returns
The class name.

## -remarks
You should never invoke the base behavior, and all custom peers should override [GetClassNameCore](automationpeer_getclassnamecore.md) to report the class name that is unique to that peer class. For more info, see [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [GetLocalizedControlTypeCore](automationpeer_getlocalizedcontroltypecore_1799576178.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)

---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetChildrenCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Automation.Peers.AutomationPeer> GetChildrenCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetChildrenCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetChildren](automationpeer_getchildren.md) or an equivalent Microsoft UI Automation client API.

## -returns
The collection of [AutomationPeer](automationpeer.md) objects for child elements.

## -remarks
The base implementation returns null. Peers that represent controls with item collections may override this result. Test the behavior of the peer you are using or overriding and override [GetChildrenCore](automationpeer_getchildrencore.md) if you want to change that behavior.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)
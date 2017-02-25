---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsOffscreenCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsOffscreenCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsOffscreenCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsOffscreen](automationpeer_isoffscreen.md) or an equivalent Microsoft UI Automation client API.

## -returns
**true** if the element is not on the screen; otherwise, **false**.

## -remarks
The standard implementation returns a result that is based on the owner's [Visibility](../windows.ui.xaml/uielement_visibility.md) value.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [UIElement.Visibility](../windows.ui.xaml/uielement_visibility.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)
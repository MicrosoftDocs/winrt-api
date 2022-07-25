---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetOrientationCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Automation.Peers.AutomationOrientation GetOrientationCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetOrientationCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetOrientation](automationpeer_getorientation_419829207.md) or an equivalent Microsoft UI Automation client API.



## -returns
The orientation of the control.

## -remarks
The base [AutomationPeer](automationpeer.md) implementation returns **None**. Peers that represent items may modify this to report information from their container. [ScrollBarAutomationPeer](scrollbarautomationpeer.md) and [SliderAutomationPeer](sliderautomationpeer.md) both have a pattern they can access that knows about orientation, so these peers can return a determined value. Test the existing return value in the peer that you are using or overriding and then override that behavior if necessary.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

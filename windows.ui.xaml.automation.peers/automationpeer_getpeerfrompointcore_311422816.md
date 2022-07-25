---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetPeerFromPointCore(Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Automation.Peers.AutomationPeer GetPeerFromPointCore(Windows.Foundation.Point point)
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetPeerFromPointCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetPeerFromPoint](automationpeer_getpeerfrompoint_1490374452.md) or an equivalent Microsoft UI Automation client API.



## -parameters
### -param point
The relative position of the target UI element in the UI.

## -returns
The [AutomationPeer](automationpeer.md) for the UI element at the specified point.

## -remarks
<!--This one is vague because I can't find the base implementation-->
Test the existing return value in the peer that you are using or overriding and then override that behavior if necessary.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)

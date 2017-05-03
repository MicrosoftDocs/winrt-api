---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetLabeledByCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Automation.Peers.AutomationPeer GetLabeledByCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetLabeledByCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetLabeledBy](automationpeer_getlabeledby.md) or an equivalent Microsoft UI Automation client API.

## -returns
The [AutomationPeer](automationpeer.md) for the element that is targeted by the [UIElement](../windows.ui.xaml/uielement.md).

## -remarks
Specifying a control behavior for labeling is uncommon except for composite data presentation controls that use headers or similar metaphors. In most cases apps establish labeling information between the elements in an app-specific UI by applying the [AutomationProperties.LabeledBy](../windows.ui.xaml.automation/automationproperties_labeledby.md) attached property to the UI definition XAML.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)
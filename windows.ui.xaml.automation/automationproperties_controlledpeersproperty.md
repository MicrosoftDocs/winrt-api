---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeersProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty ControlledPeersProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeersProperty

## -description
Identifies a dependency property that's used for controlled peers, which is an array of automation elements that are manipulated by the automation element that supports this property.

## -property-value
A dependency property identifier.

## -remarks
There's no public dependency property for **ControlledPeers** because this is an advanced scenario. Use [GetControlledPeers](automationproperties_getcontrolledpeers.md) to get the list of controlled automation elements.

**ControlledPeers** is used when an automation element affects one or more segments of the application UI or the desktop; otherwise, it is hard to associate the impact of the control operation with UI elements.

## -examples

## -see-also

---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeersProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty ControlledPeersProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeersProperty

## -description

Identifies the ControlledPeers attached property, which is used for a collection of automation elements that can be manipulated by the specified automation element.

## -property-value

The identifier for the ControlledPeers attached property.

## -remarks

There's no public attached property for **ControlledPeers** because this is an advanced scenario. Use [GetControlledPeers](automationproperties_getcontrolledpeers_853183966.md) to get the list of controlled automation elements.

**ControlledPeers** is used when an automation element affects one or more segments of either the application UI or the desktop. This makes it easier to associate the impact of the control operation on other UI elements.

## -examples

## -see-also

[Accessible text requirements](https://docs.microsoft.com/en-us/windows/uwp/design/accessibility/accessible-text-requirements#auto-suggest-accessibility), [Custom automation peers](https://docs.microsoft.com/en-us/windows/uwp/design/accessibility/custom-automation-peers)

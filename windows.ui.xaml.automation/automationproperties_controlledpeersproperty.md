---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeersProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty ControlledPeersProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeersProperty

## -description

Identifies the [AutomationProperties.ControlledPeers](automationproperties_controlledpeers.md) attached property.



## -property-value

The identifier for the [AutomationProperties.ControlledPeers](automationproperties_controlledpeers.md) attached property.

## -remarks

> [!NOTE]

`ControlledPeers` is used when an automation element affects one or more segments of either the application UI or the desktop. This makes it easier to associate the impact of the control operation on other UI elements.

> `AutomationProperties.ControlledPeers` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the collection of elements, call [GetControlledPeers](automationproperties_getcontrolledpeers_853183966.md), passing the item as the input parameter.

## -examples

## -see-also

[Accessible text requirements](/windows/uwp/design/accessibility/accessible-text-requirements#auto-suggest-accessibility), [Custom automation peers](/windows/uwp/design/accessibility/custom-automation-peers)

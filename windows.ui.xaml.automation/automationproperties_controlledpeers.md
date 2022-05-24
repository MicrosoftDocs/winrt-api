---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeers
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.ControlledPeers

<!--
see GetControlledPeers
-->

## -description

Gets a collection of automation elements that can be manipulated by the specified automation element.

## -remarks

> [!NOTE]
> `AutomationProperties.ControlledPeers` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the collection of elements, call [GetControlledPeers](automationproperties_getcontrolledpeers_853183966.md), passing the item as the input parameter.

## -see-also

## -examples

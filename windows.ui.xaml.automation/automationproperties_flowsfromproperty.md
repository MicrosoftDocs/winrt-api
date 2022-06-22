---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.FlowsFromProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty FlowsFromProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.FlowsFromProperty

## -description

Identifies the [FlowsFrom](automationproperties_flowsfrom.md) attached property.



## -property-value

The identifier for the [FlowsFrom](automationproperties_flowsfrom.md) attached property.

## -remarks

> [!NOTE]
> `AutomationProperties.FlowsFrom` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the array of elements, call [GetFlowsFrom](automationproperties_getflowsfrom_1915156123.md), passing the item as the input parameter.

## -examples

## -see-also

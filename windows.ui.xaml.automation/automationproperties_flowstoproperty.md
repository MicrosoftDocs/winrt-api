---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.FlowsToProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty FlowsToProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.FlowsToProperty

## -description

Identifies the [FlowsTo](automationproperties_flowsto.md) attached property.



## -property-value

The identifier for the [FlowsTo](automationproperties_flowsto.md) attached property.

## -remarks

> [!NOTE]
> `AutomationProperties.FlowsTo` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the array of elements, call [GetFlowsTo](automationproperties_getflowsto_483856830.md), passing the item as the input parameter.

## -examples

## -see-also

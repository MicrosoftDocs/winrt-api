---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.FlowsTo
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.FlowsTo

<!--
see GetFlowsTo
-->

## -description

Gets an array of automation elements that suggests the reading order after the current automation element.

## -remarks

The `FlowsTo` property specifies the reading order when automation elements are not exposed or structured in the same reading order as perceived by the user. While the `FlowsTo` property can specify multiple succeeding elements, it typically contains only the next element in the reading order.

> [!NOTE]
> `AutomationProperties.FlowsTo` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the array of elements, call [GetFlowsTo](automationproperties_getflowsto_483856830.md), passing the item as the input parameter.

## -see-also

## -examples

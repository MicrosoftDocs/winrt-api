---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.FlowsFrom
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.FlowsFrom

<!--
see GetFlowsFrom
-->

## -description

Gets an array of automation elements that suggests the reading order before the current automation element.

## -remarks

The `FlowsFrom` property specifies the reading order when automation elements are not exposed or structured in the same reading order as perceived by the user. While the `FlowsFrom` property can specify multiple preceding elements, it typically contains only the prior element in the reading order.

> [!NOTE]
> `AutomationProperties.FlowsFrom` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the array of elements, call [GetFlowsFrom](automationproperties_getflowsfrom_1915156123.md), passing the item as the input parameter.

## -see-also

[Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

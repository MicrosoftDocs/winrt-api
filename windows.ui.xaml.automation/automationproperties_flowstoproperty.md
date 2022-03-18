---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.FlowsToProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty FlowsToProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.FlowsToProperty

## -description
Gets the identifier for the **FlowsTo** attached property, which is an array of automation elements that suggests the reading order after the current automation element.

Equivalent WinUI property: [Microsoft.UI.Xaml.Automation.AutomationProperties.FlowsToProperty](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.flowstoproperty).

## -property-value
The identifier for the "flows to" attached property.

## -remarks
The **FlowsTo** property specifies the reading order when automation elements are not exposed or structured in the same reading order as perceived by the user. While the **FlowsTo** property can specify multiple succeeding elements, it typically contains only the next element in the reading order.

## -examples

## -see-also

---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.DescribedByProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty DescribedByProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.DescribedByProperty

## -description

Identifies the [AutomationProperties.DescribedBy](automationproperties_describedby.md) attached property.



## -property-value

The identifier for the [AutomationProperties.DescribedBy](automationproperties_describedby.md) attached property.

## -remarks

> [!NOTE]
> `AutomationProperties.DescribedBy` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the array of elements, call [GetDescribedBy](automationproperties_getdescribedby_903862056.md), passing the item as the input parameter.

## -examples

## -see-also

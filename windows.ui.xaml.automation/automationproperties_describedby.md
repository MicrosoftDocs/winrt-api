---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.DescribedBy
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.DescribedBy

<!--
see GetDescribedBy
-->

## -description

Gets an array of elements that provide more information about the automation element.

## -remarks

`AutomationProperties.DescribedBy` is used when an automation element is explained by another segment of the application UI. For example, the property can point to a text element of "2,529 items in 85 groups, 10 items selected" from a complex custom list object. Instead of using the object model for clients to digest similar information, the `DescribedBy` property can offer quick access to the UI element that may already offer useful end-user information that describes the UI element.

> [!NOTE]
> `AutomationProperties.DescribedBy` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the array of elements, call [GetDescribedBy](automationproperties_getdescribedby_903862056.md), passing the item as the input parameter.

## -see-also

[Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.AnnotationsProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty AnnotationsProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.AnnotationsProperty

## -description

Identifies the [AutomationProperties.Annotations](automationproperties_annotations.md) attached property.



## -property-value

The identifier for the [AutomationProperties.Annotations](automationproperties_annotations.md) attached property.

## -remarks

> [!NOTE]
> [AutomationProperties.Annotations](automationproperties_annotations.md) is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the list of annotations, call [GetAnnotations](automationproperties_getannotations_1232704323.md), passing the item as the input parameter.

## -examples

## -see-also

[AutomationProperties.Annotations](automationproperties_annotations.md)

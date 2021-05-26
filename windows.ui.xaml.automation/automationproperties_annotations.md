---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.Annotations
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.Annotations

<!--
see GetAnnotations
-->

## -description

Gets a list of annotation objects in a document, such as comment, header, footer, and so on.

## -remarks

> [!NOTE]
> `AutomationProperties.Annotations` is an atypical attached property because it does not have a `Set` accessor, and thus is not really a XAML attached property with a markup usage. It uses the attached property model as a property store, but does not support an Extensible Application Markup Language (XAML) usage. To get the list of annotations, call [GetAnnotations](automationproperties_getannotations_1232704323.md), passing the item as the input parameter.

## -see-also

[Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

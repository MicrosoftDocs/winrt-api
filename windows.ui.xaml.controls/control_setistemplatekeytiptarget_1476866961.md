---
-api-id: M:Windows.UI.Xaml.Controls.Control.SetIsTemplateKeyTipTarget(Windows.UI.Xaml.DependencyObject,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public void Control.SetIsTemplateKeyTipTarget(DependencyObject element, Boolean value)
-->

# Windows.UI.Xaml.Controls.Control.SetIsTemplateKeyTipTarget

## -description

Sets the value of the [Control.IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md) XAML attached property for a target element.

## -parameters

### -param element

The object to which the property value is written.

### -param value

The value to set.

## -remarks

Keytips are badges displayed next to controls that support access keys when the user presses the Alt key. Each keytip contains the alphanumeric keys that activate the associated control.

This method is a utility method for the property system, and isn't used in most app scenarios. In most cases you set the **Control.IsTemplateFocusTarget** XAML attached property in XAML and won't need this method. For more info, see the [Control.IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md) attached property.

## -see-also

[Control.IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md), [Access keys](/windows/apps/design/input/access-keys), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

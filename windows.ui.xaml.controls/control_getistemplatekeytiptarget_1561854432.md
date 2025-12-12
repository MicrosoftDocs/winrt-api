---
-api-id: M:Windows.UI.Xaml.Controls.Control.GetIsTemplateKeyTipTarget(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax.
public bool Control.GetIsTemplateKeyTipTarget(DependencyObject element)
-->

# Windows.UI.Xaml.Controls.Control.GetIsTemplateKeyTipTarget

## -description

Gets the value of the [Control.IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md) XAML attached property for the target element.

## -parameters

### -param element

The object from which the property value is read.

## -returns

The [Control.IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md) XAML attached property value of the specified object.

## -remarks

Keytips are badges displayed next to controls that support access keys when the user presses the Alt key. Each keytip contains the alphanumeric keys that activate the associated control.

This method is a utility method for the property system, and isn't used in most app scenarios. In most cases you set the **Control.IsTemplateKeytipTarget** XAML attached property in XAML and won't need this method. For more info, see the [Control.IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md) attached property.

## -see-also

[Access keys](/windows/apps/design/input/access-keys), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Control.IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md)

## -examples

---
-api-id: P:Windows.UI.Xaml.Controls.Control.IsTemplateKeyTipTarget
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Controls.Control.IsTemplateKeyTipTarget

<!--
see GetIsTemplateKeyTipTarget, and SetIsTemplateKeyTipTarget
-->

## -description

Gets or sets a value that indicates whether this element is the part of a control template where the keytip is placed.

## -remarks

Keytips are badges displayed next to controls that support access keys when the user presses the Alt key. Each keytip contains the alphanumeric keys that activate the associated control.

This property is for use in a [ControlTemplate](controltemplate.md) only. If it's set outside of a `ControlTemplate`, it's ignored. If this attached property is set more than once in a `ControlTemplate`, an exception is thrown.

- Type: Boolean
- Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.control.istemplatekeytiptargetproperty">IsTemplateKeyTipTargetProperty</a>
- Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.control.getistemplatekeytiptarget">GetIsTemplateKeyTipTarget</a>, <a href="/uwp/api/windows.ui.xaml.controls.control.setistemplatekeytiptarget">SetIsTemplateKeyTipTarget</a>

## -see-also

[Access keys](/windows/apps/design/input/access-keys), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

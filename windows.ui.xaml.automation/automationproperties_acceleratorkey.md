---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.AcceleratorKey
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.AcceleratorKey

<!--
see GetAcceleratorKey, and SetAcceleratorKey
-->


## -description

Gets or sets a string containing the accelerator key (also called shortcut key) combinations for the automation element.

## -remarks

Shortcut key combinations invoke an action. For example, CTRL+O is often used to invoke the Open file common dialog box. An automation element that has the `AcceleratorKey` property can implement the [Invoke](/previous-versions/windows/desktop/api/oaidl/nf-oaidl-idispatch-invoke) control pattern for the action that is equivalent to the shortcut command.

- Type: string
- Identifier field: [AcceleratorKeyProperty](automationproperties_acceleratorkeyproperty.md)
- Accessor methods: [GetAcceleratorKey](automationproperties_getacceleratorkey_1491119690.md), [SetAcceleratorKey](automationproperties_setacceleratorkey_300007954.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples



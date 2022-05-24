---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.LocalizedControlType
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.LocalizedControlType

<!--
see GetLocalizedControlType, and SetLocalizedControlType
-->

## -description

Gets or sets a localized text string that describes the type of control that the automation element represents.

## -remarks

The string should contain only lowercase characters:

+ Correct: "button"
+ Incorrect: "Button"

When `LocalizedControlType` is not specified by the element provider, the default localized string is supplied by the framework, according to the control type of the element (for example, "button" for the [Button](../windows.ui.xaml.controls/button.md) control type). An automation element with the `Custom` control type must support a localized control type string that represents the role of the element (for example, "color picker" for a custom control that enables users to choose and specify colors).

When a custom value is supplied, the string must match the application UI language or the operating system default UI language.

<ul><li>Type: string</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.localizedcontroltypeproperty">LocalizedControlTypeProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getlocalizedcontroltype">GetLocalizedControlType</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setlocalizedcontroltype">SetLocalizedControlType</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

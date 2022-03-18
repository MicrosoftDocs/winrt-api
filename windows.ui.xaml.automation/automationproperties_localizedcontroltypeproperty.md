---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.LocalizedControlTypeProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty LocalizedControlTypeProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.LocalizedControlTypeProperty

## -description
Identifies the localized control type dependency property, which is a text string describing the type of control that the automation element represents.

Equivalent WinUI property: [Microsoft.UI.Xaml.Automation.AutomationProperties.LocalizedControlTypeProperty](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.localizedcontroltypeproperty).

## -property-value
The dependency property identifier.

## -remarks
The string should contain only lowercase characters:


+ Correct: "button"
+ Incorrect: "Button"


When **LocalizedControlType** is not specified by the element provider, the default localized string is supplied by the framework, according to the control type of the element (for example, "button" for the [Button](../windows.ui.xaml.controls/button.md) control type). An automation element with the **Custom** control type must support a localized control type string that represents the role of the element (for example, "color picker" for a custom control that enables users to choose and specify colors).

When a custom value is supplied, the string must match the application UI language or the operating system default UI language.

## -examples

## -see-also

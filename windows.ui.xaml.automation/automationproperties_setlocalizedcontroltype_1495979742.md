---
-api-id: M:Windows.UI.Xaml.Automation.AutomationProperties.SetLocalizedControlType(Windows.UI.Xaml.DependencyObject,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetLocalizedControlType(Windows.UI.Xaml.DependencyObject element, System.String value)
-->

# Windows.UI.Xaml.Automation.AutomationProperties.SetLocalizedControlType

## -description
Sets a localized string that indicates the type of the specified control.



## -parameters
### -param element
The control for which to set the type.

### -param value
A localized string that indicates the type of the control specified by the *element* parameter.

## -remarks
Provides a mechanism to alter the control type read by Narrator. This is helpful in describing custom UI as "Menu" or "Button" where default controls are not used or composite UI built from common controls is used to create new functionality.

## -examples

## -see-also

[AutomationProperties.LocalizedControlType](automationproperties_localizedcontroltype.md), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

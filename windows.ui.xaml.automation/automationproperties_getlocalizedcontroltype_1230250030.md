---
-api-id: M:Windows.UI.Xaml.Automation.AutomationProperties.GetLocalizedControlType(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public string GetLocalizedControlType(Windows.UI.Xaml.DependencyObject element)
-->

# Windows.UI.Xaml.Automation.AutomationProperties.GetLocalizedControlType

## -description
Gets a localized string that indicates the type of the specified control.



## -parameters
### -param element
The control for which to retrieve the type.

## -returns
A localized string that indicates the type of the control specified by the *element* parameter.

## -remarks
Provides a mechanism to alter the control type read by Narrator. This is helpful in describing custom UI as "Menu" or "Button" where default controls are not used or composite UI built from common controls is used to create new functionality.

## -examples

## -see-also

[AutomationProperties.LocalizedControlType](automationproperties_localizedcontroltype.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)

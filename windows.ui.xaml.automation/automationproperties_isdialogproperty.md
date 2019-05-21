---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.IsDialogProperty
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public DependencyProperty IsDialogProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.IsDialogProperty

## -description

Identifies the [AutomationProperties.IsDialog](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property, which is a Boolean value that indicates whether the automation element is a dialog window.

## -property-value

The identifier for the [AutomationProperties.IsDialog](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property.

## -remarks

In many cases, assistive technology (AT) treats a dialog window differently than other types of windows. A screen reader, for example, typically speaks the title of the dialog, the focused control in the dialog, and then the content of the dialog up to the focused control (for example, "Do you want to save your changes before closing"). For standard windows, a screen reader typically speaks the window title followed by the focused control.

When [AutomationProperties.IsDialog](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) is **true**, a client application should treat the element as a dialog window.

[Flyout](..\windows.ui.xaml.controls\flyout.md) and [ContentDialog](..\windows.ui.xaml.controls\contentdialog.md) elements default to **true** for [AutomationProperties.IsDialog](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties).

## -see-also

## -examples


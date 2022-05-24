---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.IsDialog
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.IsDialog

<!--
see GetIsDialog, and SetIsDialog
-->

## -description

Gets or sets a value that indicates whether the automation element is a dialog window.

## -remarks

In many cases, assistive technology (AT) treats a dialog window differently than other types of windows. A screen reader, for example, typically speaks the title of the dialog, the focused control in the dialog, and then the content of the dialog up to the focused control (for example, "Do you want to save your changes before closing"). For standard windows, a screen reader typically speaks the window title followed by the focused control.

When `AutomationProperties.IsDialog` is `true`, a client application should treat the element as a dialog window.

[Flyout](../windows.ui.xaml.controls/flyout.md) and [ContentDialog](../windows.ui.xaml.controls/contentdialog.md) elements default to `true` for `AutomationProperties.IsDialog`.

<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.isdialogproperty">IsDialogProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getisdialog">GetIsDialog</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setisdialog">SetIsDialog</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples



---
-api-id: M:Windows.UI.Xaml.Automation.AutomationProperties.SetIsDialog(Windows.UI.Xaml.DependencyObject,System.Boolean)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void AutomationProperties.SetIsDialog(DependencyObject element, Boolean value)
-->

# Windows.UI.Xaml.Automation.AutomationProperties.SetIsDialog

## -description

Sets a Boolean value that indicates whether the specified element should be identified as a dialog window.

Equivalent WinUI method: [Microsoft.UI.Xaml.Automation.AutomationProperties.SetIsDialog](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.setisdialog).

## -parameters

### -param element

The object to identify as a dialog window.

### -param value

**true** if the element should be identified as a dialog window; otherwise, **false**.

## -remarks

[Flyout](..\windows.ui.xaml.controls\flyout.md) and [ContentDialog](..\windows.ui.xaml.controls\contentdialog.md) elements default to **true** for [AutomationProperties.IsDialog](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties).

## -see-also

## -examples

---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBoxTemplateSettings : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings, Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings2
-->

# Windows.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings

## -description
Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a [ComboBox](../windows.ui.xaml.controls/combobox.md) control. Not intended for general use.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.Primitives.ComboBoxTemplateSettings](/windows/winui/api/microsoft.ui.xaml.controls.primitives.comboboxtemplatesettings) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
Get instances of ComboBoxTemplateSettings by querying the value of [TemplateSettings](../windows.ui.xaml.controls/combobox_templatesettings.md).

The values from ComboBoxTemplateSettings are typically used as either the **To** or **From** values of theme animations or transitions.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | DropDownContentMinWidth |

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md)

---
-api-id: T:Windows.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum ComboBoxSelectionChangedTrigger : int {
	Always = 1
	Committed = 0
}
-->

# Windows.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger

## -description
Defines constants that specify what action causes a [SelectionChanged](/uwp/api/windows.ui.xaml.controls.primitives.selector.selectionchanged) event to occur.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ComboBoxSelectionChangedTrigger](/windows/winui/api/microsoft.ui.xaml.controls.comboboxselectionchangedtrigger) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields

### -field Committed:0
A change event occurs when the user commits a selection in the combo box.

### -field Always:1
A change event occurs each time the user navigates to a new selection in the combo box.

## -remarks
This enumeration is used by the [ComboBox.SelectionChangedTrigger](combobox_selectionchangedtrigger.md) property.

## -see-also

## -examples


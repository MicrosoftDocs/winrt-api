---
-api-id: P:Windows.UI.Xaml.Controls.TextBox.IsReadOnly
-api-type: winrt property
---

<!-- Property syntax
public bool IsReadOnly { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBox.IsReadOnly

## -description
Gets or sets the value that determines if the user can change the text in the text box.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TextBox.IsReadOnly](/windows/winui/api/microsoft.ui.xaml.controls.textbox.isreadonly) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<TextBox IsReadOnly="bool"/>
```


## -property-value
**true** if the text box is read-only; otherwise, **false**. The default is **false**.

## -remarks
The default control template for [TextBox](textbox.md) has a visual state that tracks whether the [TextBox](textbox.md) is read-only. If the [TextBox](textbox.md) is read-only, it appears in a gray color in most themes. This also tracks if [Control.IsEnabled](control_isenabled.md) is **false**.

## -examples

## -see-also
[Control.IsEnabled](control_isenabled.md)

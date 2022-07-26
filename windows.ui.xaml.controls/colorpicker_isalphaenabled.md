---
-api-id: P:Windows.UI.Xaml.Controls.ColorPicker.IsAlphaEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsAlphaEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ColorPicker.IsAlphaEnabled

## -description

Gets or sets a value that indicates whether the alpha channel can be modified.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ColorPicker.IsAlphaEnabled](/windows/winui/api/microsoft.ui.xaml.controls.colorpicker.isalphaenabled) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<ColorPicker IsAlphaEnabled="bool" .../>
```

## -property-value

**true** if the alpha channel is enabled; otherwise, **false**. The default is **false**.

## -remarks

The **IsAlphaSliderVisible** and **IsAlphaTextInputVisible** properties are ignored if IsAlphaEnabled is **false**.

## -see-also

## -examples


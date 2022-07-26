---
-api-id: P:Windows.UI.Xaml.Controls.NavigationViewItem.Icon
-api-type: winrt property
---

<!-- Property syntax.
public IconElement Icon { get;  set; }
-->

# Windows.UI.Xaml.Controls.NavigationViewItem.Icon

## -description

Gets or sets the icon to show next to the menu item text.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationViewItem.Icon](/windows/winui/api/microsoft.ui.xaml.controls.navigationviewitem.icon) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationViewItem Icon="symbolName" .../>
- or -
<NavigationViewItem>
  <NavigationViewItem.Icon>
    iconElement
  </NavigationViewItem.Icon>
</NavigationViewItem>
```

## -xaml-values

<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration.</dd>
<dt>iconElement</dt><dd>iconElementA single object element that derives from IconElement and describes the graphic content of the button. The object element is typically one of these classes: SymbolIcon, FontIcon, or PathIcon.</dd>
</dl>

## -property-value

The icon to show next to the menu item text. The default in **null**.

## -remarks

You can assign a value from the [Symbol](symbol.md) enumeration, or a Unicode string that references a glyph in the Segoe MDL2 Assets font.

You can use the Character Map application that comes with Windows to browse the font's glyphs and find their Unicode values. Then, use the format `"&#x(UNICODE);"` in XAML, or the format `"\u(UNICODE)"` in code, where `(UNICODE)` is the value of the glyph that indicates the location in the font file. See [FontIcon](fonticon.md) for more examples.

The Segoe MDL2 Assets font ships with Windows 10, and new glyphs might be added in every release. You should verify that the Unicode value you choose is available in the minimum SDK build version your project targets.

## -see-also

[FontIcon](fonticon.md), [IconElement](iconelement.md)

## -examples


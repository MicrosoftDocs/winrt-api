 Keey
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

## -xaml-syntax

```xaml
<NavigationViewItem Icon="symbolName" .../>
```

```xaml
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

You can assign a value from the [Symbol](symbol.md) enumeration or a unicode string referencing a glyph in the font Segoe MDL 2 Assets. You can use the Character Map application that comes in windows to browse the font's glyphs and use the format **"&#x(UNICODE);"** in XAML code where UNICODE is the value of the glyph that indicates the location in the font file or the format **"\u(UNICODE)"** in code-behind. Keep in mind that the Segoe MDL2 Font comes with Windows 10, and more glyphs are added in every release, verify that the unicode value you choose is availale in the min SDK build version your project is targetting.

## -see-also

## -examples


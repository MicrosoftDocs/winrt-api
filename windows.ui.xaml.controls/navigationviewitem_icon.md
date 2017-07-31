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

## -see-also

## -examples


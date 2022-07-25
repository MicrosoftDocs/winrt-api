---
-api-id: P:Windows.UI.Xaml.Controls.AppBarToggleButton.Icon
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.IconElement Icon { get;  set; }
-->

# Windows.UI.Xaml.Controls.AppBarToggleButton.Icon

## -description
Gets or sets the graphic content of the app bar toggle button.



## -xaml-syntax
```xaml
<AppBarToggleButton Icon="symbolName" .../>
- or -
<AppBarToggleButton>
    <AppBarToggleButton.Icon>
        iconElement
    </AppBarToggleButton.Icon>
</AppBarToggleButton>
```


## -xaml-values
<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration.</dd>
<dt>iconElement</dt><dd>iconElementA single object element that derives from IconElement and describes the graphic content of the button. The object element is typically one of these classes: SymbolIcon, FontIcon, or PathIcon.</dd>
</dl>
## -property-value
The graphic content of the app bar toggle button.

## -remarks

## -examples

## -see-also
[Symbol](symbol.md), [IconElement](iconelement.md), [SymbolIcon](symbolicon.md), [FontIcon](fonticon.md), [PathIcon](pathicon.md)

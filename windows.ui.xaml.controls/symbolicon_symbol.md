---
-api-id: P:Windows.UI.Xaml.Controls.SymbolIcon.Symbol
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Symbol Symbol { get;  set; }
-->

# Windows.UI.Xaml.Controls.SymbolIcon.Symbol

## -description
Gets or sets the Segoe MDL2 Assets glyph used as the icon content.



## -xaml-syntax
```xaml
<SymbolIcon Symbol="symbolName"/>
```


## -xaml-values
<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration, which enumerates a subset of the Segoe MDL2 Assets font.</dd>
</dl>
## -property-value
A named constant of the numeration that specifies the Segoe MDL2 Assets glyph to use.

## -remarks

### Notes for previous versions

> **Windows 8.x**
> On Windows 8, the standard glyphs are provided by the Segoe UI Symbol font.

## -examples
```xaml

<AppBarButton Label="Accept">
    <AppBarButton.Icon>
        <SymbolIcon Symbol="Accept"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also

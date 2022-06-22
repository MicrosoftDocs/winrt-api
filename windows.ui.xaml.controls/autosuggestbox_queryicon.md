---
-api-id: P:Windows.UI.Xaml.Controls.AutoSuggestBox.QueryIcon
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.IconElement QueryIcon { get;  set; }
-->

# Windows.UI.Xaml.Controls.AutoSuggestBox.QueryIcon

## -description
Gets or sets the graphic content of the button that is clicked to initiate a query.



## -xaml-syntax
```xaml
<AutoSuggestBox QueryIcon="symbolName" .../>
- or -
<AutoSuggestBox>
    <AutoSuggestBox.QueryIcon>
        iconElement
    </AutoSuggestBox.QueryIcon>
</AutoSuggestBox>

```


## -xaml-values
<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration.</dd>
<dt>iconElement</dt><dd>iconElementA single object element that derives from IconElement and describes the graphic content of the button. The object element is typically one of these classes: SymbolIcon, FontIcon, or PathIcon.</dd>
</dl>
## -property-value
The graphic content of the button that is clicked to initiate a query, if present; otherwise, **null**. The default is **null**.

## -remarks

## -examples

## -see-also

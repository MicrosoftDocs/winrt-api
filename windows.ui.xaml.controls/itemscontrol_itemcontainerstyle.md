---
-api-id: P:Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style ItemContainerStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsControl.ItemContainerStyle

## -description
Gets or sets the style that is used when rendering the item containers.

## -xaml-syntax
```xaml
<itemsControl>
  <itemsControl.ItemContainerStyle>
    inlineStyle
  </itemsControl.ItemContainerStyle>
</itemsControl>
```

```xaml
<itemsControl ItemContainerStyle="resourceReferenceToStyle"/>
```


## -xaml-values
<dl><dt>inlineStyle</dt><dd>inlineStyleA single Style object element. That Style would typically have multiple setters that set properties on the item container type being targeted. (For ListBox, that type is ListBoxItem.)</dd>
<dt>resourceReferenceToStyle</dt><dd>resourceReferenceToStyleA {StaticResource} markup extension reference to an existing Style from a XAML resource dictionary.</dd>
</dl>
## -property-value
The style applied to the item containers. The default is null.

## -remarks

## -examples

## -see-also

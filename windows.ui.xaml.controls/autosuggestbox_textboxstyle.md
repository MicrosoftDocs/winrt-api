---
-api-id: P:Windows.UI.Xaml.Controls.AutoSuggestBox.TextBoxStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style TextBoxStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.AutoSuggestBox.TextBoxStyle

## -description
Gets or sets the style of the auto-suggest text box.



## -xaml-syntax
```xaml

<AutoSuggestBox TextBoxStyle={StaticResource styleResourceKey}/>
- or -
<AutoSuggestBox>
  <AutoSuggestBox.TextBoxStyle>
    <Style TargetType="TextBox">
      oneOrMoreSetters
    </Style>
  </AutoSuggestBox.TextBoxStyle>
</AutoSuggestBox>
```


## -xaml-values
<dl><dt>styleResourceKey</dt><dd>styleResourceKeyThe key that identifies the style being requested. The key refers to an existing resource in a ResourceDictionary.</dd>
<dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more Setter elements with Property attributes that target the dependency properties of the TextBox component of the AutoSuggestBox template.</dd>
</dl>
## -property-value
The style of the auto-suggest text box.

## -remarks

## -examples

## -see-also

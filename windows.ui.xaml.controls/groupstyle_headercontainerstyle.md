---
-api-id: P:Windows.UI.Xaml.Controls.GroupStyle.HeaderContainerStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style HeaderContainerStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.GroupStyle.HeaderContainerStyle

## -description
Gets or sets the style that is applied to the header for each item.



## -xaml-syntax
```xaml
<GroupStyle ...>
  <GroupStyle.HeaderContainerStyle>
    <Style TargetType="headerItemType">
      oneOrMoreSetters
    </Style>
  </GroupStyle.HeaderContainerStyle>
</GroupStyle>
```


## -xaml-values
<dl><dt>headerItemType</dt><dd>headerItemTypeMust use a TargetType of either GridViewHeaderItem or ListViewHeaderItem.</dd>
<dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more Setter elements with Property attributes that target the dependency properties of either GridViewHeaderItem or ListViewHeaderItem</dd>
</dl>
## -property-value
The style that is applied to the header for each item. The default is **null**.

## -remarks

## -examples

## -see-also
[GridViewHeaderItem](gridviewheaderitem.md), [ListViewHeaderItem](listviewheaderitem.md)
